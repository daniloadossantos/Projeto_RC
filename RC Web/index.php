<?php
session_start();

require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/db.php');

// Testes de classe
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cliente.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/servico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/agendamento.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/tecnico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cep.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/aprovacao.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/catalogo.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/confirmacoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/execucoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/orcamentos.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/servico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/solicitacoes.php');


// $cli = new Cliente(12, "Joao", "jo@gmail.com", "400500900-25", "11920003000", "Avenida lagod");
// $serv = new Servico(32, "Augusto", "Manutencao", "Manutencao de ar-condicionado", 89.56);
// $agend = new Agendamento(64, "Ferreiro", "22/04/2024", "Av tal", "Augusto");
// $tecnico = new Tecnico(2332, "Jose", "jose@gmail.com", "800900700-64", "97865-2345");
// $cep = new Cep("04560-200", "SP", "São Paulo", "Jardins", "Praça", "Rua das Rosas");
// $aprov = new Aprovacoes(3214, "28/06/2029", 1);

// $cli->show();
// $serv->show();
// $agend->show();
// $tecnico->show();
// $cep->show();
// $aprov->show();

function view($arr)
{
	foreach ($arr as $key => $value) {
		echo "<h2>$key</h2><p>";
		print_r($value);
		echo "</p></br>";
	}
}

function hd(string $msg)
{
	echo "<h2>$msg</h2>";
}
// - - - -  Banco de Dados - - - 
//require('./db/criar_db.php');
//require('./db/criar_tb.php');


// - - - - - - Clientes - -- - - - 
// $clientes = DB::getClientes()??[];
// view($clientes);

//Teste update
// DB::updateCliente($cli);
$clientes = DB::getClientes()??[];
view($clientes);

// Teste insert
$cli = new Cliente(0, "Ricardo", "ric@gu.com", "80090050022", '11985263410', "11945781245", "03087-000", 789, "A esquerda");
$cli->show();

echo date('d-m-Y');

DB::insertCliente($cli);

$clientes = DB::getClientes()??[];
view($clientes);


// - - - - - - CEPs - -- - - - 

// hd("Teste READ");
// view(DB::getCEPs());

// hd("Teste UPDATE");
// $ceps = DB::getCEPs();
// $cep = $ceps["02652-080"];
// $cep->cidade  = "Super São Paulo";
// DB::updateCEP($cep);
// view(DB::getCEPs());
// $cep->cidade  = "São Paulo";
// DB::updateCEP($cep);

// $cep = new CEP(
// "08050-820", 
// "SP", 
// "São Paulo",
// "Jardim das Camélias",
// "Jardim",
// "Rua Madrigal da Sombra"
// );

// $cep = new CEP(
// 	"08050-820",
// 	"SP",
// 	"São Paulo",
// 	"Jardim das Camélias",
// 	"Jardim",
// 	"Rua Madrigal da Sombra"
// );
//>>>>>>> ced99f54713486e72d4790706db67774f4a1bb08

// hd("Teste DELETE");
// DB::delCEP($cep->cod);
// view(DB::getCEPs());


// hd("Teste CREATE");
// DB::insertCEP($cep);
// view(DB::getCEPs());


echo "<button><a href=\"./clientes.php\">Clientes</a></button>";

//=======
// hd("Teste CREATE");
// DB::insertCEP($cep);
// view(DB::getCEPs());
//>>>>>>> ced99f54713486e72d4790706db67774f4a1bb08
