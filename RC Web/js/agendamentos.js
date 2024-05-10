const getLocalStorageTecnico = () => JSON.parse(localStorage.getItem('db_rcarcondicionado')) ?? [];
const setLocalStorageTecnico = (db_rcarcondicionado) => localStorage.setItem("db_rcarcondicionado", JSON.stringify(db_rcarcondicionado));

const getLocalStorageCliente = () => JSON.parse(localStorage.getItem('db_RcClient')) ?? [];
const setLocalStorageCliente = (db_RcClient) => localStorage.setItem("db_RcClient", JSON.stringify(db_RcClient));

const getLocalStorageServico = () => { const data = localStorage.getItem('db_local'); return data ? JSON.parse(data) : []; };
const setLocalStorageServico = (dbrcServico) => localStorage.setItem("db_local", JSON.stringify(dbrcServico));

const readTecnico = () => getLocalStorageTecnico();
const readCliente = () => getLocalStorageCliente();
const readServico = () => getLocalStorageServico();

const db_RcClient = readCliente();
const db_rcarcondicionado = readTecnico();
const db_rcServico = readServico();

//Abrir formulario 
const openForm = () => {
  document.getElementById('cadastro-form-agendamento')
    .classList.add('active');
}

const closeForm = () => {
  document.getElementById('cadastro-form-agendamento')
    .classList.remove('active');
}

