const getLocalStorageTecnico = () => JSON.parse(localStorage.getItem('db_rcarcondicionado')) ?? []
const setLocalStorageTecnico = (dbRcarcondicionado) => localStorage.setItem("db_rcarcondicionado", JSON.stringify(dbRcarcondicionado))

const getLocalStorageCliente = () => JSON.parse(localStorage.getItem('db_RcClient')) ?? []
const setLocalStorageCliente = (dbRcarcondicionado) => localStorage.setItem("db_RcClient", JSON.stringify(db_RcClient))

const getLocalStorageServico = () => JSON.parse(localStorage.getItem('db_rcServico')) ?? []
const setLocalStorageServico = (dbRcarcondicionado) => localStorage.setItem("db_rcServico", JSON.stringify(db_rcServico))


const readTecnico = () => getLocalStorageTecnico()
const readCliente = () => getLocalStorageCliente()
const readServico = () => getLocalStorageServico()

const db_RcClient = readCliente();
const db_rcarcondicionado = readTecnico()
const db_rcServico = readServico()




//Abrir formulario 
const openForm = () => {
  document.getElementById('cadastro-form-agendamento')
  .classList.add('active');
  preencherGradeDias(new Date().getMonth(), new Date().getFullYear());
  preencherListaClientes();
  preencherListaTecnicos(); 
}

const closeForm = () => {
  document.getElementById('cadastro-form-agendamento')
  .classList.remove('active');
}

