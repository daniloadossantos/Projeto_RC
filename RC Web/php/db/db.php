<?php
if(session_status() == PHP_SESSION_NONE){
	session_start();
}
require_once('./php/db/criar_tb.php');
require_once('./php/cls/cliente.php');
require_once('./php/cls/cep.php');
require_once('./php/cls/agendamento.php');
require_once('./php/cls/aprovacao.php');
require_once('./php/cls/catalogo.php');
require_once('./php/cls/confirmacoes.php');
require_once('./php/cls/execucoes.php');
require_once('./php/cls/orcamentos.php');
require_once('./php/cls/servico.php');
require_once('./php/cls/solicitacoes.php');
require_once('./php/cls/tecnico.php');


class DB
{
	// Path da conexao
	private static string $path = './php/db/conectar_db.php';
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

	// CRUD Clientes
	public static function getClientes()
	{
		try {
			require(DB::$path);
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

	public static function delCliente(int $index)
	{
		try {
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
			$sql = "INSERT INTO " . $db . "." . DB::$cli .
				"(nome, email, cpf_cnpj, tel1, tel2, cep, end_nro, end_cmplto, dt_cad) VALUES (" .
				"'" . $cli->nome . "', " .
				"'" . $cli->email . "', " .
				"'" . $cli->cpf_cnpj . "', " .
				"'" . $cli->tel1 . "', " .
				"'" . $cli->tel2 . "', " .
				"'" . $cli->cep . "', " .
				"'" . $cli->end_nro . ", " .
				"'" . $cli->end_cmplto . "', " .
				"'" . $cli->dt_cad . "' )";
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
			require(DB::$path);
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$cep);
			$res->execute();
			$ceps = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$ceps[$reg["cod"]] = new CEP(
					$reg["cod"],
					$reg["uf"],
					$reg["cidade"],
					$reg["bairro"],
					$reg["logra"],
					$reg["ender"]
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
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
			$sql = "UPDATE " . $db . "." . DB::$cep . " SET " .
				"uf        = '" . $cep->uf . "', " .
				"cidade    = '" . $cep->cidade . "', " .
				"bairro    = '" . $cep->bairro . "', " .
				"logra     = '" . $cep->logra . "', " .
				"ender     = '" . $cep->ender . "' " .
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
			require(DB::$path);
			$sql = "INSERT INTO " . $db . "." . DB::$cep .
				"(cod, uf, cidade, bairro, logra, ender)  VALUES (" .
				"'" . $cep->cod . "', " .
				"'" . $cep->uf . "', " .
				"'" . $cep->cidade . "', " .
				"'" . $cep->bairro . "', " .
				"'" . $cep->logra . "', " .
				"'" . $cep->ender . "' )";
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
			require(DB::$path);
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
					$reg["tel"] ?? "",
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
			require(DB::$path);
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
			require(DB::$path);
			$sql = "UPDATE " . $db . "." . DB::$tec . " SET " .
				"nome       = '" . $tecnico->getNome() . "', " .
				"email      = '" . $tecnico->getEmail() . "', " .
				"cpf        = '" . $tecnico->getCPF() . "', " .
				"tel        = '" . $tecnico->getTel() . "' " .
				"WHERE cod  = " . $tecnico->getCod();
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
			require(DB::$path);
			$sql = "INSERT INTO " . $db . "." . DB::$tec .
				"(nome, email, cpf, tel) VALUES (" .
				"'" . $tecnico->getNome() . "', " .
				"'" . $tecnico->getEmail() . "', " .
				"'" . $tecnico->getCPF() . "', " .
				"'" . $tecnico->getTel() . "', " .
				"'" . $tecnico->cep . "', " .
				"'" . $tecnico->end_nro . ", " .
				"'" . $tecnico->end_cmplto . "', )" .
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
			require(DB::$path);
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$sol);
			$res->execute();
			$solicitacoes = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				// Supondo que exista uma classe Solicitacao representando a entidade do banco de dados
				$solicitacoes[$reg["cod"]] = new Solicitacao(
					$reg["cod_cliente"],
					$reg["cod_servico"],
					$reg["cod_solicitacao"],
					$reg["data_realizacao"],
					$reg["data_agendamento"],
					$reg["cod_tecnico"],
					$reg["cod_execucao"],
					$reg["cod_confirmacao"],
					$reg["cod_orcamento"]
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
			require(DB::$path);
			$sql = "DELETE FROM " . $db . "." . DB::$sol . " WHERE cod_solicitacao = $index";
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
			require(DB::$path);
			$sql = "UPDATE " . $db . "." . DB::$sol . " SET " .
				"cod_cliente       = '" . $solicitacao->getCodCliente() . "', " .
				"cod_servico       = '" . $solicitacao->getCodServico() . "', " .
				"data_realizacao   = '" . $solicitacao->getDataRealizacao() . "', " .
				"data_agendamento  = '" . $solicitacao->getDataAgendamento() . "', " .
				"cod_tecnico       = '" . $solicitacao->getCodTecnico() . "', " .
				"cod_execucao      = '" . $solicitacao->getCodExecucao() . "', " .
				"cod_confirmacao   = '" . $solicitacao->getCodConfirmacao() . "', " .
				"cod_orcamento     = '" . $solicitacao->getCodOrcamento() . "' " .
				"WHERE cod_solicitacao = " . $solicitacao->getCodSolicitacao();
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
			require(DB::$path);
			$sql = "INSERT INTO " . $db . "." . DB::$sol .
				"(cod_cliente, cod_servico, data_realizacao, data_agendamento, cod_tecnico, cod_execucao, cod_confirmacao, cod_orcamento) VALUES (" .
				"'" . $solicitacao->getCodCliente() . "', " .
				"'" . $solicitacao->getCodServico() . "', " .
				"'" . $solicitacao->getDataRealizacao() . "', " .
				"'" . $solicitacao->getDataAgendamento() . "', " .
				"'" . $solicitacao->getCodTecnico() . "', " .
				"'" . $solicitacao->getCodExecucao() . "', " .
				"'" . $solicitacao->getCodConfirmacao() . "', " .
				"'" . $solicitacao->getCodOrcamento() . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Solicitação. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function getServicos()
	{
		try {
			require(DB::$path);
			$res = $conectar->prepare("SELECT * FROM " . $db . "." . DB::$ser);
			$res->execute();
			$servicos = [];
			while ($reg = $res->fetch(PDO::FETCH_ASSOC)) {
				$servicos[$reg["codigo"]] = new Servico(
					$reg["codigo"],
					$reg["nome"],
					$reg["tipo"],
					$reg["descricao"],
					$reg["valor"]
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
			require(DB::$path);
			$sql = "DELETE FROM " . $db . "." . DB::$ser . " WHERE codigo = $codigo";
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
			require(DB::$path);
			$sql = "UPDATE " . $db . "." . DB::$ser . " SET " .
				"nome = '" . $servico->getNome() . "', " .
				"tipo = '" . $servico->getTipo() . "', " .
				"descricao = '" . $servico->getDescricao() . "', " .
				"valor = '" . $servico->getValor() . "' " .
				"WHERE codigo = " . $servico->getCod();
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
			require(DB::$path);
			$sql = "INSERT INTO " . $db . "." . DB::$ser .
				"(nome, tipo, descricao, valor) VALUES (" .
				"'" . $servico->getNome() . "', " .
				"'" . $servico->getTipo() . "', " .
				"'" . $servico->getDescricao() . "', " .
				"'" . $servico->getValor() . "' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		} catch (PDOException $e) {
			echo "Erro em INSERT Serviço. " . $e->getMessage();
		} finally {
			$conectar = null;
		}
	}

	public static function getOrcamentos()
	{
		try {
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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

	public static function getCatalogo()
	{
		try {
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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

	public static function getConfirmacoes()
	{
		try {
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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
	public static function getExecucoes()
	{
		try {
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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
			require(DB::$path);
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
}
