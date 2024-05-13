<?php
session_start();

// Independente de o usuario existir ou a senha ser válida
// redireciona para as páginas que precisa se true
$_SESSION['INGNORE_USER'] = true;

// Se houver uma tabela para validação de senhas
// a validação pode ser feita por aqui

if($_SESSION['INGNORE_USER'])
{
    $_POST['nome'] = 'adm';
    $_POST['senha'] = 'adm';
}

if(isset($_POST['nome']) && isset($_POST['senha']))
{
    if($_POST['nome'] === 'tecnico' && $_POST['senha'] === 'tecnico')
    {
        $_SESSION['USER'] = $_POST['nome'];
        $_SESSION['PG_ACCESS'] =  [
            "CLIENTES"     =>false, 
            "SERVICOS"     =>true,
            "AGENDAMENTOS" =>true,
            "TECNICOS"     =>false,
        ];
        var_dump($_SESSION);
        // Por hora fica com .html
        header('Location: ./../../agendamento.html');
    }
    else if($_POST['nome'] === 'adm' && $_POST['senha'] === 'adm')
    {
        $_SESSION['USER'] = $_POST['nome'];
        $_SESSION['PG_ACCESS'] =  [
            "CLIENTES"     =>true, 
            "SERVICOS"     =>true,
            "AGENDAMENTOS" =>true,
            "TECNICOS"     =>true,
        ];
        var_dump($_SESSION);
        header('Location: ./../../clientes.php');
    }
}
else
{
    unset($_SESSION['USER']);
    header('Location: ./../../index.php');
}
