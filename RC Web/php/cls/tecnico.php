<?php

class Tecnico
{
	private int $codigo;
	private string $nome;
	private string $email;
	private string $cpf;
	private string $telefone;
	public string $cep;
	public int $end_nro;
	public string $end_cmplto;

	public function __construct(
		int $cod,
		string $nome,
		string $email,
		string $cpf,
		string $telefone,
		string $cep,
		string $end_nro,
		string $end_cmplto
	) {
		$this->codigo = $cod;
		$this->nome = $nome;
		$this->email = $email;
		$this->cpf = $cpf;
		$this->telefone = $telefone;
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

	public function getTel(): string
	{
		return $this->telefone;
	}

	public function getEnd(): string
	{
		return $this->cep . ', ' . $this->end_nro . ', ' . $this->end_cmplto;
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
		echo $pi . $this->telefone . $po;
		echo $pi . $this->cep . $po;
		echo $pi . $this->end_nro . $po;
		echo $pi . $this->end_cmplto . $po;
	}
}
