<?php

class Servico 
{
	private int $codigo;
	private string $tipo;
	private string $descricao;
	private float $valor;
	
	public function __construct(
		int $codigo,
		string $tipo, 
		string $descricao, 
		float $valor
	)
	{
		$this->codigo = $codigo;
		$this->tipo = $tipo;
		$this->descricao = $descricao;
		$this->valor = $valor;
	}
	
	public function getCod(): int
	{
		return $this->codigo;
	}

	
	public function getTipo(): string
	{
		return $this->tipo;
	}
	
	public function getDescricao(): string
	{
		return $this->descricao;
	}
	
	public function getValor(): float
	{
		return $this->valor;
	}
	
	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		echo $pi . $this->codigo . $po;
		echo $pi . $this->nome . $po;
		echo $pi . $this->tipo . $po;
		echo $pi . $this->descricao . $po;
		echo $pi . $this->valor . $po;
		var_dump($this->codigo);
	}
}