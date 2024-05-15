
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


// Função para preencher o seletor de anos
function preencherSeletorAno() {
  const seletorAno = document.getElementById('ano');
  const anoAtual = new Date().getFullYear();

  for (let ano = anoAtual; ano <= anoAtual + 10; ano++) {
    const option = document.createElement('option');
    option.name = "ano"
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
    option.name = "mes"
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
    option.name = "dia"
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
    option.name = "hora";
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
const submitForm = (page = null) => {
    if(page !== null)
    {
      document.getElementById('form').action = page
    }
    document.getElementById('form').submit()
}
// Tipo de operação a ser utlizada UPDATE/CREATE/DELETE
// e um valor para o caso especifico do SELECT
const setOperation = (op, value = true) => {
    document.getElementById('op').name = op
    document.getElementById('op').value = value
}
  
  // Define o código do cliente a ser UPDATE/DELETE
const setCodigo = (cod, id) => {
   document.getElementById(cod).value = id
}
const deleteAgendamento = (index) => {
    setOperation("DELETE");
    setCodigo('cod', index);
    fillFields(index);
    submitForm();
}

const isValidFields = () => {
  return document.getElementById('form').reportValidity();
}

const clearFields = () => {
  const fields = document.querySelectorAll('.form-field');
  fields.forEach(field => field.value = "");
}

const fillFields = (index) => {
  document.getElementById('nomeTecnicoSelecionado').value = document.querySelector(`#slc-${index} > td:nth-child(6)`).textContent;
  document.getElementById('nomeClienteSelecionado').value = document.querySelector(`#slc-${index} > td:nth-child(3)`).textContent;
  document.getElementById('enderecoClienteSelecionado').value = 
    document.getElementById(`cep-${index}`).textContent + ", " +
    document.getElementById(`uf-${index}`).textContent + ", " +
    document.getElementById(`cidade-${index}`).textContent + ", "+ 
    document.getElementById(`bairro-${index}`).textContent +", "+
    document.getElementById(`logra-${index}`).textContent+", "+
    document.getElementById(`end-nro-${index}`).textContent + ", "+
    document.getElementById(`end-cmplto-${index}`).textContent ;
    document.getElementById('status').value = document.getElementById(`status-${index}`).value
    const idCli = document.querySelector(`#slc-${index} > td:nth-child(3)`).id.split('-')[1];
    const idTec = document.querySelector(`#slc-${index} > td:nth-child(6)`).id.split('-')[1];
    setCodigo('codCli', idCli)
    setCodigo('codTec', idTec)
    document.getElementById(`cli-${idCli}`).selected = true;
    document.getElementById(`tec-${idTec}`).selected = true;
    // document.getElementById('nome').selectedIndex = idCli;
    // document.getElementById('nomeTecnico').selectedIndex = idTec;
  const dt_time = document.getElementById(`data-${index}`).textContent.split(' ');
  const [ano, mes, dia] = dt_time[0].split('-');
  const time = dt_time[1];
  document.getElementById('dia').selectedIndex = dia-1;
  document.getElementById('mes').selectedIndex = mes-1;
  document.getElementById('ano').selectedIndex = ano - (new Date().getFullYear());
  document.getElementById('horario').selectedIndex = 8 - parseInt(time.charAt(1));
  // Preencha os outros campos do formulário aqui, conforme necessário

}

const editAgendamento = (index) => {
    setOperation('UPDATE')
    setCodigo('cod',index)
    fillFields(index)
    openForm();
}

const editDelete = (event) => {
  if (event.target.type === 'button') {
    const [action, index] = event.target.id.split('-');
    console.log(action, index);
    if (action === 'edit') {
      editAgendamento(index);
    } else {
        const nome = document.querySelector(`#slc-${index} > td:nth-child(3)`).textContent
      const response = confirm(`Deseja realmente excluir o agendamento para ${nome}?`);
      if (response) {
        deleteAgendamento(index);
      }
    }
  }
}

const refreshTable = () => {
  updateTable()
  setCodigo('cod', 0)
  setOperation("", "")
  const input = document.querySelector('.campo_pesquisa')
  input.value = ""
  updateTable()
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
    submitForm('./agendamento.php');
};

const searchByName = () => {
  const searchTerm = document.querySelector('input[name="consulta"]').value.toLowerCase();
  if (searchTerm !== "") {
    setOperation('SELECT', searchTerm);
    submitForm('./clientes.php');
 };
};


const saveAgendamento = () => {
    if(isValidFields()){
        submitForm();
    }
}

const addNewAgendamento= ()=> {
    setOperation('CREATE')
    openForm();
}
// Outras funções e eventos permanecem inalterados...

//Eventos
document.getElementById('close-cadastro-form')
  .addEventListener('click', closeForm)

document.getElementById('open-cadastro-form')
  .addEventListener('click', addNewAgendamento)

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
