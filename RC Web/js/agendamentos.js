document.addEventListener('DOMContentLoaded', function () {
    const logoutButton = document.getElementById('logout');
    const agendamentoForm = document.getElementById('agendamento-form');

    // Adicionando evento de clique ao botão de sair
    logoutButton.addEventListener('click', function () {
        // Redirecionamento para a página index.html
        window.location.href = 'index.html';
    });

    // Adicionando evento de envio ao formulário de agendamento
    agendamentoForm.addEventListener('submit', function (event) {
        event.preventDefault();
        // Aqui você pode adicionar a lógica para processar o agendamento
        const data = document.getElementById('data').value;
        const horario = document.getElementById('horario').value;
        // Exemplo de log para visualização dos dados
        console.log('Data:', data, 'Horário:', horario);
        // Após processar o agendamento, você pode redirecionar o usuário para outra página
        // Por exemplo, redirecionamento para a página de confirmação
        window.location.href = 'confirmacao.html';
    });
});


