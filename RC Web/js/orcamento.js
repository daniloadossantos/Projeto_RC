const modal = document.getElementById('cadastro-form-servico');

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
/*let proximoId = 1;
function gerarNumeroUnico() {
    let numero = proximoId++;
    return numero.toString().padStart(4, '0');
}*/

const getLastUsedId = () => {
    return localStorage.getItem('lastUsedId') || 0;
}

//func para salvar o último ID do localstorage
const saveLastUsedId = (id) => {
    localStorage.setItem('lastUsedId', id);
}

//func para gerar um novo ID uniq
const generateUniqueId = () => {
    let lastId = parseInt(getLastUsedId());
    let newId = lastId + 1;
    saveLastUsedId(newId);
    return newId.toString().padStart(4, '0');
}

//Formatar o campo de preço
const precoInput = document.getElementById('preco');
precoInput.addEventListener('input', function(event) {
    const valor = event.target.value.replace(/\D/g, '');
    const valorFormatado = (Number(valor) / 100).toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'});
    event.target.value = valorFormatado;
});

//CRUD serviço
const getLocalStorage = () => JSON.parse(localStorage.getItem('db_local')) ?? []
const setLocalStorage = (dbLocal) => localStorage.setItem("db_local", JSON.stringify(dbLocal))

const createServico = (servico) => {
	const dbLocal = getLocalStorage()
	dbLocal.push (servico)
	setLocalStorage(dbLocal);
}

const readServico = () => getLocalStorage()

const updateServico = (index, servico) => {
	const dbLocal = readServico()
	dbLocal[index] = servico
	setLocalStorage(dbLocal)
}