//FUNÇÕES
function gerarNumeroUnico() {
  let numero = Math.floor(Math.random()*1000);
  return numero.toString().padStart(4, '0');
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

function preencherGradeDias(mes, ano) {
  const diasNoMes = new Date(ano, mes + 1, 0).getDate();
  const primeiroDiaSemana = new Date(ano, mes, 1).getDay();
  const gradeDias = document.getElementById('grade-dias');
  gradeDias.innerHTML = '';

  for (let i = 0; i < primeiroDiaSemana; i++) {
    const diaVazio = document.createElement('div');
    diaVazio.textContent = '';
    gradeDias.appendChild(diaVazio);
  }

  for (let i = 1; i <= diasNoMes; i++) {
    const dia = document.createElement('div');
    dia.textContent = i;
    gradeDias.appendChild(dia);
  }
}

function preencherSeletorMes() {
  const seletorMes = document.getElementById('mes');
  const meses = [
    "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
    "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
  ];

  meses.forEach((mes, index) => {
    const option = document.createElement('option');
    option.value = index;
    option.textContent = mes;
    seletorMes.appendChild(option);
  });
}

function preencherSeletorAno() {
  const seletorAno = document.getElementById('ano');
  const anoAtual = new Date().getFullYear();
  const anos = [];

  for (let i = anoAtual - 10; i <= anoAtual + 10; i++) {
    anos.push(i);
  }

  anos.forEach(ano => {
    const option = document.createElement('option');
    option.value = ano;
    option.textContent = ano;
    seletorAno.appendChild(option);
  });
}

document.getElementById('mes').addEventListener('change', () => {
  const mesSelecionado = parseInt(document.getElementById('mes').value);
  const anoSelecionado = parseInt(document.getElementById('ano').value);
  preencherGradeDias(mesSelecionado, anoSelecionado);
});

document.getElementById('ano').addEventListener('change', () => {
  const mesSelecionado = parseInt(document.getElementById('mes').value);
  const anoSelecionado = parseInt(document.getElementById('ano').value);
  preencherGradeDias(mesSelecionado, anoSelecionado);
});

preencherSeletorMes();
preencherSeletorAno();

const mesAtual = new Date().getMonth();
const anoAtual = new Date().getFullYear();
preencherGradeDias(mesAtual, anoAtual);


//PESQUISA CLIENTES E TECNICOS
function criarItemCliente(cliente) {
  const itemCliente = document.createElement('li');
  itemCliente.textContent = cliente.nome + " " + cliente.sobrenome;
  itemCliente.addEventListener('click', () => {
    document.getElementById('cliente').value = cliente.nome;
  });
  return itemCliente;
}

function preencherListaClientes() {
  const clientes = readCliente();
  const listaClientes = document.getElementById('lista-clientes');
  listaClientes.innerHTML = '';

  clientes.forEach(cliente => {
    const itemCliente = criarItemCliente(cliente);
    listaClientes.appendChild(itemCliente);
  });
}

function criarItemTecnico(tecnico) {
  const itemTecnico = document.createElement('li');
  itemTecnico.textContent = tecnico.nome + " " + tecnico.sobrenome;
  itemTecnico.addEventListener('click', () => {
    document.getElementById('tecnico').value = tecnico.nome;
  });
  return itemTecnico;
}

function preencherListaTecnicos() {
  const tecnicos = readTecnico();
  const listaTecnicos = document.getElementById('lista-tecnicos');
  listaTecnicos.innerHTML = '';

  tecnicos.forEach(tecnico => {
    const itemTecnico = criarItemTecnico(tecnico);
    listaTecnicos.appendChild(itemTecnico);
  });
}

//Pesquisa Cliente e Técnico
function pesquisarCliente(termo) {
  if (termo.trim() === '') {
    // Se o campo estiver vazio, exibe todas as opções de cliente
    preencherListaClientes();
  } else {
    // Caso contrário, realiza a pesquisa na base de dados com o termo fornecido
    const resultados = db_RcClient.filter(cliente => cliente.nome.toLowerCase().includes(termo.toLowerCase()));
    preencherListaClientes(resultados);
  }
}

function pesquisarTecnico(termo) {
  if (termo.trim() === '') {
    // Se o campo estiver vazio, exibe todas as opções de técnico
    preencherListaTecnicos();
  } else {
    // Caso contrário, realiza a pesquisa na base de dados com o termo fornecido
    const resultados = db_rcarcondicionado.filter(tecnico => tecnico.nome.toLowerCase().includes(termo.toLowerCase()));
    preencherListaTecnicos(resultados);
  }
}



//CRUD tecnico



/*

const createTecnico = (tecnico) => {
  const dbRcarcondicionado = getLocalStorage()
  dbRcarcondicionado.push (tecnico)
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
}

const ordenarNomes = () => {
  const dbRcarcondicionado = readTecnico()
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

const geradorId = (index) => {
  var numId = 0
  numId = index + 1
  return numId
}

const saveTecnico = () => {
  if (isValidFields()){
    const tecnico = {
      numId: gerarNumeroUnico(),
      nome: document.getElementById('nome').value,
      sobrenome: document.getElementById('sobrenome').value,
      cpf: validarDocumento(document.getElementById('cpf').value),
      telefone1: formatarTelefone( document.getElementById('tel1').value),
      telefone2: formatarTelefone(document.getElementById('tel2').value),
      email: document.getElementById('email').value
    }
    const index = document.getElementById('nome').dataset.index
    if (index == 'new'){
      createTecnico(tecnico)
      ordenarNomes()
      updateTable()
      clearFields()
      closeForm()

    } else{
      updateTecnico(index, tecnico)
      ordenarNomes()
      updateTable()
      closeForm()
    
    }
  }
}

const createRow = (tecnico, index) => {
  const newRow = document.createElement('tr')
  newRow.innerHTML = `
    <td><input type="checkbox" id="id-${index}" class="checkbox-item" /></td>  
    <td>${tecnico.numId}</td>
    <td>${tecnico.nome} ${tecnico.sobrenome}</td>
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

const fillFields = (tecnico) => {
  document.getElementById('nome').value = tecnico.nome
  document.getElementById('sobrenome').value = tecnico.sobrenome
  document.getElementById('cpf').value = tecnico.cpf
  document.getElementById('tel1').value = tecnico.telefone1
  document.getElementById('tel2').value = tecnico.telefone2
  document.getElementById('email').value = tecnico.email
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
  if (event.target.type == 'button'){
    const [action, index] = event.target.id.split('-')
    
    if (action == 'edit'){
      editTecnico(index)
    } else {
      const tecnico = readTecnico()[index]  
      const response = confirm (`Deseja realmente excluir o registro de ${tecnico.nome}`)
      if (response){ 
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
  const actionButtons = document.querySelectorAll('.btn_acoes');
  for (const button of actionButtons) {
    button.style.display = isAnyCheckboxSelected() ? 'inline-flex' : 'none';
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
  if (searchTerm !== ""){
    const dbRcarcondicionado = readTecnico();
    const filteredList = dbRcarcondicionado.filter(tecnico => {
    return tecnico.nome.toLowerCase().includes(searchTerm);
  });
   
    clearTable(); 
    filteredList.forEach(createRow);
  } else return;
};
*/

//Eventos
document.getElementById('close-cadastro-form')
  .addEventListener('click', closeForm)

document.getElementById('open-cadastro-form')
  .addEventListener('click', openForm)

/*document.getElementById('cadastrarAgendamento')
  .addEventListener('click', saveAgendamento)

document.querySelector('#tb_tecnico>tbody')
  .addEventListener('click', editDelete)
  
document.getElementById('btn_refresh')
  .addEventListener('click', refreshTable)

document.getElementById('btn_search').addEventListener('click', (event) => {
  event.preventDefault();
  searchByName(); 
});
*/


