<?php

class Aprovacoes 
{
	private int $cod;
	private string $data;
	private int $status;
	
	public function  __construct(
		int $cod,
		string $data,
		int $status
	)
	{
		$this->cod = $cod;
		$this->data = $data;
		$this->status = $status;
	}
	
	public function getCod() { return $this->cod; }
	public function getData() { return $this->data; }
	public function getStatus() { return $this->status; }
	
	public function setCod(int $cod) { return $this->cod = $cod; }
	public function setData(string $data) { return $this->data = $data; }
	public function setStatus(int $status) { return $this->status = $status; }
	
	public function show()
	{
		$pi = "<p>";
		$po = "</p>";
		var_dump($this);
		echo $pi . $this->cod . $po;
		echo $pi . $this->data . $po;
		echo $pi . $this->status . $po;
	}
	
}