//FUNÇÕES
function gerarNumeroUnico() {
  let numero = Math.floor(Math.random() * 1000);
  return numero.toString().padStart(4, '0');
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

//PESQUISA CLIENTES E TECNICOS
const popularClientes = () => {
  const clientes = JSON.parse(localStorage.getItem('db_RcClient')) || [];
  const selectCliente = document.getElementById('nome');
  const inputClienteSelecionado = document.getElementById('nomeClienteSelecionado');

  selectCliente.innerHTML = '<option value="">Selecione o cliente</option>';

  clientes.forEach(cliente => {
    const option = document.createElement('option');
    option.value = cliente.nome + " " + cliente.sobrenome;
    option.textContent = cliente.nome + " " + cliente.sobrenome;
    selectCliente.appendChild(option);
  });

  // Adicionar evento de alteração ao <select>
  selectCliente.addEventListener('change', () => {
    const selectedOption = selectCliente.options[selectCliente.selectedIndex];

    if (selectedOption.value !== "") {
      // Se a opção selecionada não for vazia, definir o valor no input
      inputClienteSelecionado.value = selectedOption.value;
    } else {
      // Se a opção selecionada for vazia, limpar o input
      inputClienteSelecionado.value = "";
    }
  });
}

const popularTecnicos = () => {
  const tecnicos = JSON.parse(localStorage.getItem('db_rcarcondicionado')) || [];
  const selectTecnico = document.getElementById('nomeTecnico');
  const inputTecnicoSelecionado = document.getElementById('nomeTecnicoSelecionado');

  selectTecnico.innerHTML = '<option value="">Selecione o técnico</option>';

  tecnicos.forEach(tecnico => {
    const option = document.createElement('option');
    option.value = tecnico.nome + " " + tecnico.sobrenome;
    option.textContent = tecnico.nome + " " + tecnico.sobrenome;
    selectTecnico.appendChild(option);
  });

  // Adicionar evento de alteração ao <select>
  selectTecnico.addEventListener('change', () => {
    const selectedOption = selectTecnico.options[selectTecnico.selectedIndex];

    if (selectedOption.value !== "") {
      // Se a opção selecionada não for vazia, definir o valor no input
      inputTecnicoSelecionado.value = selectedOption.value;
    } else {
      // Se a opção selecionada for vazia, limpar o input
      inputTecnicoSelecionado.value = "";
    }
  });
}

// Função para preencher o seletor de anos
function preencherSeletorAno() {
  const seletorAno = document.getElementById('ano');
  const anoAtual = new Date().getFullYear();

  for (let ano = anoAtual; ano <= anoAtual + 10; ano++) {
    const option = document.createElement('option');
    option.value = ano;
    option.textContent = ano;
    seletorAno.appendChild(option);
  }
}

// Função para preencher o seletor de meses
function preencherSeletorMes() {
  const seletorMes = document.getElementById('mes');
  const meses = [
    "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
    "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"
  ];

  for (let mes = 0; mes < 12; mes++) {
    const option = document.createElement('option');
    option.value = mes + 1;
    option.textContent = meses[mes];
    seletorMes.appendChild(option);
  }
}

// Função para preencher o seletor de dias com seus respectivos dias da semana
function preencherSeletorDia() {
  const seletorDia = document.getElementById('dia');
  const mesSelecionado = parseInt(document.getElementById('mes').value);
  const anoSelecionado = parseInt(document.getElementById('ano').value);
  const diasNoMes = new Date(anoSelecionado, mesSelecionado + 1, 0).getDate(); // Último dia do mês selecionado
  const diasSemana = ["Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"];

  seletorDia.innerHTML = ''; // Limpa as opções anteriores

  for (let dia = 1; dia <= diasNoMes; dia++) {
    const data = new Date(anoSelecionado, mesSelecionado, dia);
    const diaSemana = data.getDay();
    const option = document.createElement('option');
    option.value = dia;
    option.textContent = `${dia} (${diasSemana[diaSemana]})`;
    seletorDia.appendChild(option);
  }
}
document.getElementById('mes').addEventListener('change', () => {
  preencherSeletorDia(); // Chama a função para preencher os dias ao mudar o mês
});

document.getElementById('ano').addEventListener('change', () => {
  preencherSeletorDia(); // Chama a função para preencher os dias ao mudar o ano
});

// Função para preencher o seletor de horários de 1 em 1 hora, de 8h até 17h
function preencherSeletorHorario() {
  const seletorHorario = document.getElementById('horario');

  for (let hora = 8; hora <= 17; hora++) {
    const option = document.createElement('option');
    option.value = hora;
    option.textContent = `${hora}:00`;
    seletorHorario.appendChild(option);
  }
}
// Chamando as funções para preencher os seletores
preencherSeletorAno();
preencherSeletorMes();
preencherSeletorDia();
preencherSeletorHorario();

//CRUD Agendamentos

const getLocalStorage = () => JSON.parse(localStorage.getItem('db_rcAgenda')) ?? []
const setLocalStorage = (dbAgenda) => localStorage.setItem("db_rcAgenda", JSON.stringify(dbAgenda))

const createAgendamento = (agendamento) => {
  const dbCliente = getLocalStorageCliente();
  if (dbCliente.length > 0) {
    const numId = dbCliente[0].numId;
    agendamento.numIdCliente = numId;

    const dbAgenda = getLocalStorage();
    dbAgenda.push(agendamento);
    setLocalStorage(dbAgenda);
    console.log("Agendamento criado com sucesso.");
  } else {
    console.log("Não há clientes cadastrados.");
  }
}


const readAgenda = () => getLocalStorage()

const updateAgendamento = (index, agendamento) => {
  const dbAgenda = readAgenda();
  dbAgenda[index] = agendamento;
  setLocalStorage(dbAgenda);
}

const deleteAgendamento = (index) => {
  const dbAgenda = readAgenda()
  dbAgenda.splice(index, 1);
  setLocalStorage(dbAgenda);
}

const isValidFields = () => {
  return document.getElementById('form').reportValidity();
}

const clearFields = () => {
  const fields = document.querySelectorAll('.form-field');
  fields.forEach(field => field.value = "");
}

const saveAgendamento = () => {
  console.log("botao agendamento")





  if (isValidFields()) {
    const agendamento = {
      numId: gerarNumeroUnico(),
      nomeTecnico: document.getElementById('nomeTecnicoSelecionado').value,
      nomeCliente: document.getElementById('nomeClienteSelecionado').value,
      dia: document.getElementById('dia').value,
      mes: document.getElementById('mes').value,
      ano: document.getElementById('ano').value,
      horario: document.getElementById('horario').value,
      status: document.getElementById('status').value,
    }

    document.getElementById('nomeClienteSelecionado').dataset.numId = agendamento.numId;

    const index = agendamento.numId;
    console.log('index:', index); // Verifica se o índice está correto


    const getAgendamentoByIndex = (index) => {
      let agendamento = readAgenda();
      return agendamento.find(agendamento => agendamento.numId === index);
    };

    const existingAgendamento = getAgendamentoByIndex(index);
    console.log(existingAgendamento)
    if (existingAgendamento) {
      console.log("update")
      updateAgendamento(index, agendamento);
    } else {
      console.log("criando agendamento")
      createAgendamento(agendamento);
      ordenarNomes();
    }

    clearFields();
    closeForm();
    updateTable();
  } else {
    console.error('Cliente não encontrado.');
  }
};

const createRow = (agendamento, index) => {
  const newRow = document.createElement('tr')
  newRow.innerHTML = `
    <td><input type="checkbox" id="id-${index}" class="checkbox-item"  /></td>  
    <td>${agendamento.numId}</td>
    <td>${agendamento.nomeCliente}</td>
    <td id="data">${agendamento.dia}/${agendamento.mes}/${agendamento.ano}</td>
    <td></td>
    <td>${agendamento.nomeTecnico}</td>
    <td>${agendamento.status}</td>

    <td><div class="btn_crud btn_acoes" ><button id="edit-${index}" class="btn_crud btn_altera" type="button" data-action="edit"></button>
    <button id="delete-${index}" class="btn_crud btn_exclui" type="button" data-action="delete"></button></div></td>
  `
  document.querySelector('#tb_agendamento>tbody').appendChild(newRow)
}

const clearTable = () => {
  const rows = document.querySelectorAll('#tb_agendamento>tbody tr')
  rows.forEach(row => row.parentNode.removeChild(row))
}

const fillFields = (agendamento) => {
  document.getElementById('nomeTecnicoSelecionado').value = agendamento.nomeTecnico;
  document.getElementById('nomeClienteSelecionado').value = agendamento.nomeCliente;
  document.getElementById('dia').value = agendamento.dia;
  document.getElementById('mes').value = agendamento.mes;
  document.getElementById('ano').value = agendamento.ano;
  document.getElementById('horario').value = agendamento.horario;
  // Preencha os outros campos do formulário aqui, conforme necessário

}

const editAgendamento = (index) => {
  const agendamento = readAgenda()[index];
  agendamento.index = index;
  fillFields(agendamento);
  openForm();
}

const editDelete = (event) => {
  if (event.target.type === 'button') {
    const [action, index] = event.target.id.split('-');

    if (action === 'edit') {
      editAgendamento(index);
    } else {
      const agendamento = readAgenda()[index];
      const response = confirm(`Deseja realmente excluir o agendamento de ${agendamento.nomeTecnico} para ${agendamento.nomeCliente}?`);
      if (response) {
        deleteAgendamento(index);
        updateTable();
      }
    }
  }
}

const ordenarNomes = () => {
  const dbAgenda = readAgenda()
  dbAgenda.sort(function (a, b) {
    if (a.nome < b.nome) {
      return -1;
    } else if (a.nome > b.nome) {
      return 1;
    } else {
      return 0;
    }
  });
  setLocalStorage(dbAgenda);
}

const refreshTable = () => {
  ordenarNomes()
  updateTable()
  const input = document.querySelector('.campo_pesquisa')
  input.value = ""
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
  const dbAgenda = readAgenda();
  clearTable();
  dbAgenda.forEach(createRow);
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
    const dbAgenda = readAgenda();
    const filteredList = dbAgenda.filter(agendamento => {
      return agendamento.nomeCliente.toLowerCase().includes(searchTerm);
    });

    clearTable();
    filteredList.forEach(createRow);
  } else return;
};



// Outras funções e eventos permanecem inalterados...

//Eventos
document.getElementById('close-cadastro-form')
  .addEventListener('click', closeForm)

document.getElementById('open-cadastro-form')
  .addEventListener('click', openForm)

document.getElementById('cadastrarAgendamento')
  .addEventListener('click', saveAgendamento)

document.querySelector('#tb_agendamento>tbody')
  .addEventListener('click', editDelete)

document.getElementById('btn_refresh')
  .addEventListener('click', refreshTable)

document.getElementById('btn_search').addEventListener('click', (event) => {
  event.preventDefault();
  searchByName();
});
