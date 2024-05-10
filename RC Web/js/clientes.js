//Abrir formulario 
const openForm = () => {
  document.getElementById('cadastro-form-cliente')
  .classList.add('active');
}

const closeForm = () => {
  document.getElementById('cadastro-form-cliente')
  .classList.remove('active');
  clearFields()
  clearCepForm()
}

//FUNÇÕES
function gerarNumeroUnico() {
  let numero = Math.floor(Math.random()*1000);
  return numero.toString().padStart(4, '0');
}


// Função para validar CPF e formatar
function validarCPF(cpf) {
    // Remove caracteres não numéricos
    cpf = cpf.replace(/\D/g,'');

    if (!cpf || typeof cpf !== 'string' || cpf.length !== 11) return { valido: false, numero: cpf }; // Verifica se o CPF tem 11 dígitos

    // Verifica se todos os caracteres são iguais
    if (/^(\d)\1{10}$/.test(cpf)) return { valido: false, numero: cpf };

    // Calcula o primeiro dígito verificador
    let soma = 0;
    for (let i = 0; i < 9; i++) soma += parseInt(cpf.charAt(i)) * (10 - i);
    let resto = soma % 11;
    let digitoVerificador1 = resto < 2 ? 0 : 11 - resto;

    // Verifica o primeiro dígito verificador
    if (parseInt(cpf.charAt(9)) !== digitoVerificador1) return { valido: false, numero: cpf };

    // Calcula o segundo dígito verificador
    soma = 0;
    for (let i = 0; i < 10; i++) soma += parseInt(cpf.charAt(i)) * (11 - i);
    resto = soma % 11;
    let digitoVerificador2 = resto < 2 ? 0 : 11 - resto;

    // Verifica o segundo dígito verificador
    if (parseInt(cpf.charAt(10)) !== digitoVerificador2) return { valido: false, numero: cpf };

    // Retorna o CPF formatado
    let cpfFormatado = cpf.replace(/(\d{3})(\d{3})(\d{3})(\d{2})/, '$1.$2.$3-$4');
    return cpfFormatado;
}

