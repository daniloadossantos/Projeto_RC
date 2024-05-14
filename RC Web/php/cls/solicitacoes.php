<?php
class Solicitacao
{
    public int $cod;
    public int $codCli;
    public int $codServ;
    public int $codTec;
    public int $codAte;
    public int $codOrc;
    public string $dataAgen;
    public string $dataExe;
    public string $dataConf;

    public function __construct(
        int $cod,
        int $codCli,
        int $codTec = null,
        int $codServ = null,
        int $codAte = null,
        int $codOrc = null,
        string $dataAgen = null,
        string $dataExe = null,
        string $dataConf = null,
    ) {
        $this->cod = $cod;
        $this->codCli = $codCli;
        $this->codServ = $codServ;
        $this->codTec = $codTec;
        $this->codAte = $codAte;
        $this->dataAgen = $dataAgen;
        $this->dataExe = $dataExe;
        $this->dataConf = $dataConf;
        $this->codOrc = $codOrc;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código do Cliente: " . $this->cod . $po;
        echo $pi . "Código do Serviço: " . $this->codCli . $po;
        echo $pi . "Código da Solicitação: " . $this->codServ . $po;
        echo $pi . "Data de Realização do Serviço: " . $this->codTec . $po;
        echo $pi . "Data de Agendamento: " . $this->codAte . $po;
        echo $pi . "Código do Técnico: " . $this->dataAgen . $po;
        echo $pi . "Código de Execuções: " . $this->dataExe . $po;
        echo $pi . "Código de Confirmações: " . $this->dataConf . $po;
        echo $pi . "Código de Orçamento: " . $this->codOrc . $po;
        echo "<br/><br/>";
    }

    // public function getCodCliente(): ?int
    // {
    //     // Obtendo todos os clientes
    //     $clientes = DB::getClientes();

    //     // Verificando se há clientes associados à solicitação
    //     if (!empty($clientes)) {
    //         // Iterando sobre os clientes
    //         foreach ($clientes as $codigo => $cliente) {
    //             // Comparando o nome do cliente com o nome associado à solicitação
    //             if ($cliente->getCod() === $this->codigoCliente) {
    //                 return $codigo; // Retornando o código do cliente encontrado
    //             }
    //         }
    //     }
    //     // Se nenhum cliente correspondente for encontrado, retorna null
    //     return null;
    // }

    public function getCod(): int
    {
        return $this->cod;
    }

   public function getCodCliente(): int
    {
        return $this->codCli;
    }

    public function getCodServico(): int
    {
        return $this->codServ;
    }
    public function getCodTecnico(): int
    {
        return $this->codTec;
    }

    public function getCodAtend(): int
    {
        return $this->codAte;
    }

    public function getCodOrcamento(): int
    {
        return $this->codigoOrcamento;
    }

    public function getDataAgendamento(): string
    {
        return $this->dataAgen;
    }


    public function getDataExecucao(): int
    {
        return $this->dataExe;
    }

    public function getDataConfirmacao(): int
    {
        return $this->dataConf;
    }


}
