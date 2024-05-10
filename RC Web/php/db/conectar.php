<?php 
	$host = "localhost";
	$user = "root";
	$pass = "";
	$db = "RCSystem";
	
	try {             
		$conectar = new PDO("mysql:host=$host", $user, $pass);  
		$conectar->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	}catch(PDOException $e) {
		echo "Falha de conexão:<br />" . $e->getMessage();
	}
