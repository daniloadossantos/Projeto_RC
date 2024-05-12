<?php
session_start();
require_once($_SERVER['DOCUMENT_ROOT'] . '/System/php/cls/cliente.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/System/php/cls/cep.php');
require_once($_SERVER['DOCUMENT_ROOT'] .'/System/php/db/db.php');

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
                $_POST['rua'],
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

function makeCliente()
{
    $cod = empty($_POST['cod']) ? 0 :  $_POST['cod'];
    $nome = empty($_POST['nome_pf']) ? $_POST['nome_pj'] : $_POST['nome_pf'];
    $cliente = new Cliente(
        $cod,
        $nome,
        $_POST['email'] ?? "",
        $_POST['cpf_cnpj'] ?? "",
        $_POST['tel1'] ?? "",
        $_POST['cep'] ?? "",
        $_POST['end_nro'] ?? "",
        $_POST["end_cmplto"] ?? "",
        Date('d-m-Y')
    );
    return $cliente;
}

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
        DB::insertCliente($cliente);
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

header('Location: ./../../clientes.php');