// Função para validar CNPJ e formatar
function validarCNPJ(cnpj) {
    // Remove caracteres não numéricos
    cnpj = cnpj.replace(/\D/g,'');

    if (!cnpj || typeof cnpj !== 'string' || cnpj.length !== 14) 
      return alert("CPF/CNPJ inválido. Tente novamente!"); // Verifica se o CNPJ tem 14 dígitos}

    // Verifica se todos os caracteres são iguais
    else if (/^(\d)\1{13}$/.test(cnpj)) 
      return alert("CPF/CNPJ inválido. Tente novamente!");

    // Calcula o primeiro dígito verificador
    let tamanho = cnpj.length - 2;
    let numeros = cnpj.substring(0, tamanho);
    let digitos = cnpj.substring(tamanho);
    let soma = 0;
    let pos = tamanho - 7;
    for (let i = tamanho; i >= 1; i--) {
        soma += parseInt(numeros.charAt(tamanho - i)) * pos--;
        if (pos < 2) pos = 9;
    }
    let digitoVerificador1 = soma % 11 < 2 ? 0 : 11 - (soma % 11);

    // Verifica o primeiro dígito verificador
    if (parseInt(digitos.charAt(0)) !== digitoVerificador1) return { valido: false, numero: cnpj };

    // Calcula o segundo dígito verificador
    tamanho = tamanho + 1;
    numeros = cnpj.substring(0, tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (let i = tamanho; i >= 1; i--) {
        soma += parseInt(numeros.charAt(tamanho - i)) * pos--;
        if (pos < 2) pos = 9;
    }
    let digitoVerificador2 = soma % 11 < 2 ? 0 : 11 - (soma % 11);

    // Verifica o segundo dígito verificador
    if (parseInt(digitos.charAt(1)) !== digitoVerificador2) return { valido: false, numero: cnpj };

    // Retorna o CNPJ formatado
    let cnpjFormatado = cnpj.replace(/(\d{2})(\d{3})(\d{3})(\d{4})(\d{2})/, '$1.$2.$3/$4-$5');
    return cnpjFormatado;
}

// Função para validar CPF ou CNPJ e formatar
function validarDocumento(numeroString) {
    // Remove caracteres não numéricos e converte para número
    const numero = parseInt(numeroString.replace(/\D/g, ''));

    // Verifica o número de dígitos
    if (isNaN(numero) || numeroString.length !== 11 && numeroString.length !== 14) {
        // Se o número não puder ser convertido para um número válido ou não tiver o tamanho adequado, retorna false
        return alert("CPF/CNPJ inválido. Tente novamente!") /*{ valido: false, numero: numeroString };*/
    } else if (numeroString.length === 11) {
        // Se tiver 11 dígitos, chama a função para validar CPF
        return { valido: true, numero: validarCPF(numero.toString()) };
    } else {
        // Se tiver 14 dígitos, chama a função para validar CNPJ
        return { valido: true, numero: validarCNPJ(numero.toString()) };
    }
}

function formatarTelefone(telefone) {
    // Remove todos os caracteres não numéricos
    telefone = telefone.replace(/\D/g,'');

    // Verifica se o número de telefone é válido (deve ter 10 ou 11 dígitos)
    if (telefone.length === 10) {
        // Formata o número de telefone para (XX) XXXX-XXXX
        return '(' + telefone.substring(0, 2) + ') ' + telefone.substring(2, 6) + '-' + telefone.substring(6, 10);
    } else if (telefone.length === 11) {
        // Formata o número de telefone para (XX) XXXXX-XXXX
        return '(' + telefone.substring(0, 2) + ') ' + telefone.substring(2, 7) + '-' + telefone.substring(7, 11);
    } else {
        // Retorna o número de telefone original se não for válido
        return telefone;
    }
}

// AutoComplete CEP

const cepInput = document.querySelector("#cep");
const ruaInput = document.querySelector("#rua");
const cidadeInput = document.querySelector("#cidade");
const bairroInput = document.querySelector("#bairro");
const estadoInput = document.querySelector("#estado");
const numeroInput = document.querySelector("#numero");
const complementoInput = document.querySelector("#complemento");

// Evento para pegar o CEP
cepInput.addEventListener("keyup", (event) => {
  const inputValue = event.target.value;

  // Checar o tamanho do CEP
  if (inputValue.length === 8) {
    getAddress(inputValue);
  }
});

// Pegar o endereço na API
const getAddress = async (cep) => {
  cepInput.blur();

  const apiUrl = `https://viacep.com.br/ws/${cep}/json/`;

  try {
    const response = await fetch(apiUrl);
    const data = await response.json();

    // Verificar se o CEP é válido
    if (!data.erro) {
      fillAddressFields(data);
      toggleAddressFields(true); // Habilitar campos relacionados ao endereço
    } else {
      alert("CEP não encontrado. Por favor, verifique o CEP digitado.");
    }
  } catch (error) {
    console.error("Ocorreu um erro ao buscar o endereço:", error);
  }
};

// Preencher os campos relacionados ao endereço com os dados do CEP
const fillAddressFields = (data) => {
  cepInput.value = data.cep || "";
  ruaInput.value = data.logradouro || "";
  cidadeInput.value = data.localidade || "";
  bairroInput.value = data.bairro || "";
  estadoInput.value = data.uf || "";
};

// Alternar a habilitação dos campos relacionados ao endereço
const toggleAddressFields = (enabled) => {
  const addressFields = document.querySelectorAll(".cep-form-field");
  addressFields.forEach((field) => {
    if(field.id == "cep" || field.id == "numero" || field.id == "complemento"){  // se n for cep, num ou comp vai ser desabilitado
		field.disabled = !enabled;
	}
	else{
	field.disabled = enabled;
	}
  });
};

// Evento para pegar o CEP
numeroInput.addEventListener("keyup", (event) => {
  const inputValue = event.target.value;

  // Checar o tamanho do número
  if (inputValue.length > 0) {
    toggleAddressFields(true);
  }
});


//CRUD cliente

const getLocalStorage = () => JSON.parse(localStorage.getItem('db_RcClient')) ?? []
const setLocalStorage = (dbRcarcondicionado) => localStorage.setItem("db_RcClient", JSON.stringify(dbRcarcondicionado))

const createCliente = (cliente) => {
  const dbRcarcondicionado = getLocalStorage()
  dbRcarcondicionado.push (cliente)
  setLocalStorage(dbRcarcondicionado);
}

const readCliente = () => getLocalStorage()

const updateCliente = (index, cliente) => {
  const dbRcarcondicionado = readCliente()
  dbRcarcondicionado[index] = cliente
  setLocalStorage(dbRcarcondicionado)
}

const deleteCliente = (index) => {
  const dbRcarcondicionado = readCliente()
  dbRcarcondicionado.splice(index,1)
  setLocalStorage(dbRcarcondicionado)
}

const isValidFields = () => {
  return document.getElementById ('form').reportValidity()
}

//Interação com formulario
const refreshTable = () => {
  ordenarNomes()
  updateTable()
  const input = document.querySelector('.campo_pesquisa')
  input.value = ""
  pessoaFisicaFilter.checked = false;
  pessoaJuridicaFilter.checked = false;
}

const ordenarNomes = () => {
  const dbRcarcondicionado = readCliente()
  dbRcarcondicionado.sort(function(a,b) {
    if (a.nome < b.nome) {
      return -1;
    } else if (a.nome > b.nome) {
      return 1;
    } else {
      return 0;
    }
  });
    setLocalStorage(dbRcarcondicionado);
}

const clearFields = () => {
  const fields = document.querySelectorAll('.form-field')
  fields.forEach(field => field.value = "")
}
const clearCepForm = () => {
  const fields = document.querySelectorAll('.cep-form-field')
  fields.forEach(field => field.value = "")
}

const geradorId = (index) => {
  var numId = 0
  numId = index + 1
  return numId
}

const saveCliente = () => {
    if (isValidFields()) {
        const cliente = {
            numId: gerarNumeroUnico(),
            nome: document.getElementById('nome').value.trim(),
            nome_repres: document.getElementById('nome_repres').value.trim(),
            cpf: validarDocumento(document.getElementById('cpf').value).numero,
            telefone1: formatarTelefone(document.getElementById('tel1').value),
            telefone2: formatarTelefone(document.getElementById('tel2').value),
            email: document.getElementById('email').value.trim(),
            rua: document.getElementById('rua').value,
            cep: document.getElementById('cep').value,
            numero: document.getElementById('numero').value,
            bairro: document.getElementById('bairro').value,
            cidade: document.getElementById('cidade').value,
            estado: document.getElementById('estado').value,
            complemento: document.getElementById('complemento').value
        };
        const index = document.getElementById('nome').dataset.index;
        if (index == 'new') {
            createCliente(cliente);
            ordenarNomes();
            updateTable();
            clearFields();
            clearCepForm();
            closeForm();
        } else {
            updateCliente(index, cliente);
            ordenarNomes();
            updateTable();
            closeForm();
        }
    }
};

const createRow = (cliente, index) => {
  const newRow = document.createElement('tr')
  newRow.innerHTML = `
    <td><input type="checkbox" id="id-${index}" class="checkbox-item" /></td>  
    <td>${cliente.numId}</td>
    <td>${cliente.nome}</td>
    <td>${cliente.email}</td>
    <td>${cliente.cpf}</td>
    <td>${cliente.telefone1}<br>${cliente.telefone2}</td>
    <td>${cliente.rua}, ${cliente.numero} ${cliente.bairro}, ${cliente.cidade}-${cliente.estado} ${cliente.complemento} ${cliente.cep}</td>

    <td><div class="btn_crud btn_acoes" >
    <button id="edit-${index}" class="btn_crud btn_altera" type="button" data-action="edit"></button>
    <button id="agenda-${index}" class="btn_crud btn_agenda" type="button"</button>
    <button id="delete-${index}" class="btn_crud btn_exclui" type="button" data-action="delete"></button></div></td>
  `
  document.querySelector('#tb_cliente>tbody').appendChild(newRow)
}

const clearTable = () => {
  const rows = document.querySelectorAll('#tb_cliente>tbody tr')
  rows.forEach(row => row.parentNode.removeChild(row))
}

const fillFields = (cliente) => {
  document.getElementById('nome').value = cliente.nome
  document.getElementById('cpf').value = cliente.cpf
  document.getElementById('tel1').value = cliente.telefone1
  document.getElementById('tel2').value = cliente.telefone2
  document.getElementById('email').value = cliente.email
  document.getElementById('cep').value = cliente.cep
  document.getElementById('rua').value = cliente.rua
  document.getElementById('numero').value = cliente.numero
  document.getElementById('bairro').value = cliente.bairro
  document.getElementById('cidade').value = cliente.cidade
  document.getElementById('estado').value = cliente.estado
  document.getElementById('complemento').value = cliente.complemento
  document.getElementById('nome').dataset.index = cliente.index
  openForm()
}

const editCliente = (index) => {
  const cliente = readCliente()[index]
  cliente.index = index
  fillFields(cliente)
  openForm()
}
const agendaCliente = (index) => {
  const cliente = readCliente()[index]
  window.location.href = "http://127.0.0.1:5500/agendamento.html"
  
}

const editDelete = (event) => {
  if (event.target.type == 'button'){
    const [action, index] = event.target.id.split('-')
    
    if (action == 'edit'){
      editCliente(index)
    } else if(action == 'agenda'){
      agendaCliente(index)
    } else {
      const cliente = readCliente()[index]  
      const response = confirm (`Deseja realmente excluir o registro de ${cliente.nome}`)
      if (response){ 
        deleteCliente(index)
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
  const dbRcarcondicionado = readCliente();
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
  const dbRcarcondicionado = readCliente();
  const filteredList = dbRcarcondicionado.filter(cliente => {
    return cliente.nome.toLowerCase().includes(searchTerm);
  });
  clearTable(); 
  filteredList.forEach(createRow); 
};

//alterar label de formulário para pessoa jurídica
const radioPj = document.getElementById('pessoaJuridica')
const radioPf = document.getElementById('pessoaFisica')
const labelNome = document.getElementById('nome_label')
const labelCPF = document.getElementById('cpf_label')
const labelRepres = document.getElementById('nome_repres_label')
const inputRepres = document.getElementById('nome_repres')
const telLabel2 = document.getElementById('tel2_label')



radioPj.addEventListener('click', () => {
    labelNome.innerText = 'Razao Social*'
    labelCPF.innerText = 'CNPJ*'
    labelRepres.classList.remove('hidden')
    inputRepres.classList.remove('hidden')
    telLabel2.innerText = 'Telefone Representante'
})

radioPf.addEventListener('click', () => {
    labelNome.innerText = 'Nome Completo*'
    labelCPF.innerText = 'CPF*'
    labelRepres.classList.add('hidden')
    inputRepres.classList.add('hidden')
    telLabel2.innerText = 'Telefone Pessoal'
})

//Eventos
document.getElementById('cadastrarCliente')
  .addEventListener('click', saveCliente)

document.querySelector('#tb_cliente>tbody')
  .addEventListener('click', editDelete)

document.getElementById('close-cadastro-form')
  .addEventListener('click', closeForm)

document.getElementById('open-cadastro-form')
  .addEventListener('click', openForm)
  
document.getElementById('btn_refresh')
  .addEventListener('click', refreshTable)

document.getElementById('limparForm')
  .addEventListener('click', clearFields)
  
document.getElementById('limparForm')
  .addEventListener('click', clearCepForm)

document.getElementById('btn_search').addEventListener('click', (event) => {
  event.preventDefault();
  searchByName(); 
});

//filtro de pf ou pj
const filterByPersonType = () => {
    const pessoaFisicaFilter = document.getElementById('pessoaFisicaFilter');
    const pessoaJuridicaFilter = document.getElementById('pessoaJuridicaFilter');
    const cpfInputs = document.querySelectorAll('#tb_cliente tbody tr');

    cpfInputs.forEach(row => {
        const cpf = row.querySelector('td:nth-child(5)').innerText;
		  const cpfSemFormatacao = cpf.replace(/\D/g, '');
		

        if(pessoaFisicaFilter.checked && cpfSemFormatacao.length == 11){
			row.style.display = '';
		}
		else if(pessoaJuridicaFilter.checked && cpfSemFormatacao.length == 14){
			row.style.display = '';
		}
		else if(!pessoaFisicaFilter.checked && !pessoaJuridicaFilter.checked) {
            row.style.display = ''; 
        }
		else{
            row.style.display = 'none';
        }
    })
};

document.querySelectorAll('input[type="checkbox"][name="tipo_pessoa"]').forEach(checkbox => {
    checkbox.addEventListener('click', () => {
        filterByPersonType();
    });
});


