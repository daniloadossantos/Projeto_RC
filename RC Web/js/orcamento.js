const openForm = () => {
	document.getElementById('cadastro-form-servico').classList.add('active');
	modal.classList.add('active');
	modal.classList.remove('hidden');
}

const closeForm = () => {
	document.getElementById('cadastro-form-servico').classList.remove('active');
    modal.classList.remove('active');
    setTimeout(() => {
        modal.classList.remove('hidden');
    }, 500);
}

//Sequence para o ID
let proximoId = 1;
function gerarNumeroUnico() {
    let numero = proximoId++;
    return numero.toString().padStart(4, '0');
}

//Formatar o campo de preço
const precoInput = document.getElementById('preco');
precoInput.addEventListener('input', function(event) {
    const valor = event.target.value.replace(/\D/g, '');
    const valorFormatado = (Number(valor) / 100).toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'});
    event.target.value = valorFormatado;
});

//CRUD serviço
const getLocalStorage = () => JSON.parse(localStorage.getItem('db_rcarcondicionado')) ?? []
const setLocalStorage = (dbRcarcondicionado) => localStorage.setItem("db_rcarcondicionado", JSON.stringify(dbRcarcondicionado))

const createServico = (servico) => {
	const dbRcarcondicionado = getLocalStorage()
	dbRcarcondicionado.push (servico)
	setLocalStorage(dbRcarcondicionado);
}

const readServico = () => getLocalStorage()

const updateServico = (index, servico) => {
	const dbRcarcondicionado = readServico()
	dbRcarcondicionado[index] = servico
	setLocalStorage(dbRcarcondicionado)
}

const deleteServico = (index) => {
	const dbRcarcondicionado = readServico()
	dbRcarcondicionado.splice(index,1)
	setLocalStorage(dbRcarcondicionado)
}

const isValidFields = () => {
	return document.getElementById ('form').reportValidity()
}

//Interação com form
const refreshTable = () => {
	ordenarNomes()
	updateTable()
	const input = document.querySelector('.campo_pesquisa')
	input.value = ""
}

const ordenarNomes = () => {
	const dbRcarcondicionado = readServico()
	dbRcarcondicionado.sort(function(a,b) {
	if(a.nome < b.nome) {
	  return -1;
	}
	else if (a.nome > b.nome) {
	  return 1;
	}
	else {
	  return 0;
	}
	});
	setLocalStorage(dbRcarcondicionado);
}

const clearFields = () => {
	const fields = document.querySelectorAll('.form-field')
	fields.forEach(field => field.value = "")
}

const clearModal = () => {
    clearFields();
	document.getElementById('tipo-servico').value = '';
}

document.getElementById('limparForm').addEventListener('click', clearModal);

const geradorId = (index) => {
	var numId = 0
	numId = index + 1
	return numId
}

const saveServico = () => {
	if(isValidFields()){
		const servico = {
		  numId: gerarNumeroUnico(),
		  nome: document.getElementById('nome').value,
		  tipoServico: document.getElementById('tipo-servico').value,
		  descricao: document.getElementById('descricao').value,
		  preco: document.getElementById('preco').value
		}
		const index = document.getElementById('nome').dataset.index
		if(index == 'new'){
		  createServico(servico)
		  ordenarNomes()
		  updateTable()
		  clearFields()
		  closeForm()

		} 
		else{
		  updateServico(index, servico)
		  ordenarNomes()
		  updateTable()
		  closeForm()

		}
	}
}

const createRow = (servico, index) => {
	const newRow = document.createElement('tr');
    newRow.innerHTML = `
        <td><input type="checkbox" id="id-${index}" class="checkbox-item" /></td>  
        <td>${servico.numId}</td>
        <td>${servico.nome}</td>
        <td>${servico.tipoServico}</td>
        <td>${servico.descricao}</td>
        <td>${servico.preco}</td>
        <td>
            <div class="btn_crud btn_acoes">
                <button id="edit-${index}" class="btn_crud btn_altera" type="button" data-action="edit"></button>
                <button id="delete-${index}" class="btn_crud btn_exclui" type="button" data-action="delete"></button>
            </div>
        </td>
    `;
	document.querySelector('#tb_servicos>tbody').appendChild(newRow)
}

