<?php 
	$host = "localhost";
	$user = "root";
	$pass = "";
	$db = "RCSystem";
	
	try {             
		$conectar = new PDO("mysql:host=$host;dbname=$db", $user, $pass);  
		$conectar->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION); 
	}catch(PDOException $e) {
		echo "Falha na criação do DB:<br />" . $e->getMessage();
	}
