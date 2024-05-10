//Tabela


//Abrir formulario 
const openForm = () => {
  document.getElementById('cadastro-form-tecnico')
    .classList.add('active');
}

const closeForm = () => {
  document.getElementById('cadastro-form-tecnico')
    .classList.remove('active');
}

//FUNÇÕES
function gerarNumeroUnico() {
  let numero = Math.floor(Math.random() * 1000);
  return numero.toString().padStart(4, '0');
}


// Função para validar CPF e formatar
function validarCPF(cpf) {
  // Remove caracteres não numéricos
  cpf = cpf.replace(/\D/g, '');

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

// Função para validar CPF ou CNPJ e formatar
function validarDocumento(numeroString) {
  // Remove caracteres não numéricos e converte para número
  let numero = parseInt(numeroString.replace(/\D/g, ''));

  // Verifica o número de dígitos
  if (isNaN(numero) || numeroString.length !== 11 && numeroString.length !== 14) {
    // Se o número não puder ser convertido para um número válido ou não tiver o tamanho adequado, retorna falso
    return alert("Número de documento inválido.");

  } else if (numeroString.length === 11) {
    // Se tiver 11 dígitos, chama a função para validar CPF
    return validarCPF(numero.toString());
  } else {
    // Se tiver 14 dígitos, chama a função para validar CNPJ
    return validarCNPJ(numero.toString());
  }
}

function formatarTelefone(telefone) {
  // Remove todos os caracteres não numéricos
  telefone = telefone.replace(/\D/g, '');

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
    if (field.id == "cep" || field.id == "numero" || field.id == "complemento") {  // se n for cep, num ou comp vai ser desabilitado
      field.disabled = !enabled;
    }
    else {
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


//CRUD tecnico

const getLocalStorage = () => JSON.parse(localStorage.getItem('db_rcarcondicionado')) ?? []
const setLocalStorage = (dbRcarcondicionado) => localStorage.setItem("db_rcarcondicionado", JSON.stringify(dbRcarcondicionado))

const createTecnico = (tecnico) => {
  const dbRcarcondicionado = getLocalStorage()
  dbRcarcondicionado.push(tecnico)
  setLocalStorage(dbRcarcondicionado);
}

const readTecnico = () => getLocalStorage()

const updateTecnico = (index, tecnico) => {
  const dbRcarcondicionado = readTecnico()
  dbRcarcondicionado[index] = tecnico
  setLocalStorage(dbRcarcondicionado)
}

const deleteTecnico = (index) => {
  const dbRcarcondicionado = readTecnico()
  dbRcarcondicionado.splice(index, 1)
  setLocalStorage(dbRcarcondicionado)
}

const isValidFields = () => {
  return document.getElementById('form').reportValidity()
}

//Interação com formulario
const refreshTable = () => {
  ordenarNomes()
  updateTable()
  const input = document.querySelector('.campo_pesquisa')
  input.value = ""
}

const ordenarNomes = () => {
  const dbRcarcondicionado = readTecnico()
  dbRcarcondicionado.sort(function (a, b) {
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

const saveTecnico = () => {
  if (isValidFields()) {
    const tecnico = {
      numId: gerarNumeroUnico(),
      nome: document.getElementById('nome').value,
      cpf: validarDocumento(document.getElementById('cpf').value),
      telefone1: formatarTelefone(document.getElementById('tel1').value),
      telefone2: formatarTelefone(document.getElementById('tel2').value),
      email: document.getElementById('email').value,
      rua: document.getElementById('rua').value,
      cep: document.getElementById('cep').value,
      numero: document.getElementById('numero').value,
      bairro: document.getElementById('bairro').value,
      cidade: document.getElementById('cidade').value,
      estado: document.getElementById('estado').value,
      complemento: document.getElementById('complemento').value
    }

    const index = document.getElementById('nome').dataset.index
    if (index == 'new') {
      createTecnico(tecnico);
      ordenarNomes();
      updateTable();
      clearFields();
      clearCepForm();
      closeForm();

    } else {
      updateTecnico(index, tecnico);
      ordenarNomes();
      updateTable();
      closeForm();
    }
  }
}

const createRow = (tecnico, index) => {
  const newRow = document.createElement('tr')
  newRow.innerHTML = `
    <td><input type="checkbox" id="id-${index}" class="checkbox-item" /></td>  
    <td>${tecnico.numId}</td>
    <td>${tecnico.nome}</td>
    <td>${tecnico.cpf}</td>
    <td>${tecnico.telefone1}<br>${tecnico.telefone2}</td>
    <td>${tecnico.email}</td>
    <td><div class="btn_crud btn_acoes" ><button id="edit-${index}" class="btn_crud btn_altera" type="button" data-action="edit"></button>
    <button id="delete-${index}" class="btn_crud btn_exclui" type="button" data-action="delete"></button></div></td>
  `
  document.querySelector('#tb_tecnico>tbody').appendChild(newRow)
}

const clearTable = () => {
  const rows = document.querySelectorAll('#tb_tecnico>tbody tr')
  rows.forEach(row => row.parentNode.removeChild(row))
}

const clearModal = () => {
  clearFields();
  document.getElementById('nome').value = '' 
  document.getElementById('cpf').value = '' 
  document.getElementById('tel1').value = '' 
  document.getElementById('tel2').value = '' 
  document.getElementById('email').value = '' 
  document.getElementById('cep').value = '' 
  document.getElementById('rua').value = '' 
  document.getElementById('numero').value = '' 
  document.getElementById('bairro').value = '' 
  document.getElementById('cidade').value = '' 
  document.getElementById('estado').value = '' 
  document.getElementById('complemento').value = '' 
}

const fillFields = (tecnico) => {
  document.getElementById('nome').value = tecnico.nome
  document.getElementById('cpf').value = tecnico.cpf
  document.getElementById('tel1').value = tecnico.telefone1
  document.getElementById('tel2').value = tecnico.telefone2
  document.getElementById('email').value = tecnico.email
  document.getElementById('cep').value = tecnico.cep
  document.getElementById('rua').value = tecnico.rua
  document.getElementById('numero').value = tecnico.numero
  document.getElementById('bairro').value = tecnico.bairro
  document.getElementById('cidade').value = tecnico.cidade
  document.getElementById('estado').value = tecnico.estado
  document.getElementById('complemento').value = tecnico.complemento
  document.getElementById('nome').dataset.index = tecnico.index

  openForm()
}

const editTecnico = (index) => {
  const tecnico = readTecnico()[index]
  tecnico.index = index
  fillFields(tecnico)
  openForm()

}

const editDelete = (event) => {
  if (event.target.type == 'button') {
    const [action, index] = event.target.id.split('-')

    if (action == 'edit') {
      editTecnico(index)
    } else {
      const tecnico = readTecnico()[index]
      const response = confirm(`Deseja realmente excluir o registro de ${tecnico.nome}`)
      if (response) {
        deleteTecnico(index)
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
  const dbRcarcondicionado = readTecnico();
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
  if (searchTerm !== "") {
    const dbRcarcondicionado = readTecnico();
    const filteredList = dbRcarcondicionado.filter(tecnico => {
      return tecnico.nome.toLowerCase().includes(searchTerm);
    });

    clearTable();
    filteredList.forEach(createRow);
  } else return;
};

//Eventos
document.getElementById('cadastrarTecnico')
  .addEventListener('click', saveTecnico)

document.querySelector('#tb_tecnico>tbody')
  .addEventListener('click', editDelete)

document.getElementById('close-cadastro-form')
  .addEventListener('click', closeForm)

document.getElementById('open-cadastro-form')
  .addEventListener('click', openForm)

document.getElementById('btn_refresh')
  .addEventListener('click', refreshTable)

document.getElementById('btn_search').addEventListener('click', (event) => {
  event.preventDefault();
  searchByName();
});

document.getElementById('limparForm')
  .addEventListener('click', clearFields)

document.getElementById('limparForm')
  .addEventListener('click', clearCepForm)
