<?php

class Cliente
{
	public int $cod;
	public string $nome;
	public string $email;
	public string $cpf_cnpj;
	public string $tel1;
	public string $tel2;
	public string $cep;
	public int $end_nro;
	public string $end_cmplto;
	public string $dt_cad;



	public function __construct(
		int $cod,
		string $nome,
		string $email,
		string $cpf_cnpj,
		string $tel1,
		string $tel2,
		string $cep,
		int $end_nro,
		string $end_cmplto,
		string $dt_cad
	) {
		$this->cod = $cod;
		$this->nome = $nome;
		$this->email = $email;
		$this->cpf_cnpj = $cpf_cnpj;
		$this->tel1 = $tel1;
		$this->tel2 = $tel2;
		$this->cep = $cep;
		$this->end_nro = $end_nro;
		$this->end_cmplto = $end_cmplto;
		$this->dt_cad = $dt_cad;
	}


	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		echo $pi . $this->cod . $po;
		echo $pi . $this->nome . $po;
		echo $pi . $this->email . $po;
		echo $pi . $this->cpf_cnpj . $po;
		echo $pi . $this->tel1 . $po;
		echo $pi . $this->tel2 . $po;
		echo $pi . $this->cep . $po;
		echo $pi . $this->end_nro . $po;
		echo $pi . $this->end_cmplto . $po;
		echo $pi . $this->dt_cad . $po;
	}

	public function getCod(): int
	{
		return $this->cod;
	}

	public function getNome(): string
	{
		return $this->nome;
	}

	public function getEmail(): string
	{
		return $this->email;
	}

	public function getCPF(): string
	{
		return $this->cpf_cnpj;
	}

	public function getTel1(): string
	{
		return $this->tel1;
	}
	public function getTel2(): string
	{
		return $this->tel2;
	}

	public function getEnd(): string
	{
		return $this->cep . ', ' . $this->end_nro . ', ' . $this->end_cmplto;
	}
}
