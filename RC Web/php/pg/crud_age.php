<?php
session_start();

require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/db.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cliente.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/solicitacoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/tecnico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cep.php');

if( !isset($_SESSION['USER']) )
{
header('Location: ./index.php');
}

$cli = DB::getClientes();
$ceps = DB::getCEPs();
$tec = DB::getTecnicos();
$sol = DB::getSolicitacoes();

$CREATE = 'CREATE';
$READ = 'READ';
$UPDATE = 'UPDATE';
$DELETE = 'DELETE';

if(isset($_POST[$CREATE]))
{
    try
    {
        $nome = empty($_POST['nome_pf']) ? $_POST['nome_pj'] : $_POST['nome_pf'];
        echo $nome;
        checkCEP();
        $cliente = makeCliente();
        $cliente->show();
        DB::insertCliente($cliente);
        exib("Cliente criado");
    }
    catch(Exception $e)
    {
        echo "Erro no $CREATE cliente" . $e->getMessage();
    }
}
else if(isset($_POST[$DELETE]))
{
    
    try
    {
        $cod = (int) $_POST['cod'];
        DB::delCliente($cod);
        exib("Cliente deletado");
    }
    catch(Exception $e)
    {
        echo "Erro no $READ cliente" . $e->getMessage();
    }
}
else if(isset($_POST[$UPDATE]))
{
    
    try
    {
        $cod = $_POST['cod'];
        checkCEP();
        $cliente = makeCliente();
        DB::updateCliente($cliente);
        exib("Cliente atualizado");
    }
    catch(Exception $e)
    {
        echo "Erro no $READ cliente" . $e->getMessage();
    }
}
else if(isset($_POST[$READ]))
{
    echo "Vou procurar";
}
exib("<button><a href=\"../../agendamento.php\">Clientes</a></button>");

setExib(false);
// header('Location: ./../../agendamento.php');