<?php 
	session_start();
	$host = "localhost";
	$user = "root";
	$pass = "";
	$db = "rcsystem";
	
	try {             
		$conectar = new PDO("mysql:host=$host;dbname=$db", $user, $pass);  
		$conectar->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	}catch(PDOException $e) {
		echo "Falha de conexão:<br />" . $e->getMessage();
	}
