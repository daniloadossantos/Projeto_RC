<?php

function setExib(bool $value)
{
    if($value)
        $_SERVER['LOG'] = $value;
    else
        unset($_SERVER['LOG']);
}

function exib(string $msg)
{
	if(statusExib())
	{
		$pi = "<p>";
		$po = "</p>";
		echo "$pi $msg $po";
	}
}

function statusExib(): bool
{
    // Se LOG estiver definido e for true -> true
    return (isset($_SERVER['LOG']) && $_SERVER['LOG']);
}