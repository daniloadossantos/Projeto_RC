<?php 

	$host = "localhost";
	$user = "root";
	$pass = "";
	$db = "rcsystem3";

	try {             
		$conectar = new PDO("mysql:host=$host", $user, $pass);  
		$conectar->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION); 
		echo "Conexão ok!<br>";    // Exibir essa mensagem só no teste.
	 }
	 catch(PDOException $e) {
		echo "Falha de conexão:<br />" . $e->getMessage();
	}

	if($conectar){
		try {
			$criadb = "CREATE DATABASE $db";
			$conectar->exec($criadb);
			echo "Database ok!<br>"; 
		}
			catch(PDOException $e) {
			echo $criadb . "Falha na criação do DB:<br />" . $e->getMessage();
		}
	}
	$conectar = null;
