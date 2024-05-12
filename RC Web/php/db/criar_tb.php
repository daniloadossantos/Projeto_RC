<?php
require($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/conectar_db.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/util/log.php');

setExib(false);

try {
	// Tenta estabelecer a conexão com o banco de dados
	$conectar = new PDO("mysql:host=$host;dbname=$db", $user, $pass);
	$conectar->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);

	// Verifica se a conexão foi estabelecida com sucesso
	if ($conectar) {
		exib("Conexão com o banco de dados estabelecida com sucesso!");
	} else {
		exib("Falha ao estabelecer a conexão com o banco de dados.");
	}
} catch (PDOException $e) {
	// Se houver um erro, exibe a mensagem de erro
	echo "Erro ao conectar ao banco de dados: " . $e->getMessage();
}


if ($conectar) {

	try {
		$tb = "CEP";
		$drop = false;
		if($drop){
		$droptb = "DROP TABLE IF EXISTS $db.$tb";
		$conectar->exec($droptb);
		exib("DROP TABLE $db.$tb - OK");

		$tb = "CLIENTES";
		$droptb = "DROP TABLE IF EXISTS $db.$tb";
		$conectar->exec($droptb);
		exib("DROP TABLE $db.$tb - OK");
		}
	} catch (PDOException $erro) {
		echo "$pi Erro no DROP da tabela $db.$tb" . $erro->getMessage() . $po;
	}



	//Criar tabela CEP
	$tb = "CEP";

	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod		CHAR(9)			NOT NULL PRIMARY KEY,
				uf		VARCHAR(20)		NOT NULL,
				cidade	VARCHAR(40)		NOT NULL,
				bairro	VARCHAR(40)		NOT NULL,
				logra	VARCHAR(20)		NOT NULL)
				ENGINE=InnoDB DEFAULT CHARSET=latin1	
			";
		//
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. " . $erro->getMessage();
	}

	//Criar tabela Clientes
	$tb = "CLIENTES";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      UNSIGNED AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(70) NOT NULL,
				email		VARCHAR(30) NOT NULL,
				cpf_cnpj	VARCHAR(14) NOT NULL,
				tel1		VARCHAR(14) NOT NULL,
				tel2		VARCHAR(14) NULL,
				cep			CHAR(9)		NOT NULL,
				end_nro		INT 		NOT NULL,
				end_cmplto	VARCHAR(45)	NULL,
				dt_cad		DATE 		NULL,
				CONSTRAINT FK_" . $tb . "_CEP FOREIGN KEY (cep) REFERENCES CEP (cod))
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Serviços
	$tb = "SERVICOS";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6) 		UNSIGNED	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				tipo		VARCHAR(20) 			NOT NULL,
				descricao	VARCHAR(70) 			NOT NULL,
				preco		DECIMAL 				NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!") ;
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Técnicos
	$tb = "TECNICOS";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      UNSIGNED	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(45) 			NOT NULL,
				cpf			VARCHAR(11) 			NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Atendentes
	$tb = "ATENDENTES";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      UNSIGNED 	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				nome		VARCHAR(45) 			NOT NULL,
				cpf			VARCHAR(11) 			NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Agendamentos
	$tb = "AGENDAMENTOS";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)      UNSIGNED 	NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME 				NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!") ;
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}


	//Criar tabela Execucoes
	$tb = "EXECUCOES";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6) UNSIGNED     NOT NULL AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME 			NOT NULL
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}


	//Criar tabela Confirmacoes
	$tb = "CONFIRMACOES";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6) UNSIGNED     NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME		NULL,
				obs			VARCHAR(140)	NULL		
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Aprovções
	$tb = "APROVACOES";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6)		UNSIGNED    NOT NULL  AUTO_INCREMENT PRIMARY KEY, 
				data		DATETIME				NULL,
				status		TINYINT		UNSIGNED	NULL NULL		
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Catalogo
	$tb = "CATALOGO";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod			INT(6) UNSIGNED      NOT NULL  AUTO_INCREMENT, 
				cod_serv	INT(6)	UNSIGNED 	NOT NULL,
				CONSTRAINT PK_$tb PRIMARY KEY (cod, cod_serv),
				CONSTRAINT FK_" . $tb . "_COD_SERVICO FOREIGN KEY (cod_serv) REFERENCES SERVICOS (cod)
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Orçamentos
	$tb = "ORCAMENTOS";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod				INT(6)  UNSIGNED    NOT NULL, 
				cod_aprova		INT(6)	UNSIGNED	NOT NULL,
				cod_catalog		INT(6)  UNSIGNED	NOT NULL,
				cod_serv		INT(6)	UNSIGNED	NOT NULL,
				data			DATETIME	NOT NULL,
				descricao		VARCHAR(100) NULL,
				CONSTRAINT PK_$tb PRIMARY KEY (cod, cod_aprova, cod_catalog, cod_serv),
				CONSTRAINT FK_" . $tb . "_COD_APROVACOES FOREIGN KEY (cod_aprova) REFERENCES APROVACOES (cod),
				CONSTRAINT FK_" . $tb . "_COD_CATALOGO FOREIGN KEY (cod_catalog, cod_serv) REFERENCES CATALOGO (cod, cod_serv)
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}

	//Criar tabela Solicitações
	$tb = "SOLICITACOES";
	try {
		$criatb =
			"CREATE TABLE IF NOT EXISTS $db.$tb (
				cod				INT(6)	 UNSIGNED	NOT NULL,
				cod_cliente		INT(6)   UNSIGNED   NOT NULL,
				cod_servico		INT(6)	 UNSIGNED	NOT NULL,
				cod_atendent	INT(6) 	 UNSIGNED	NOT NULL,
				cod_tecnico		INT(6) 	 UNSIGNED	NOT NULL,
				cod_agenda		INT(6) 	 UNSIGNED	NOT NULL,
				cod_execucoes	INT(6) 	 UNSIGNED	NOT NULL,
				cod_confirma	INT(6) 	 UNSIGNED	NOT NULL,
				cod_orcamento	INT(6) 	 UNSIGNED	NOT NULL,
				dt_realiza		DATETIME 	NULL,
				dt_agendada		DATETIME	NULL,
				CONSTRAINT PK_$tb PRIMARY KEY (cod),
				CONSTRAINT FK_" . $tb . "_COD_CLIENTE FOREIGN KEY (cod_cliente) REFERENCES CLIENTES (cod),
				CONSTRAINT FK_" . $tb . "_COD_SERVICO FOREIGN KEY (cod_servico) REFERENCES SERVICOS (cod),
				CONSTRAINT FK_" . $tb . "_COD_ATENDENTE FOREIGN KEY (cod_atendent) REFERENCES ATENDENTES (cod),
				CONSTRAINT FK_" . $tb . "_COD_TECNICO FOREIGN KEY (cod_tecnico) REFERENCES TECNICOS (cod),
				CONSTRAINT FK_" . $tb . "_COD_AGENDAMENTO FOREIGN KEY (cod_agenda) REFERENCES AGENDAMENTOS (cod),
				CONSTRAINT FK_" . $tb . "_COD_EXECUCOES FOREIGN KEY (cod_execucoes) REFERENCES EXECUCOES (cod),
				CONSTRAINT FK_" . $tb . "_COD_CONFIRMACOES FOREIGN KEY (cod_confirma) REFERENCES CONFIRMACOES (cod),
				CONSTRAINT FK_" . $tb . "_COD_ORCAMENTOS FOREIGN KEY (cod_orcamento) REFERENCES ORCAMENTOS (cod)
			)
			ENGINE=InnoDB DEFAULT CHARSET=latin1";
		$conectar->exec($criatb);
		exib("CREATE TABLE $tb -> OK!");
	} catch (PDOException $erro) {
		echo "Tabela $tb. Falhou na criacao. Msg: " . $erro->getMessage();
	}
}
$conectar = null;
unset($conectar);
unset($tb);
unset($criatb);
setExib(false);