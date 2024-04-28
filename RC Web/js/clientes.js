let openFormularioCliente = document.querySelector('#open-cadastro-form');
let openAlterarCliente = document.querySelector('#open-alterar-form')
let closeFormularioCliente = document.querySelector('#close-cadastro-form');
let closeAlterarCliente = document.querySelector('#close-alterar-form');
let formularioCliente = document.querySelector('#cadastro-form-cliente');
let formularioAlterarCliente = document.querySelector('#alterar-form-cliente');
let fade = document.querySelector('#fade');

const toggleForm = () => {
  [formularioCliente, fade].forEach((el) => {
    el.classList.toggle('hide')})
};

const toggleForm1 = () => {
  [formularioAlterarCliente, fade].forEach((el) => {
  el.classList.toggle('hide')})
};

[openFormularioCliente, closeFormularioCliente, fade].forEach ((el) => {
  el.addEventListener("click", () => toggleForm());
});
[openAlterarCliente, closeAlterarCliente, fade].forEach ((el) => {
  el.addEventListener("click", () => toggleForm1());
});



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