const deleteServico = (index) => {
	const dbLocal = readServico()
	dbLocal.splice(index,1)
	setLocalStorage(dbLocal)
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
	const dbLocal = readServico()
	dbLocal.sort(function(a,b) {
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
	setLocalStorage(dbLocal);
}

const clearFields = () => {
	const fields = document.querySelectorAll('.form-field')
	fields.forEach(field => field.value = "")
}

const clearModal = () => {
    clearFields();
    document.getElementById('tipo-servico').value = '';
    document.getElementById('idAgendamento').value = '';
    document.getElementById('quantidade').value = '';
    document.getElementById('descricao').value = '';
    document.getElementById('preco').value = '';
    document.getElementById('nome').value = '';
    document.getElementById('nomeTecnico').value = '';
    document.getElementById('nome').dataset.index = 'new';
    document.getElementById('nomeTecnico').dataset.index = 'new';
    openForm();
};

document.getElementById('limparForm').addEventListener('click', clearModal);

const geradorId = (index) => {
	var numId = 0
	numId = index + 1
	return numId
}

const saveServico = () => {
    if (isValidFields()) {
        const tipoServico = document.getElementById('tipo-servico').value;
        const quantidade = parseInt(document.getElementById('quantidade').value);
        const descricao = document.getElementById('descricao').value;
        const preco = document.getElementById('preco').value;
        const nome = document.getElementById('nome').value;
        const nomeTecnico = document.getElementById('nomeTecnico').value;

        const servico = {
            numId: generateUniqueId(),
            tipoServico: tipoServico,
            quantidade: quantidade,
            descricao: descricao,
            preco: preco,
            nome: nome,
            nomeTecnico: nomeTecnico
        };

        const index = document.getElementById('nome').dataset.index;
        if (index === 'new') {
            createServico(servico);
        } else {
            updateServico(index, servico);
        }

        updateTable();
        clearFields();
        closeForm();
    }
};

const calcularPreco = () => {
    const tipoServicoSelecionado = document.getElementById('tipo-servico').value;
    const quantidade = parseInt(document.getElementById('quantidade').value);
    const precos = {
        "Instalação": 100,
        "Manutenção": 120,
        "Reparo": 80,
        "Limpeza": 90
    };

    if (precos.hasOwnProperty(tipoServicoSelecionado)) {
        const precoUnitario = precos[tipoServicoSelecionado];
        const precoTotal = precoUnitario * quantidade;

        document.getElementById('preco').value = precoTotal.toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'});
    }
	else {
        document.getElementById('preco').value = '';
    }
};

document.getElementById('tipo-servico').addEventListener('change', calcularPreco);
document.getElementById('quantidade').addEventListener('change', calcularPreco);

const createRow = (servico, index) => {
    const newRow = document.createElement('tr');
    newRow.innerHTML = `
        <td><input type="checkbox" id="id-${index}" class="checkbox-item" /></td>  
        <td>${servico.numId}</td>
        <td>${servico.nome}</td>
        <td>${servico.tipoServico}</td>
        <td>${servico.descricao}</td>
        <td>${servico.preco}</td>
        <td>${servico.nomeTecnico}</td>
        <td>
            <div class="btn_crud btn_acoes">
                <button id="edit-${index}" class="btn_crud btn_altera" type="button" data-action="edit"></button>
                <button id="delete-${index}" class="btn_crud btn_exclui" type="button" data-action="delete"></button>
            </div>
        </td>
    `;
    document.querySelector('#tb_servicos>tbody').appendChild(newRow);
};

const clearTable = () => {
	const rows = document.querySelectorAll('#tb_servicos>tbody tr')
	rows.forEach(row => row.parentNode.removeChild(row))
}

const fillFields = (servico) => {
	document.getElementById('nome').value = servico.nome
	document.getElementById('nomeTecnico').value = servico.nomeTecnico
	document.getElementById('tipo-servico').value = servico.tipoServico
	document.getElementById('quantidade').value = servico.quantidade
	document.getElementById('descricao').value = servico.descricao
	document.getElementById('preco').value = servico.preco
	document.getElementById('idAgendamento').value = servico.idAgendamento
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
    let selectedCount = 0;
    const checkboxes = document.querySelectorAll('.checkbox-item');
    for (const checkbox of checkboxes) {
        if (checkbox.checked) {
            selectedCount++;
        }
        if (selectedCount > 1) {
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
	const dbLocal = readServico();
	clearTable();
	dbLocal.forEach(createRow);
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
  if (searchTerm !== ""){
    const dbLocal = readTecnico();
    const filteredList = dbLocal.filter(tecnico => {
    return tecnico.nome.toLowerCase().includes(searchTerm);
  });
    clearTable(); 
    filteredList.forEach(createRow);
  } else return;
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
        if (!checkbox.checked) {
            const row = checkbox.closest('tr');
            const actionButtonsRow = row.querySelector('.btn_acoes');
            actionButtonsRow.style.display = 'none';
        }
		else {
            checkboxes.forEach(otherCheckbox => {
                if (otherCheckbox !== checkbox) {
                    otherCheckbox.checked = false;
                }
            });
            actionButtons.forEach(buttons => {
                buttons.style.display = 'none';
            });
            const row = checkbox.closest('tr');
            const actionButtonsRow = row.querySelector('.btn_acoes');
            actionButtonsRow.style.display = 'inline-flex';
        }
    });
});

/*const popularClientes = () => {
    const clientes = JSON.parse(localStorage.getItem('db_RcClient')) || [];
    const selectCliente = document.getElementById('nome');
    selectCliente.innerHTML = '<option value="">Selecione o cliente</option>';
    clientes.forEach(cliente => {
        const option = document.createElement('option');
        option.value = cliente.nome;
        option.textContent = cliente.nome;
        selectCliente.appendChild(option);
    });
}

const popularTecnicos = () => {
    const tecnicos = JSON.parse(localStorage.getItem('db_rcarcondicionado')) || [];
    const selectTecnico = document.getElementById('nomeTecnico');
    selectTecnico.innerHTML = '<option value="">Selecione o técnico</option>';
    tecnicos.forEach(tecnico => {
        const option = document.createElement('option');
        option.value = tecnico.nome;
        option.textContent = tecnico.nome;
        selectTecnico.appendChild(option);
    });
}*/

const popularIdsAgendamentos = () => {
    const agendamentos = JSON.parse(localStorage.getItem('db_rcAgenda')) || [];
    const selectIdAgendamento = document.getElementById('idAgendamento');
    selectIdAgendamento.innerHTML = '<option value="">Selecione o ID do agendamento</option>';
    agendamentos.forEach(agendamento => {
        const option = document.createElement('option');
        option.value = agendamento.numId;
        option.textContent = agendamento.numId;
        selectIdAgendamento.appendChild(option);
    });
}

const preencherDadosAgendamento = () => {
    const idAgendamentoSelecionado = document.getElementById('idAgendamento').value;
    const agendamentos = JSON.parse(localStorage.getItem('db_rcAgenda')) || [];
    const agendamentoSelecionado = agendamentos.find(agendamento => agendamento.numId === idAgendamentoSelecionado);
    if (agendamentoSelecionado) {
        document.getElementById('nome').value = agendamentoSelecionado.nomeCliente; // Corrigido para 'nomeCliente'
        document.getElementById('nomeTecnico').value = agendamentoSelecionado.nomeTecnico;
    } else {
        document.getElementById('nome').value = '';
        document.getElementById('nomeTecnico').value = '';
    }
}

document.getElementById('idAgendamento').addEventListener('change', preencherDadosAgendamento);
popularIdsAgendamentos();







//IMPRESSÃO
//IMPRESSÃO
function gerarPDF() {
	const registros = JSON.parse(localStorage.getItem('db_local')) || [];

	//mapeamento doq queremos q tenha no rel
    const dados = registros.map(servico => ({
        nome: servico.nome,
        tipoServico: servico.tipoServico,
        descricao: servico.descricao,
        preco: servico.preco,
        nomeTecnico: servico.nomeTecnico
    }));
	//const logo = 'img/rc.png';
	const conteudoPDF = {
    content: [
        //{ image: logo, width: 200, alignment: 'center' }, 
        { text: 'RC REFRIGERAÇÃO E AR-CONDICIONADO', style: 'topStyle', alignment: 'center' },
        { text: 'Registro de Serviços', style: 'header', alignment: 'center', decoration: 'underline' },
        {
            table: {
                headerRows: 1,
                widths: ['auto', 'auto', '*', 'auto', 'auto'],
                body: [
                    [
                        { text: 'Cliente', style: 'tableHeader', alignment: 'center' }, 
                        { text: 'Tipo de Serviço', style: 'tableHeader', alignment: 'center' }, 
                        { text: 'Descrição do Serviço', style: 'tableHeader', alignment: 'center' }, 
                        { text: 'Valor do Serviço', style: 'tableHeader', alignment: 'center' }, 
                        { text: 'Técnico', style: 'tableHeader', alignment: 'center' }
                    ],
                    ...dados.map(registro => [registro.nome, registro.tipoServico, registro.descricao, registro.preco, registro.nomeTecnico])
                ]
            }
        },
        {
        columns: [
            [
                { text: 'Endereço: ', bold: true }, 'Rua onde Judas perdeu as botas, 12 - bairro legal, SP\n',
                { text: 'Telefone: ', bold: true }, '(11) 9 91111-1111\n',
                { text: 'Email: ', bold: true }, 'emaildeles@gmail.com\n'
            ]
        ],
			margin: [20, 480, 0, 0]
        }
    ],
    styles: {
        header: {
            fontSize: 16,
            italics: true,
            margin: [0, 0, 0, 30]
        },
        topStyle: {
            fontSize: 18,
            bold: true,
            margin: [0, 0, 0, 20]
        },
        tableHeader: {
            bold: true,
            fillColor: '#b0b6c3'
        }
    }
};


    pdfMake.createPdf(conteudoPDF).download('registro_servicos.pdf');
}

const botaoImprimir = document.getElementById('botao-imprimir');
botaoImprimir.addEventListener('click', gerarPDF);

/*
//converter a img pra url pq esse ngç é chato
function toDataURL(url, callback) {
    var xhr = new XMLHttpRequest();
    xhr.onload = function () {
        var reader = new FileReader();
        reader.onloadend = function () {
            callback(reader.result);
        };
        reader.readAsDataURL(xhr.response);
    };
    xhr.open('GET', url);
    xhr.responseType = 'blob';
    xhr.send();
}*/
