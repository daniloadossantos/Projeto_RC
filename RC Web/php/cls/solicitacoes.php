<?php
class Solicitacao
{
    public int $codigoCliente;
    public int $codigoServico;
    public int $codigoSolicitacao;
    public string $dataRealizacaoServico;
    public string $dataAgendamento;
    public int $codigoTecnico;
    public int $codigoExecucao;
    public int $codigoConfirmacao;
    public int $codigoOrcamento;

    public function __construct(
        int $codigoCliente,
        int $codigoServico,
        int $codigoSolicitacao,
        string $dataRealizacaoServico,
        string $dataAgendamento,
        int $codigoTecnico,
        int $codigoExecucao,
        int $codigoConfirmacao,
        int $codigoOrcamento
    ) {
        $this->codigoCliente = $codigoCliente;
        $this->codigoServico = $codigoServico;
        $this->codigoSolicitacao = $codigoSolicitacao;
        $this->dataRealizacaoServico = $dataRealizacaoServico;
        $this->dataAgendamento = $dataAgendamento;
        $this->codigoTecnico = $codigoTecnico;
        $this->codigoExecucao = $codigoExecucao;
        $this->codigoConfirmacao = $codigoConfirmacao;
        $this->codigoOrcamento = $codigoOrcamento;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código do Cliente: " . $this->codigoCliente . $po;
        echo $pi . "Código do Serviço: " . $this->codigoServico . $po;
        echo $pi . "Código da Solicitação: " . $this->codigoSolicitacao . $po;
        echo $pi . "Data de Realização do Serviço: " . $this->dataRealizacaoServico . $po;
        echo $pi . "Data de Agendamento: " . $this->dataAgendamento . $po;
        echo $pi . "Código do Técnico: " . $this->codigoTecnico . $po;
        echo $pi . "Código de Execuções: " . $this->codigoExecucao . $po;
        echo $pi . "Código de Confirmações: " . $this->codigoConfirmacao . $po;
        echo $pi . "Código de Orçamento: " . $this->codigoOrcamento . $po;
        echo "<br/><br/>";
    }

    public function getCodCliente(): ?int
    {
        // Obtendo todos os clientes
        $clientes = DB::getClientes();

        // Verificando se há clientes associados à solicitação
        if (!empty($clientes)) {
            // Iterando sobre os clientes
            foreach ($clientes as $codigo => $cliente) {
                // Comparando o nome do cliente com o nome associado à solicitação
                if ($cliente->getCod() === $this->codigoCliente) {
                    return $codigo; // Retornando o código do cliente encontrado
                }
            }
        }
        // Se nenhum cliente correspondente for encontrado, retorna null
        return null;
    }
/*    public function getCodCliente(): int
    {
        return $this->codigoCliente;
    }*/

    public function getCodServico(): int
    {
        return $this->codigoServico;
    }

    public function getDataRealizacao(): string
    {
        return $this->dataRealizacaoServico;
    }

    public function getDataAgendamento(): string
    {
        return $this->dataAgendamento;
    }

    public function getCodTecnico(): int
    {
        return $this->codigoTecnico;
    }

    public function getCodExecucao(): int
    {
        return $this->codigoExecucao;
    }

    public function getCodConfirmacao(): int
    {
        return $this->codigoConfirmacao;
    }

    public function getCodOrcamento(): int
    {
        return $this->codigoOrcamento;
    }
}
