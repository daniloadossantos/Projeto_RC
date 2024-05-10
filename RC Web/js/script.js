document.addEventListener('DOMContentLoaded', function () {
    const loginForm = document.getElementById('login-form');
    const loginPage = document.getElementById('login-page');
    
    loginForm.addEventListener('submit', function (event) {
        event.preventDefault();
        // Aqui você pode adicionar a lógica de autenticação
        
        // Por exemplo, redirecionamento para a página de clientes após login
        showPage('clients-page');
    });

    function showPage(pageId) {
        const pages = document.querySelectorAll('.page');
        pages.forEach(page => {
            page.style.display = 'none';
        });
        const pageToShow = document.getElementById(pageId);
        pageToShow.style.display = 'block';
    }
});

document.addEventListener('DOMContentLoaded', function () {
    const agendamentos = [
        { data: '2024-04-25', horario: '09:00', cliente: 'Cliente 1' },
        { data: '2024-04-25', horario: '10:00', cliente: 'Cliente 2' },
        { data: '2024-04-25', horario: '11:00', cliente: 'Cliente 3' }
    ];

    // Função para exibir a lista de agendamentos do dia na página inicial
    function exibirAgendamentosDoDia() {
        const agendamentosDoDia = agendamentos.filter(agendamento => agendamento.data === getCurrentDate());
        const listaAgendamentos = document.getElementById('lista-agendamentos');
        listaAgendamentos.innerHTML = '';
        if (agendamentosDoDia.length > 0) {
            const ul = document.createElement('ul');
            agendamentosDoDia.forEach(agendamento => {
                const li = document.createElement('li');
                li.textContent = `${agendamento.horario} - ${agendamento.cliente}`;
                ul.appendChild(li);
            });
            listaAgendamentos.appendChild(ul);
        } else {
            listaAgendamentos.textContent = 'Não há agendamentos para hoje.';
        }
    }

    // Função para obter a data atual no formato YYYY-MM-DD
    function getCurrentDate() {
        const today = new Date();
        const year = today.getFullYear();
        const month = String(today.getMonth() + 1).padStart(2, '0');
        const day = String(today.getDate()).padStart(2, '0');
        return `${year}-${month}-${day}`;
    }

    // Exibir os agendamentos do dia ao carregar a página
    exibirAgendamentosDoDia();
});

// Função teste de login
function logar(){
    var login = document.getElementById('nome').value;
    var senha = document.getElementById('email').value;

    if(login == "tecnico" && senha == "tecnico"){
        alert('Sucesso');
        location.href = "./agendatecnico.html";
    }
    else if(login == "adm" && senha == "adm"){
        alert('Sucesso');
        location.href = "./clientes.html";
    }
    else{
        alert('Usuario ou senha incorreta');
    }
}