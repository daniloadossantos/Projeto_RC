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
		{	
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
				CONSTRAINT FK_".$tb."_CEP FOREIGN KEY (cep) REFERENCES CEP (cod))
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
				cod			INT(6) 		UNSIGNED	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				tipo		VARCHAR(20) 			NOT NULL,
				descricao	VARCHAR(70) 			NOT NULL,
				preco		DECIMAL 				NOT NULL
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
				cod			INT(6)      UNSIGNED	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(45) 			NOT NULL,
				cpf			VARCHAR(11) 			NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Atendentes
		$tb = "ATENDENTES";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      UNSIGNED 	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(45) 			NOT NULL,
				cpf			VARCHAR(11) 			NOT NULL
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
				cod			INT(6)      UNSIGNED 	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME 				NOT NULL
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
				cod			INT(6) UNSIGNED     NOT NULL AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME 			NOT NULL
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
				cod			INT(6) UNSIGNED     NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME		NULL,
				obs			VARCHAR(140)	NULL		
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Aprovções
		$tb = "APROVACOES";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)		UNSIGNED    NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME				NULL,
				status		TINYINT		UNSIGNED	NULL NULL		
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		
		//Criar tabela Catalogo
		$tb = "CATALOGO";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6) UNSIGNED      NOT NULL  AUTO_INCREMENT, 
				cod_serv	INT(6)	UNSIGNED 	NOT NULL,
				CONSTRAINT PK_$tb PRIMARY KEY (cod, cod_serv),
				CONSTRAINT FK_".$tb."_COD_SERVICO FOREIGN KEY (cod_serv) REFERENCES SERVICOS (cod)
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		/*
		//Criar tabela Orçamentos
		$tb = "ORCAMENTOS";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod				INT(6)      NOT NULL UNSIGNED, 
				cod_aprova		INT(6)		NOT NULL UNSIGNED,
				cod_catalog		INT(6) 		NOT NULL UNSIGNED,
				cod_serv		INT(6)		NOT NULL UNSIGNED,
				data			DATETIME	NOT NULL,
				descricao		VARCHAR(100) NULL,
				CONSTRAINT PK_$tb PRIMARY KEY (cod, cod_aprova, cod_catalog, cod_serv),
				CONSTRAINT FK_".$tb."_COD_APROVACOES FOREIGN KEY (cod_aprova) REFERENCES APROVACOES (cod),
				CONSTRAINT FK_".$tb."_COD_CATALOGO FOREIGN KEY (cod_catalog, cod_serv) REFERENCES CATALOGO (cod, cod_serv)
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}

		//Criar tabela Solicitações
		$tb = "SOLICITACOES";
		try 
		{	
			$criatb = 
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod				INT(6)		NOT NULL UNSIGNED,
				cod_cliente		INT(6)      NOT NULL UNSIGNED,
				cod_servico		INT(6)		NOT NULL UNSIGNED,
				cod_atendent	INT(6) 		NOT NULL UNSIGNED,
				cod_tecnico		INT(6) 		NOT NULL UNSIGNED,
				cod_agenda		INT(6) 		NOT NULL UNSIGNED,
				cod_execucoes	INT(6) 		NOT NULL UNSIGNED,
				cod_confirma	INT(6) 		NOT NULL UNSIGNED,
				cod_orcamento	INT(6) 		NOT NULL UNSIGNED,
				dt_realiza		DATETIME 	NULL,
				dt_agendada		DATETIME	NULL,
				CONSTRAINT PK_$tb PRIMARY KEY (cod),
				CONSTRAINT FK_".$tb."_COD_CLIENTE FOREIGN KEY (cod_cliente) REFERENCES CLIENTES (cod),
				CONSTRAINT FK_".$tb."_COD_SERVICO FOREIGN KEY (cod_servico) REFERENCES SERVICOS (cod),
				CONSTRAINT FK_".$tb."_COD_ATENDENTE FOREIGN KEY (cod_atendent) REFERENCES ATENDENTES (cod),
				CONSTRAINT FK_".$tb."_COD_TECNICO FOREIGN KEY (cod_tecnico) REFERENCES TECNICOS (cod),
				CONSTRAINT FK_".$tb."_COD_AGENDAMENTO FOREIGN KEY (cod_agenda) REFERENCES AGENDAMENTOS (cod),
				CONSTRAINT FK_".$tb."_COD_EXECUCOES FOREIGN KEY (cod_execucoes) REFERENCES EXECUCOES (cod),
				CONSTRAINT FK_".$tb."_COD_CONFIRMACOES FOREIGN KEY (cod_confirma) REFERENCES CONFIRMACOES (cod),
				CONSTRAINT FK_".$tb."_COD_ORCAMENTOS FOREIGN KEY (cod_orcamento) REFERENCES ORCAMENTOS (cod)
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";     
			$conectar->exec($criatb);          
			echo "<p>CREATE TABLE $tb -> OK!</p>"; 
		} 
		catch(PDOException $erro)
		{ 
			echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
		}
		*/
		
	}
	$conectar = null;
	unset($conectar);
	unset($tb);
	unset($criatb);
