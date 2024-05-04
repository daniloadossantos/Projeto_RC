//Abrir e fechar formulário
const openFormClient = () => {
  document.getElementById('cadastro-form-cliente')
  .classList.add('active');
}

const closeFormClient = () => {
  document.getElementById('cadastro-form-cliente')
  .classList.remove('active');
}

const btnNew = document.getElementById('open-cadastro-form');
  btnNew.addEventListener('click', openFormClient);

const btnClose = document.getElementById('close-cadastro-form');
  btnClose.addEventListener('click', closeFormClient);

//Funções CRUD
const tempClient = {
  nome: "Lucas",
  sobrenome: "Santos",
  endereco: "Rua do Chá",
  cpf: "123456789-11",
  telefone1: "(11) 912345678",
  email: "lucassantos@gmail.com"
}  

const getLocalStorage = () => JSON.parse(localStorage.getItem('db_client')) ?? []
const setLocalStorage = (dbClient) => localStorage.setItem('db_client', JSON.stringify(dbClient))


//Create
const createClient = (client) => {
  const dbClient = getLocalStorage()
  dbClient.push(client)
  setLocalStorage(dbClient)
}
//Read
const readClient = () => getLocalStorage()

//Update
const updateClient = (index, client) => {
  const dbClient = readClient()
  dbClient[index] = client
  setLocalStorage(dbClient)
}

//Delete
const deleteClient = (index) => {
  const dbClient = readClient()
  dbClient.splice(index,1)
  setLocalStorage(dbClient)
}

//Interação com o Layout

const isValidFields = () => {
  return document.getElementById('form-client').reportValidity()
}

const clearFields = () => {
  const fields = document.querySelectorAll('.input-field')
  fields.forEach(field => field.value = "")
}

const saveClient = () => {
  if(isValidFields()){ 
  const client = {
    nome: document.getElementById('nome_cliente').value,
    sobrenome: document.getElementById('sobrenome_cliente').value,
    endereco: document.getElementById('endereco').value,
    cpf: document.getElementById('cpf-cliente').value,
    telefone: document.getElementById('telefone-cliente1').value,
    email: document.getElementById('email-cliente').value
  }
  createClient(client)
  clearFields()
  closeFormClient()
  }
}

document.getElementById('salvar')
  .addEventListener('click', saveClient)

document.getElementById('cancelar')
  .addEventListener('click', closeFormClient)

/*document.addEventListener('DOMContentLoaded', function () {
    // Simulação de dados de clientes (substitua com os dados reais)
    const clientes = [
        { nome: 'Cliente 1', telefone: '(XX) XXXX-XXXX', endereco: 'Endereço 1' },
        { nome: 'Cliente 2', telefone: '(XX) XXXX-XXXX', endereco: 'Endereço 2' },
        { nome: 'Cliente 3', telefone: '(XX) XXXX-XXXX', endereco: 'Endereço 3' }
    ];

    const logoutButton = document.getElementById('logout');
    const clientesList = document.getElementById('clientes-list');

    // Adicionando evento de clique ao botão de sair
    logoutButton.addEventListener('click', function () {
        // Aqui você pode adicionar a lógica para fazer logout
        // Por exemplo, redirecionamento para a página de login
        window.location.href = 'index.html';
    });

    // Função para exibir a lista de clientes na tabela
    function renderClientes() {
        clientesList.innerHTML = '';
        clientes.forEach(cliente => {
            const row = document.createElement('tr');
            row.innerHTML = `
                <td>${cliente.nome}</td>
                <td>${cliente.telefone}</td>
                <td>${cliente.endereco}</td>
            `;
            clientesList.appendChild(row);
        });
    }

    // Renderiza os clientes ao carregar a página
    renderClientes();
});*/
