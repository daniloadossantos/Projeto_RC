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
    public string $status;

    public function __construct(
        int $cod,
        int $codCli,
        int $codTec = 0,
        int $codServ = 0,
        int $codAte = 0,
        int $codOrc = 0,
        string $dataAgen = "",
        string $dataExe = "",
        string $dataConf = "",
        string $status
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
        $this->status = $status;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código : " . $this->cod . $po;
        echo $pi . "Código do cliente: " . $this->codCli . $po;
        echo $pi . "Código da serv: " . $this->codServ . $po;
        echo $pi . "Dcod tecnico: " . $this->codTec . $po;
        echo $pi . "Cod de ate: " . $this->codAte . $po;
        echo $pi . "Data agenda: " . $this->dataAgen . $po;
        echo $pi . "Data de Execuções: " . $this->dataExe . $po;
        echo $pi . "Data de Confirmações: " . $this->dataConf . $po;
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
        return $this->codOrc;
    }

    public function getDataAgendamento(): string
    {
        return $this->dataAgen;
    }


    public function getDataExecucao(): int
    {
        return $this->dataExe;
    }

    public function getDataConf(): int
    {
        return $this->dataConf;
    }


}
