<?php 
	session_start();
	// Azure config
	// $host = "rcsystemapp-server.mysql.database.azure.com";
	// $user = "gdofitzows";
	// $pass = 'g$xswhDY9sXWMC7p';
	// $db = "db_rcsystem";

	// XAMP config
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

