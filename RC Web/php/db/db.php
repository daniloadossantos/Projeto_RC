<?php
//session_start();
require_once('./php/cls/cliente.php');
require_once('./php/cls/cep.php');


class DB 
{
	// Path da conexao
	private static string $path = './php/db/conectar_db.php';
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
		try
		{
			require(DB::$path);
			$res = $conectar->prepare("SELECT * FROM $db.".DB::$cli);
			$res->execute();
			$clientes = [];
			while($reg = $res->fetch(PDO::FETCH_ASSOC))
			{
				$clientes[$reg["cod"]] = new Cliente(
					$reg["cod"],
					$reg["nome"]??"",
					$reg["email"]??"",
					$reg["cpf_cpnj"]??"",
					$reg["tel"]??"",
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
		try
		{
			require(DB::$path);
			$sql = "DELETE FROM $db.".DB::$cli." WHERE cod = $index";
			$res = $conectar->prepare($sql);
			$res->execute();
		}
		catch(PDOException $e)
		{
			echo "Erro em DELETE Cliente. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
	
	public static function updateCliente(Cliente $cli)
	{
		try
		{
			require(DB::$path);
			$sql = "UPDATE $db.".DB::$cli." SET ".
			"nome       = '".$cli->nome."', ".
			"email      = '".$cli->email."', ".
			"cpf_cnpj   = '".$cli->cpf_cnpj."', ".
			"tel        = '".$cli->tel."', ".
			"cep        = '".$cli->cep."', ".
			"end_nro    = '".$cli->end_nro."', ".
			"end_cmplto = '".$cli->end_cmplto."', ".
			"dt_cad     = '".$cli->dt_cad."' ".
			"WHERE cod  = ".$cli->cod;
			$res = $conectar->prepare($sql);
			$res->execute();
		}
		catch(PDOException $e)
		{
			echo "Erro em UPDATE Cliente. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
	
	public static function insertCliente(Cliente $cli)
	{
		try
		{
			require(DB::$path);
			$sql = "INSERT INTO $db.".DB::$cli.
			"(nome, email, cpf_cnpj, tel, cep, end_nro, end_cmplto, dt_cad) VALUES (".  
			"'".$cli->nome."', ".
			"'".$cli->email."', ".
			"'".$cli->cpf_cnpj."', ".
			"'".$cli->tel."', ".
			"'".$cli->cep."', ".
			$cli->end_nro.", ".
			"'".$cli->end_cmplto."', ".
			"'".$cli->dt_cad."' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		}
		catch(PDOException $e)
		{
			echo "Erro em INSERT Cliente. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
	
	// CRUP CEP 
	public static function getCEPs()
	{
		try
		{
			require(DB::$path);
			$res = $conectar->prepare("SELECT * FROM $db.".DB::$cep);
			$res->execute();
			$ceps = [];
			while($reg = $res->fetch(PDO::FETCH_ASSOC))
			{
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
		}
		catch(PDOException $e)
		{
			echo "Erro em obter CEPs. ".$e->getMessage();
		}
		finally
		{
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

	public static function fetchCEP(string $cep): CEP
	{
		try
		{
			$url = "https://viacep.com.br/ws/$cep/json/";
			$res = file_get_contents($url);
			$res = json_decode($res);
			$cep = new CEP(
				$res->cep,
				$res->uf,
				$res->localidade,
				$res->bairro,
				$res->logradouro,
				$res->logradouro
			)
			return $cep;
		}
		catch(Exception $e)
		{
			echo "Erro em fetch CEPs. ".$e->getMessage();
		}
	}
	
	public static function delCEP(string $cod)
	{
		try
		{
			require(DB::$path);
			$sql = "DELETE FROM $db.".DB::$cep." WHERE cod = '$cod'";
			$res = $conectar->prepare($sql);
			$res->execute();
		}
		catch(PDOException $e)
		{
			echo "Erro em DELETE CEP. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
	
	public static function updateCEP(CEP $cep)
	{
		try
		{
			require(DB::$path);
			$sql = "UPDATE $db.".DB::$cep." SET ".
			"uf        = '".$cep->uf."', ".
			"cidade    = '".$cep->cidade."', ".
			"bairro    = '".$cep->bairro."', ".
			"logra     = '".$cep->logra."', ".
			"ender     = '".$cep->ender."' ".
			"WHERE cod  = '".$cep->cod."' ";
			$res = $conectar->prepare($sql);
			$res->execute();
		}
		catch(PDOException $e)
		{
			echo "Erro em UPDATE CEP. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
	
	public static function insertCEP(CEP $cep)
	{
		try
		{
			require(DB::$path);
			$sql = "INSERT INTO $db.".DB::$cep.
			"(cod, uf, cidade, bairro, logra, ender)  VALUES (".  
			"'".$cep->cod."', ".
			"'".$cep->uf."', ".
			"'".$cep->cidade."', ".
			"'".$cep->bairro."', ".
			"'".$cep->logra."', ".
			"'".$cep->ender."' )";
			$res = $conectar->prepare($sql);
			$res->execute();
		}
		catch(PDOException $e)
		{
			echo "Erro em inserir CEP. ".$e->getMessage();
		}
		finally
		{
			$conectar = null;
		}
	}
}
