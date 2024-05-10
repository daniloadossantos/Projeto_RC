<?php

class Agendamento 
{
	private int $codigo;
	private String $nomeCliente;
	private string $data;
	private string $endereco;
	private string $tecnico;
	
	public function __construct(
		int $codigo,
		String $nomeCliente,
        string $data,
        string $endereco,
        string $tecnico
	)
	{
		$this->codigo = $codigo;
		$this->nomeCliente = $nomeCliente;
		$this->data = $data;
		$this->endereco = $endereco;
		$this->tecnico = $tecnico;
	}
	
	public function getCodigo(): int
	{
		return $this->codigo;
	}
	
	public function getNomeCliente(): string
	{
		return $this->nomeCliente;
	}
	
	public function getData(): string
	{
		return $this->data;
	}
	
	public function getEndereco(): string
	{
		return $this->endereco;
	}
	
	public function getTecnico(): string
	{
		return $this->tecnico;
	}
	
	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		
		echo $pi . "Codigo " . $this->codigo;
		echo "Nome " . $this->nomeCliente;
		echo "Data " . $this->data;
		echo "Ender " . $this->endereco ;
		echo "Tecnico " . $this->tecnico . $po;
		echo "</br> </br>";
	}
}