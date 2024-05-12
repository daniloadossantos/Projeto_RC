<?php
class Confirmacoes
{
    public int $codigoConfirmacao;
    public string $dataConfirmacao;
    public string $status;

    public function __construct(
        int $codigoConfirmacao,
        string $dataConfirmacao,
        string $status
    ) {
        $this->codigoConfirmacao = $codigoConfirmacao;
        $this->dataConfirmacao = $dataConfirmacao;
        $this->status = $status;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código de Confirmação: " . $this->codigoConfirmacao . $po;
        echo $pi . "Data de Confirmação: " . $this->dataConfirmacao . $po;
        echo $pi . "Status: " . $this->status . $po;
        echo "<br/><br/>";
    }

    public function getCodigoConfirmacao(): int
    {
        return $this->codigoConfirmacao;
    }

    public function getDataConfirmacao(): string
    {
        return $this->dataConfirmacao;
    }

    public function getStatus(): string
    {
        return $this->status;
    }
}
