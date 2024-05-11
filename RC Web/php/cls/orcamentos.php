<?php
class Orcamento
{
    public int $codigoAprovacao;
    public string $dataAprovacao;
    public string $statusAprovacao;

    public function __construct(
        int $codigoAprovacao,
        string $dataAprovacao,
        string $statusAprovacao
    )
    {
        $this->codigoAprovacao = $codigoAprovacao;
        $this->dataAprovacao = $dataAprovacao;
        $this->statusAprovacao = $statusAprovacao;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código de Aprovação: " . $this->codigoAprovacao . $po;
        echo $pi . "Data de Aprovação: " . $this->dataAprovacao . $po;
        echo $pi . "Status de Aprovação: " . $this->statusAprovacao . $po;
        echo "<br/><br/>";
    }

    public function getDataAprovacao(): string
    {
        return $this->dataAprovacao;
    }

    public function getStatusAprovacao(): string
    {
        return $this->statusAprovacao;
    }

    public function getCodigoAprovacao(): int
    {
        return $this->codigoAprovacao;
    }
}
