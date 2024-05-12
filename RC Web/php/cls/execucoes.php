<?php
class Execucoes 
{
    public int $codigoExecucao;
    public string $dataExecucao;
    public string $status;

    public function __construct(
        int $codigoExecucao,
        string $dataExecucao,
        string $status
    )
    {
        $this->codigoExecucao = $codigoExecucao;
        $this->dataExecucao = $dataExecucao;
        $this->status = $status;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código de Execução: " . $this->codigoExecucao . $po;
        echo $pi . "Data de Execução: " . $this->dataExecucao . $po;
        echo $pi . "Status: " . $this->status . $po;
        echo "<br/><br/>";
    }

    public function getCodigoExecucao(): int
    {
        return $this->codigoExecucao;
    }

    public function getDataExecucao(): string
    {
        return $this->dataExecucao;
    }

    public function getStatus(): string
    {
        return $this->status;
    }
}
