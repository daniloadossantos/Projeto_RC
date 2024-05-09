<?php 
	require('./db/conectar_db.php');
	
	
	
	if($conectar){
		if(false)
		{
			try
			{
				$pi = "<p>"; $po = "</p>";
				$tb = "CEP";
				$droptb = "DROP TABLE IF EXISTS $db.$tb";
				$conectar->exec($droptb);
				echo "$pi DROP TABLE $db.$tb - OK $po";
				
				$tb = "CLIENTES";
				$droptb = "DROP TABLE IF EXISTS $db.$tb";
				$conectar->exec($droptb);
				echo "$pi DROP TABLE $db.$tb - OK $po";
			}
			catch(PDOException $erro)
			{
				echo "$pi Erro no DROP da tabela $db.$tb" . $erro->getMessage() . $po;
			}
		}
		
		
		//Criar tabela CEP
		$tb = "CEP";
		
		try
		{
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod		CHAR(9)			NOT NULL PRIMARY KEY,
				uf		VARCHAR(20)		NOT NULL,
				cidade	VARCHAR(40)		NOT NULL,
				bairro	VARCHAR(40)		NOT NULL,
				logra	VARCHAR(20)		NOT NULL,
				ender	VARCHAR(40)		NOT NULL)
				ENGINE=InnoDB DEFAULT CHARSET=latin1	
			";
			//
			$conectar->exec($criatb);
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		}
		catch(PDOException $erro)
		{
			echo "Tabela $tb. Falhou na criacao. " . $erro->getMessage();
		}
		
		//Criar tabela Clientes
		$tb = "CLIENTES";
		try 
		{	//cad  - CPF ou CNPJ
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(70) NOT NULL,
				email		VARCHAR(30) NOT NULL,
				cpf_cpnj	VARCHAR(14) NOT NULL,
				tel			VARCHAR(14) NOT NULL,
				cep			CHAR(9)		NOT NULL,
				end_nro		INT 		NOT NULL,
				end_cmplto	VARCHAR(45)	NULL,
				dt_cad		DATE 		NULL,
				CONSTRAINT FK_".$tb."_CEP FOREIGN KEY (cep) REFERENCES CEP (cod),
				CONSTRAINT UNIQUE INDEX )
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Serviços
		$tb = "SERVICOS";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				tipo		VARCHAR(20) NOT NULL,
				descricao	VARCHAR(70) NOT NULL,
				preco		DECIMAL 	NOT NULL,
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Técnicos
		$tb = "TECNICOS";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(45) NOT NULL,
				cpf			VARCHAR(11) NOT NULL,
				preco		DECIMAL 	NOT NULL,
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Atendente
		$tb = "ATENDENTE";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(45) NOT NULL,
				cpf			VARCHAR(11) NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Agendamentos
		$tb = "AGENDAMENTOS";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				data		DATE 		NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		
		//Criar tabela Execucoes
		$tb = "EXECUCOES";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				data		DATE 		NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		
		//Criar tabela Confirmacoes
		$tb = "CONFIRMACOES";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      NOT NULL UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME	NULL,
				obs			VARCHAR(140)NULL		
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		

	}
	$conectar = null;
	unset($conectar);
	unset($tb);
	unset($criatb);