const clearTable = () => {
	const rows = document.querySelectorAll('#tb_servicos>tbody tr')
	rows.forEach(row => row.parentNode.removeChild(row))
}

const fillFields = (servico) => {
	document.getElementById('nome').value = servico.nome
	document.getElementById('tipo-servico').value = servico.tipoServico
	document.getElementById('descricao').value = servico.descricao
	document.getElementById('preco').value = servico.preco
	document.getElementById('nome').dataset.index = servico.index
	openForm()
}

const editServico = (index) => {
	const servico = readServico()[index]
	servico.index = index
	fillFields(servico)
	openForm()
}

const editDelete = (event) => {
	if(event.target.type == 'button'){
		const [action, index] = event.target.id.split('-')
		if(action == 'edit'){
		  editServico(index)
		}
		else {
		  const servico = readServico()[index]  
		  const response = confirm (`Deseja realmente excluir o registro de ${servico.nome}?`)
		  if (response){ 
			deleteServico(index)
			updateTable()
		  }
		}
	}
}

const isAnyCheckboxSelected = () => {
	const checkboxes = document.querySelectorAll('.checkbox-item');
	for (const checkbox of checkboxes) {
		if (checkbox.checked) {
		  return true;
		}
	}
	return false;
};

const toggleActionButtonsVisibility = () => {
    const checkboxes = document.querySelectorAll('.checkbox-item');
    for (const checkbox of checkboxes) {
        const row = checkbox.closest('tr');
        const actionButtons = row.querySelector('.btn_acoes');
        if (checkbox.checked) {
            actionButtons.style.display = 'inline-flex';
        } else {
            actionButtons.style.display = 'none';
        }
    }
};


const updateTable = () => {
	const dbRcarcondicionado = readServico();
	clearTable();
	dbRcarcondicionado.forEach(createRow);
	ordenarNomes();

	const checkboxes = document.querySelectorAll('.checkbox-item');
	checkboxes.forEach(checkbox => {
		checkbox.addEventListener('click', toggleActionButtonsVisibility);
	});
	toggleActionButtonsVisibility();
};

updateTable();

const searchByName = () => {
	const searchTerm = document.querySelector('input[name="consulta"]').value.toLowerCase(); 
	const dbRcarcondicionado = readServico();
	const filteredList = dbRcarcondicionado.filter(servico => {
		return servico.nome.toLowerCase().includes(searchTerm);
	});
	clearTable(); 
	filteredList.forEach(createRow); 
};

//Eventos
document.getElementById('cadastrarServico').addEventListener('click', saveServico)

document.querySelector('#tb_servicos>tbody').addEventListener('click', editDelete)

document.getElementById('close-cadastro-form').addEventListener('click', closeForm)

document.getElementById('open-cadastro-form').addEventListener('click', openForm)

document.getElementById('btn_refresh').addEventListener('click', refreshTable)

document.getElementById('btn_search').addEventListener('click', (event) => {
	event.preventDefault();
	searchByName(); 
});

//Permitir que apenas 1 check fique selecionado por vez
const checkboxes = document.querySelectorAll('.checkbox-item');
const actionButtons = document.querySelectorAll('.btn_acoes');
checkboxes.forEach((checkbox, index) => {
    checkbox.addEventListener('change', () => {
        // Se o checkbox for desmarcado, oculta os botões de ação
        if (!checkbox.checked) {
            const row = checkbox.closest('tr');
            const actionButtonsRow = row.querySelector('.btn_acoes');
            actionButtonsRow.style.display = 'none';
        } else {
            // Desmarca todas as outras checkboxes
            checkboxes.forEach(otherCheckbox => {
                if (otherCheckbox !== checkbox) {
                    otherCheckbox.checked = false;
                }
            });

            // Oculta todos os botões de ação
            actionButtons.forEach(buttons => {
                buttons.style.display = 'none';
            });

            // Exibe os botões de ação apenas para a linha atualmente selecionada
            const row = checkbox.closest('tr');
            const actionButtonsRow = row.querySelector('.btn_acoes');
            actionButtonsRow.style.display = 'inline-flex';
        }
    });
});

