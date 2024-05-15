<?php
session_start();

require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/db.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cliente.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/solicitacoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/tecnico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cep.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/util/log.php');

setExib(true);

$cli = DB::getClientes();
$tec = DB::getTecnicos();
$sol = DB::getSolicitacoes();

var_dump($_POST);


$CREATE = 'CREATE';
$READ = 'READ';
$UPDATE = 'UPDATE';
$DELETE = 'DELETE';

if(isset($_POST[$CREATE]))
{
    try
    {
        $solicitacao = makeSolicitacao();
        DB::insertSolicitacao($solicitacao);
        exib("Solicitacao criada");
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
        DB::delSolicitacao($cod);
        exib("Solicitacao deletada");
    }
    catch(Exception $e)
    {
        echo "Erro no $DELETE cliente" . $e->getMessage();
    }
}
else if(isset($_POST[$UPDATE]))
{
    
    try
    {
        $cod = $_POST['cod'];
        $solicitacao = makeSolicitacao();
        DB::updateSolicitacao($solicitacao);
        exib("Solicitacao atualizada");
    }
    catch(Exception $e)
    {
        echo "Erro no $UPDATE cliente" . $e->getMessage();
    }
}
else if(isset($_POST[$READ]))
{
    echo "Vou procurar";
}

exib("<button><a href=\"../../agendamento.php\">Solicitacao</a></button>");

setExib(false);
// header('Location: ./../../agendamento.php');