<?php

class Cliente 
{
	public int $cod;
	public string $nome;
	public string $email;
	public string $cpf_cnpj;
	public string $tel;
	public string $cep;
	public int $end_nro;
	public string $end_cmplto;
	public string $dt_cad;
	
	
	
	public function __construct(
		int $cod, 
		string $nome, 
		string $email, 
		string $cpf_cnpj, 
		string $tel,
		string $cep,
		string $end_nro,
		string $end_cmplto,
		string $dt_cad
	)
	{
		$this->cod = $cod;
		$this->nome = $nome;
		$this->email = $email;
		$this->cpf_cnpj = $cpf_cnpj;
		$this->tel = $tel;
		$this->cep = $cep;
		$this->end_nro = $end_nro;
		$this->end_cmplto = $end_cmplto;
		$this->dt_cad = $dt_cad;
	}
	
	// public function getCod(): int { return $this->cod; }
	
	// public function getNome(): string { return $this->nome; }
	
	// public function getEmail(): string { return $this->email; }
	
	// public function getNroCad(): string { return $this->cad; }
	
	// public function getTel(): string { return $this->tel; }
	
	// public function getEndNro(): string { return $this->end_nro; }
	
	// public function getEndCmpto(): string { return $this->end_cmplto; }
	
	// public function getData(){return $this->dt_cad;}
	
	// public function setCod(int $cod) { $this->cod = $cod; }
	
	// public function setNome(string $nome) { $this->nome = $nome; }
	
	// public function setEmail(string $email){ $this->email = $email; }
		
	// public function setNroCad(int $nro){$this->cad = $nro; }
		
	// public function setTel(string $tel){ $this->tel = $tel; }
	
	// public function setEndNro(int $nro) {$this->end_nro = $nro; }
	
	// public function setEndCmpto(string c$mplto) { $this->end_cmplto = $cmpto; }
	
	// public function setData(string $data) {$this->dt_cad = $data;}
	
	
	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		echo $pi . $this->cod . $po;
		echo $pi . $this->nome . $po;
		echo $pi . $this->email . $po;
		echo $pi . $this->cpf_cnpj . $po;
		echo $pi . $this->telefone . $po;
		echo $pi . $this->cep . $po;
		echo $pi . $this->end_nro . $po;
		echo $pi . $this->end_cmplto . $po;
		echo $pi . $this->dt_cad . $po;
	}
}
