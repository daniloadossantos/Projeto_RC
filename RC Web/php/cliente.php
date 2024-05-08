<?php

class Cliente 
{
	private int codigo;
	private string nome;
	private string email;
	private string cpf;
	private string telefone;
	private string endereco;
	
	public __construct(int cod, string nome, string email, string cpf, string telefone, string endereco)
	{
		$this->codigo = cod;
		$this->nome = nome;
		$this->email = email;
		$this->cpf = cpf;
		$this->telefone = telefone;
		$this->endereco = endereco;
	}
	
	
}
