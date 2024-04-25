document.addEventListener('DOMContentLoaded', function () {
    const logoutButton = document.getElementById('logout');
    const orcamentoForm = document.getElementById('orcamento-form');

    // Adicionando evento de clique ao botão de sair
    logoutButton.addEventListener('click', function () {
        // Aqui você pode adicionar a lógica para fazer logout
        // Por exemplo, redirecionamento para a página de login
        window.location.href = 'index.html';
    });

    // Adicionando evento de envio ao formulário de orçamento
    orcamentoForm.addEventListener('submit', function (event) {
        event.preventDefault();
        // Aqui você pode adicionar a lógica para processar o orçamento
        const cliente = document.getElementById('cliente').value;
        const tipoServico = document.getElementById('tipo-servico').value;
        const descricao = document.getElementById('descricao').value;
        const preco = document.getElementById('preco').value;
        // Exemplo de log para visualização dos dados
        console.log('Cliente:', cliente, 'Tipo de Serviço:', tipoServico, 'Descrição:', descricao, 'Preço:', preco);
        // Após processar o orçamento, você pode redirecionar o usuário para outra página
        // Por exemplo, redirecionamento para a página de confirmação
        window.location.href = 'confirmacao.html';
    });

    // Adicionando evento de input ao campo de preço para formatá-lo como moeda
    const precoInput = document.getElementById('preco');
    precoInput.addEventListener('input', function (event) {
        // Obtém o valor digitado no campo de preço
        let preco = event.target.value;
        // Remove caracteres não numéricos do valor
        preco = preco.replace(/\D/g, '');
        // Formata o valor como moeda
        preco = (preco / 100).toLocaleString('pt-BR', { style: 'currency', currency: 'BRL' });
        // Atualiza o valor do campo de preço com a formatação
        event.target.value = preco;
    });
});
