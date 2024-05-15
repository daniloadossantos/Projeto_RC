<?php

class Tecnico
{
	private int $codigo;
	private string $nome;
	private string $email;
	private string $cpf;
	private string $tel1;
	private string $tel2;
	private string $cep;
	private int $end_nro;
	private string $end_cmplto;

	public function __construct(
		int $cod,
		string $nome,
		string $email,
		string $cpf,
		string $tel1,
		string $tel2,
		string $cep,
		int $end_nro,
		string $end_cmplto
	) {
		$this->codigo = $cod;
		$this->nome = $nome;
		$this->email = $email;
		$this->cpf = $cpf;
		$this->tel1 = $tel1;
		$this->tel2 = $tel2;
		$this->cep = $cep;
		$this->end_nro = $end_nro;
		$this->end_cmplto = $end_cmplto;
	}

	public function getCod(): int
	{
		return $this->codigo;
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
		return $this->cpf;
	}

	public function getTel1(): string
	{
		return $this->tel1;
	}

	public function getTel2(): string
	{
		return $this->tel2;
	}

	public function getCEP(): string
	{
		return $this->cep;
	}

	public function getEndNro(): int
	{
		return $this->end_nro;
	}

	public function getEndCmplto(): string
	{
		return $this->end_cmplto;
	}

	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		var_dump($this);
		echo $pi . $this->codigo . $po;
		echo $pi . $this->nome . $po;
		echo $pi . $this->email . $po;
		echo $pi . $this->cpf . $po;
		echo $pi . $this->tel1 . $po;
		echo $pi . $this->tel2 . $po;
		echo $pi . $this->cep . $po;
		echo $pi . $this->end_nro . $po;
		echo $pi . $this->end_cmplto . $po;
	}
}
