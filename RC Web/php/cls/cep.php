<?php
	
class CEP
{
	public string $cod;
	public string $uf;
	public string $cidade;
	public string $bairro;
	public string $logra;
	public string $ender;
	
	public function __construct(
		string $cod,
		string $uf,
		string $cidade,
		string $bairro,
		string $logra,
		string $ender 
	)
	{
		$this->cod = $cod;
		$this->uf = $uf;
		$this->cidade = $cidade;
		$this->bairro = $bairro;
		$this->logra = $logra;
		$this->ender = $ender;
	}
	
	// public function getCod():string
	// {
		// return $this->cod;
	// }
	// public function setCod(string $cod)
	// {
		// $this->cod = $cod;
	// }
	
	// public function getUF():string
	// {
		// return $this->uf;
	// }
	// public function setUF(string $uf)
	// {
		// $this->uf = $uf;
	// }
	
	// public function getCidade():string
	// {
		// return $this->cidade;
	// }
	// public function setCidade(string $cidade)
	// {
		// $this->cidade = $cidade;
	// }
	
	// public function getBairro():string
	// {
		// return $this->bairro;
	// }
	// public function setBairro(string $bairro)
	// {
		// $this->bairro = $bairro;
	// }
	
	// public function getEnder():string
	// {
		// return $this->ender;
	// }
	// public function setEnder(string $ender)
	// {
		// $this->ender = $ender;
	// }
	
	// public function getLogra():string
	// {
		// return $this->logra;
	// }
	// public function setLogra(string $logra)
	// {
		// $this->logra = $logra;
	// }
	
	// Apenas para teste 
	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		var_dump($this);
		echo $pi . $this->cod . $po;
		echo $pi . $this->uf . $po;
		echo $pi . $this->cidade . $po;
		echo $pi . $this->bairro . $po;
		echo $pi . $this->ender . $po;
		echo $pi . $this->logra . $po;
	}
	
}