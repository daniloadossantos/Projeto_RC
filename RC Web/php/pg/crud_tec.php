<?php
session_start();

require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/db.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/util/log.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/tecnico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cep.php');


setExib(true);

var_dump($_POST);

function checkCEP()
{
    try
    {
        if(!DB::hasCEP($_POST['cep']))
        {
            
            $cep = new CEP(
                $_POST['cep'],
                $_POST['uf'],
                $_POST['end_cidade'],
                $_POST['end_bairro'],
                $_POST['rua']
            );
    
            DB::insertCEP($cep);
        }
    }
    catch(Exception $e)
    {
        echo "Erro no make cliente" . $e->getMessage();
    }
}

function makeTecnico()
{
    $cod = empty($_POST['cod']) ? 0 :  $_POST['cod'];
    $tecnico = new Tecnico(
        $cod,
        $_POST['nome'] ?? "",
        $_POST['email'] ?? "",
        $_POST['cpf'] ?? "",
        $_POST['tel1'] ?? "",
        $_POST['tel2'] ?? "",
        $_POST['cep'] ?? "",
        (int)$_POST['end_nro'] ?? 0,
        $_POST["end_cmplto"] ?? ""
    );
    return $tecnico;
}

$CREATE = 'CREATE';
$READ = 'READ';
$UPDATE = 'UPDATE';
$DELETE = 'DELETE';

if(isset($_POST[$CREATE]))
{
    try
    {
        checkCEP();
        $cliente = makeTecnico();
        $cliente->show();
        DB::insertTecnico($cliente);
        exib("Tecnico criado");
    }
    catch(Exception $e)
    {
        echo "Erro no $CREATE tecnico" . $e->getMessage();
    }
}
else if(isset($_POST[$DELETE]))
{
    
    try
    {
        $cod = (int) $_POST['cod'];
        DB::delTecnico($cod);
        exib("Tecnico deletado");
    }
    catch(Exception $e)
    {
        echo "Erro no $READ tecnico" . $e->getMessage();
    }
}
else if(isset($_POST[$UPDATE]))
{
    
    try
    {
        $cod = $_POST['cod'];
        checkCEP();
        $tecnico = makeTecnico();
        DB::updateTecnico($tecnico);
        exib("Tecnico atualizado");
    }
    catch(Exception $e)
    {
        echo "Erro no $READ Tecnico" . $e->getMessage();
    }
}
else if(isset($_POST[$READ]))
{
    echo "Vou procurar";
}
exib("<button><a href=\"../../tecnico.php\">Tecnico</a></button>");

setExib(false);
// header('Location: ./../../tecnico.php');
