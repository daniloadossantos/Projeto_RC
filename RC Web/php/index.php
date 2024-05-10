<?php

include('./cliente.php');
include('./servico.php');
include('./agendamento.php');
include('./tecnico.php');

$cli = new Cliente(12, "Joao", "jo@gmail.com", "400500900-25", "11920003000", "Avenida lagod");
$serv = new Servico(32, "Augusto", "Manutencao", "Manutencao de ar-condicionado", 89.56);

$agend = new Agendamento(64, "Ferreiro", "22/04/2024", "Av tal", "Augusto");

$tecnico = new Tecnico(2332, "Jose", "jose@gmail.com", "800900700-64", "97865-2345");

/*
$cli->show();
$serv->show();
$agend->show();
$tecnico->show();
*/

//require('./db/criar_db.php');
require('./db/criar_tb.php');



