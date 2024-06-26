<?php
if(session_status() == PHP_SESSION_NONE){
	session_start();
}
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/db/criar_tb.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cliente.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/cep.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/agendamento.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/aprovacao.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/catalogo.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/confirmacoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/execucoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/orcamentos.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/servico.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/solicitacoes.php');
require_once($_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web/php/cls/tecnico.php');


class DB
{
	// Path da conexao
	private static string $path = '/php/db/conectar_db.php';
	private static string $db = 'rcsystem';
	// Nome das tabelas
	private static string $cep = "CEP";
	private static string $cli = "CLIENTES";
	private static string $ser = "SERVICOS";
	private static string $tec = "TECNICOS";
	private static string $ate = "ATENDENTES";
	private static string $age = "AGENDAMENTOS";
	private static string $exe = "EXECUCOES";
	private static string $con = "CONFIRMACOES";
	private static string $apr = "APROVACOES";
	private static string $cat = "CATALOGO";
	private static string $orc = "ORCAMENTOS";
	private static string $sol = "SOLICITACOES";

	private static function getPath()
	{
		return $_SERVER['DOCUMENT_ROOT'] . '/Projeto_RC/RC Web' . DB::$path;
	}

	// CRUD Clientes
	public static function getClientes()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$cli);
			$res->execute();
			$clientes = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$clientes[$reg["cod"]] = new Cliente(
					$reg["cod"],
					$reg["nome"] ?? "",
					$reg["email"] ?? "",
					$reg["cpf_cpnj"] ?? "",
					$reg["tel1"] ?? "",
					$reg["tel2"] ?? "",
					$reg["cep"] ?? "",
					$reg["end_nro"],
					$reg["end_cmplto"] ?? "",
					$reg["dt_cad"] ?? ""
				);
			}
			return $clientes;
		} catch (PDOException $e) {
			echo "Erro em obter Clientes. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function getClientePorNome(string $nome)
	{
		try
		{
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM $db.".DB::$cli." WHERE nome LIKE '%".$nome."%'");
			$res->execute();
			$clientes = [];
			while($reg = $res->fetch(PDO::FETCH_ASSOC))
			{
				$clientes[$reg["cod"]] = new Cliente(
					$reg["cod"],
					$reg["nome"]??"",
					$reg["email"]??"",
					$reg["cpf_cnpj"]??"",
					$reg["tel"]??"",
					$reg["te2"]??"",
					$reg["cep"]??"",
					$reg["end_nro"],
					$reg["end_cmplto"]??"",
					$reg["dt_cad"]??""
				);
			}
			return $clientes;
		}
		catch(PDOException $e)
		{
			echo "Erro em obter Clientes. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}

	public static function delCliente(int $index)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$cli . " WHERE cod = $index";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Cliente. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateCliente(Cliente $cli)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$cli . " SET " .
				"nome       = '" . $cli->nome . "', " .
				"email      = '" . $cli->email . "', " .
				"cpf_cnpj   = '" . $cli->cpf_cnpj . "', " .
				"tel1       = '" . $cli->tel1 . "', " .
				"tel2       = '" . $cli->tel2 . "', " .
				"cep        = '" . $cli->cep . "', " .
				"end_nro    = '" . $cli->end_nro . "', " .
				"end_cmplto = '" . $cli->end_cmplto . "', " .
				"dt_cad     = '" . $cli->dt_cad . "' " .
				"WHERE cod  = " . $cli->cod;
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Cliente. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertCliente(Cliente $cli)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$cli .
				"(nome, email, cpf_cnpj, tel1, tel2, cep, end_nro, end_cmplto, dt_cad) VALUES (" .
				"'" . $cli->nome . "', " .
				"'" . $cli->email . "', " .
				"'" . $cli->cpf_cnpj . "', " .
				"'" . $cli->tel1 . "', " .
				"'" . $cli->tel2 . "', " .
				"'" . $cli->cep . "', " .
				" " . $cli->end_nro . ", " .
				"'" . $cli->end_cmplto . "', " .
				" CURDATE())";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Cliente. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	// CRUP CEP 
	public static function getCEPs()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$cep);
			$res->execute();
			$ceps = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$ceps[$reg["cod"]] = new CEP(
					$reg["cod"],
					$reg["uf"],
					$reg["cidade"],
					$reg["bairro"],
					$reg["logra"]
				);
			}
			return $ceps;
		} catch (PDOException $e) {
			echo "Erro em obter CEPs. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function hasCEP(string $cep): bool
	{
		try
		{
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM $db.".DB::$cep." WHERE cod = '".$cep."'");
			$res->execute();
			$ceps = 0;
			while($reg = $res->fetch(PDO::FETCH_ASSOC))
				$ceps++;
			return ($ceps != 0) ? true : false;
		}
		catch(PDOException $e)
		{
			echo "Erro em  hasCEPs. ".$e->getMessage();
		}
		catch(Exception $e)
		{
			echo "Erro: ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
	
	public static function delCEP(string $cod)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$cep . " WHERE cod = '$cod'";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE CEP. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateCEP(CEP $cep)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$cep . " SET " .
				"uf        = '" . $cep->uf . "', " .
				"cidade    = '" . $cep->cidade . "', " .
				"bairro    = '" . $cep->bairro . "', " .
				"logra     = '" . $cep->logra . "'" .
				"WHERE cod  = '" . $cep->cod . "' ";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE CEP. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertCEP(CEP $cep)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$cep .
				"(cod, uf, cidade, bairro, logra)  VALUES (" .
				"'" . $cep->cod . "', " .
				"'" . $cep->uf . "', " .
				"'" . $cep->cidade . "', " .
				"'" . $cep->bairro . "', " .
				"'" . $cep->logra . "')";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em inserir CEP. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}


	// CRUD Técnicos
	public static function getTecnicos()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$tec);
			$res->execute();
			$tecnicos = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				// Supondo que exista uma classe Tecnico representando a entidade do banco de dados
				$tecnicos[$reg["cod"]] = new Tecnico(
					$reg["cod"],
					$reg["nome"] ?? "",
					$reg["email"] ?? "",
					$reg["cpf"] ?? "",
					$reg["tel1"] ?? "",
					$reg["tel2"] ?? "",
					$reg["cep"] ?? "",
					$reg["end_nro"],
					$reg["end_cmplto"] ?? ""
				);
			}
			return $tecnicos;
		} catch (PDOException $e) {
			echo "Erro em obter Técnicos. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function getTecnicosPorNome(string $nome)
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$tec . " WHERE nome LIKE '%" . $nome . "%'");
			$res->execute();
			$tecnicos = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				// Supondo que exista uma classe Tecnico representando a entidade do banco de dados
				$tecnicos[$reg["cod"]] = new Tecnico(
					$reg["cod"],
					$reg["nome"] ?? "",
					$reg["email"] ?? "",
					$reg["cpf"] ?? "",
					$reg["tel1"] ?? "",
					$reg["tel2"] ?? "",
					$reg["cep"] ?? "",
					$reg["end_nro"],
					$reg["end_cmplto"] ?? ""
				);
			}
			return $tecnicos;
		} catch (PDOException $e) {
			echo "Erro em obter Técnicos. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function delTecnico(int $index)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$tec . " WHERE cod = $index";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Técnico. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateTecnico(Tecnico $tecnico)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$tec . " SET " .
				"nome       = '" . $tecnico->getNome() 		. "', " .
				"email      = '" . $tecnico->getEmail() 	. "', " .
				"cpf        = '" . $tecnico->getCPF() 		. "', " .
				"tel1       = '" . $tecnico->getTel1() 		. "', " .
				"tel2       = '" . $tecnico->getTel2() 		. "', " .
				"cep        = '" . $tecnico->getCEP() 		. "', " .
				"end_nro    =  " . $tecnico->getEndNro() 	. ", " .
				"end_cmplto = '" . $tecnico->getEndCmplto() . "' " .
				"WHERE cod  =  " . $tecnico->getCod();
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Técnico. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertTecnico(Tecnico $tecnico)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$tec .
				"(nome, email, cpf, tel1, tel2, cep, end_nro, end_cmplto) VALUES (" .
				"'" . $tecnico->getNome() . "', " .
				"'" . $tecnico->getEmail() . "', " .
				"'" . $tecnico->getCPF() . "', " .
				"'" . $tecnico->getTel1() . "', " .
				"'" . $tecnico->getTel2() . "', " .
				"'" . $tecnico->getCEP() . "', " .
				" " . $tecnico->getEndNro() . ", " .
				"'" . $tecnico->getEndCmplto() . "')";
				$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Técnico. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	// CRUD Solicitações
	public static function getSolicitacoes()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$sol);
			$res->execute();
			$solicitacoes = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				// Supondo que exista uma classe Solicitacao representando a entidade do banco de dados
				$solicitacoes[$reg["cod"]] = new Solicitacao(
					$reg["cod"] ?? 0,
					$reg["cod_cliente"] ?? 0,
					$reg["cod_tecnico"] ?? 0,
					$reg["cod_servico"] ?? 0,
					$reg["cod_atendent"] ?? 0,
					$reg["cod_orcamento"] ?? 0,
					$reg["dt_agendada"] ?? "",
					$reg["dt_executa"] ?? "",
					$reg["dt_confirma"] ?? "",
					$reg["status_agd"] ?? ""
				);
			}
			return $solicitacoes;
		} catch (PDOException $e) {
			echo "Erro em obter Solicitações. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}


	public static function delSolicitacao(int $index)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$sol . " WHERE cod = $index";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Solicitação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateSolicitacao(Solicitacao $solicitacao)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$sol . " SET " .
			"cod_cliente       = " . $solicitacao->codCli      . ", " .
			"cod_servico       = " . (($solicitacao->codServ == 0)? "NULL" : $solicitacao->codServ)      . ", " .
			"cod_atendent      = " . (($solicitacao->codAte == 0)? "NULL" : $solicitacao->codAte)     . ", " .
			"cod_tecnico       = " .(($solicitacao->codTec == 0)? "NULL" : $solicitacao->codTec)      . ", " .
			"cod_orcamento     = " . (($solicitacao->codOrc == 0)? "NULL" : $solicitacao->codOrc)    . ", " .
			"dt_confirma       = '" . (($solicitacao->dataConf == "")? "NULL" : $solicitacao->dataConf) . "', " .
			"dt_executa        = '" .(($solicitacao->dataExe == "")? "NULL" : $solicitacao->dataExe) . "', " .
			"dt_agendada       = '" . (($solicitacao->dataAgen == "")? "NULL" : $solicitacao->dataAgen) . "', " .
			"status_agd       = '" . (($solicitacao->status == "")? "NULL" : $solicitacao->status) . "' " .
			"WHERE cod = " . $solicitacao->cod;
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Solicitação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertSolicitacao(Solicitacao $solicitacao)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$sol .
				"(cod_cliente, cod_servico, cod_atendent, cod_tecnico, cod_orcamento, dt_confirma, dt_executa, dt_agendada, status_agd) VALUES (" .
				" " . $solicitacao->codCli . ", " .
				" " . (($solicitacao->codServ == 0)? "NULL" : $solicitacao->codServ) . ", " .
				" " . (($solicitacao->codAte == 0)? "NULL" : $solicitacao->codAte) . ", " .
				" " . (($solicitacao->codTec == 0)? "NULL" : $solicitacao->codTec) . ", " .
				" " . (($solicitacao->codOrc == 0)? "NULL" : $solicitacao->codOrc) . ", " .
				"'" . (($solicitacao->dataConf == "")? "NULL" : $solicitacao->dataConf) . "', " .
				"'" . (($solicitacao->dataExe == "")? "NULL" : $solicitacao->dataExe) . "', " .
				"'" . (($solicitacao->dataAgen == "")? "NULL" : $solicitacao->dataAgen) . "', " .
				"'" . (($solicitacao->status == "")? "NULL" : $solicitacao->status) . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Solicitação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	// CRUD Serviços
	public static function getServicos()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$ser);
			$res->execute();
			$servicos = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$servicos[$reg["cod"]] = new Servico(
					$reg["cod"],
					$reg["tipo"],
					$reg["descricao"],
					$reg["preco"]
				);
			}
			return $servicos;
		} catch (PDOException $e) {
			echo "Erro em obter Serviços. " . $e->getMessage();
			return [];
		} finally {
			$conectar = null;
		}
	}

	public static function deleteServico(int $codigo)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$ser . " WHERE cod = $codigo";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateServico(Servico $servico)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$ser . " SET " .
				"tipo = '" . $servico->getTipo() . "', " .
				"descricao = '" . $servico->getDescricao() . "', " .
				"preco = " . $servico->getValor() . " " .
				"WHERE cod = " . $servico->getCod();
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertServico(Servico $servico)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$ser .
				"(tipo, descricao, preco) VALUES (" .
				"'" . $servico->getTipo() . "', " .
				"'" . $servico->getDescricao() . "', " .
				"" . $servico->getValor() . " )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}
	// CRUD Orçamento
	public static function getOrcamentos()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$orc);
			$res->execute();
			$orcamentos = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$orcamentos[$reg["codigo_aprovacao"]] = new Orcamento(
					$reg["codigo_aprovacao"],
					$reg["data_aprovacao"],
					$reg["status_aprovacao"]
				);
			}
			return $orcamentos;
		} catch (PDOException $e) {
			echo "Erro em obter Orçamentos. " . $e->getMessage();
			return [];
		} finally {
			$conectar = null;
		}
	}

	public static function deleteOrcamento(int $codigoAprovacao)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$orc . " WHERE codigo_aprovacao = $codigoAprovacao";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Orçamento. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateOrcamento(Orcamento $orcamento)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$orc . " SET " .
				"data_aprovacao = '" . $orcamento->getDataAprovacao() . "', " .
				"status_aprovacao = '" . $orcamento->getStatusAprovacao() . "' " .
				"WHERE codigo_aprovacao = " . $orcamento->getCodigoAprovacao();
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Orçamento. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertOrcamento(Orcamento $orcamento)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$orc .
				"(codigo_aprovacao, data_aprovacao, status_aprovacao) VALUES (" .
				"'" . $orcamento->getCodigoAprovacao() . "', " .
				"'" . $orcamento->getDataAprovacao() . "', " .
				"'" . $orcamento->getStatusAprovacao() . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Orçamento. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}
	// CRUD Catalogo
	public static function getCatalogo()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$cat);
			$res->execute();
			$catalogo = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$catalogo[$reg["codigo_servico"]] = new Catalogo(
					$reg["codigo_servico"],
					$reg["nome_servico"],
					$reg["preco_servico"]
				);
			}
			return $catalogo;
		} catch (PDOException $e) {
			echo "Erro em obter Catálogo. " . $e->getMessage();
			return [];
		} finally {
			$conectar = null;
		}
	}

	public static function deleteCatalogo(int $codigoServico)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$cat . " WHERE codigo_servico = $codigoServico";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateCatalogo(Catalogo $servico)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$cat . " SET " .
				"nome_servico = '" . $servico->getNomeServico() . "', " .
				"preco_servico = '" . $servico->getPrecoServico() . "' " .
				"WHERE codigo_servico = " . $servico->getCodigoServico();
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertCatalogo(Catalogo $servico)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$cat .
				"(codigo_servico, nome_servico, preco_servico) VALUES (" .
				"'" . $servico->getCodigoServico() . "', " .
				"'" . $servico->getNomeServico() . "', " .
				"'" . $servico->getPrecoServico() . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}
	// CRUD Confirmação
	public static function getConfirmacoes()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$con);
			$res->execute();
			$confirmacoes = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$confirmacoes[$reg["codigo_confirmacao"]] = new Confirmacoes(
					$reg["codigo_confirmacao"],
					$reg["data_confirmacao"],
					$reg["status"]
				);
			}
			return $confirmacoes;
		} catch (PDOException $e) {
			echo "Erro em obter Confirmações. " . $e->getMessage();
			return [];
		} finally {
			$conectar = null;
		}
	}

	public static function deleteConfirmacao(int $codigoConfirmacao)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$con . " WHERE codigo_confirmacao = $codigoConfirmacao";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Confirmação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateConfirmacao(Confirmacoes $confirmacao)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$con . " SET " .
				"data_confirmacao = '" . $confirmacao->getDataConfirmacao() . "', " .
				"status = '" . $confirmacao->getStatus() . "' " .
				"WHERE codigo_confirmacao = " . $confirmacao->getCodigoConfirmacao();
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Confirmação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertConfirmacao(Confirmacoes $confirmacao)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$con .
				"(codigo_confirmacao, data_confirmacao, status) VALUES (" .
				"'" . $confirmacao->getCodigoConfirmacao() . "', " .
				"'" . $confirmacao->getDataConfirmacao() . "', " .
				"'" . $confirmacao->getStatus() . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Confirmação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	// CRUD Execução
	public static function getExecucoes()
	{
		try {
			require(DB::getPath());
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$exe);
			$res->execute();
			$execucoes = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$execucoes[$reg["codigo_execucao"]] = new Execucoes(
					$reg["codigo_execucao"],
					$reg["data_execucao"],
					$reg["status"]
				);
			}
			return $execucoes;
		} catch (PDOException $e) {
			echo "Erro em obter Execuções. " . $e->getMessage();
			return [];
		} finally {
			$conectar = null;
		}
	}

	public static function deleteExecucao(int $codigoExecucao)
	{
		try {
			require(DB::getPath());
			$sql = "DELETE FROM " . $db . "." . DB::$exe . " WHERE codigo_execucao = $codigoExecucao";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em DELETE Execução. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function updateExecucao(Execucoes $execucao)
	{
		try {
			require(DB::getPath());
			$sql = "UPDATE " . $db . "." . DB::$exe . " SET " .
				"data_execucao = '" . $execucao->getDataExecucao() . "', " .
				"status = '" . $execucao->getStatus() . "' " .
				"WHERE codigo_execucao = " . $execucao->getCodigoExecucao();
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em UPDATE Execução. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function insertExecucao(Execucoes $execucao)
	{
		try {
			require(DB::getPath());
			$sql = "INSERT INTO " . $db . "." . DB::$exe .
				"(codigo_execucao, data_execucao, status) VALUES (" .
				"'" . $execucao->getCodigoExecucao() . "', " .
				"'" . $execucao->getDataExecucao() . "', " .
				"'" . $execucao->getStatus() . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Execução. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	// CRUD Agendamentos
}
