<?php 
	require('./db/conectar.php');
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
