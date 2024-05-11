class Solicitacoes 
{
    public int $codigoCliente;
    public int $codigoServico;
    public int $codigoSolicitacao;
    public string $dataRealizacaoServico;
    public string $dataAgendamento;
    public int $codigoTecnico;
    public int $codigoExecucoes;
    public int $codigoConfirmacoes;
    public int $codigoOrcamento;

    public function __construct(
        int $codigoCliente,
        int $codigoServico,
        int $codigoSolicitacao,
        string $dataRealizacaoServico,
        string $dataAgendamento,
        int $codigoTecnico,
        int $codigoExecucoes,
        int $codigoConfirmacoes,
        int $codigoOrcamento
    )
    {
        $this->codigoCliente = $codigoCliente;
        $this->codigoServico = $codigoServico;
        $this->codigoSolicitacao = $codigoSolicitacao;
        $this->dataRealizacaoServico = $dataRealizacaoServico;
        $this->dataAgendamento = $dataAgendamento;
        $this->codigoTecnico = $codigoTecnico;
        $this->codigoExecucoes = $codigoExecucoes;
        $this->codigoConfirmacoes = $codigoConfirmacoes;
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
        echo $pi . "Código de Execuções: " . $this->codigoExecucoes . $po;
        echo $pi . "Código de Confirmações: " . $this->codigoConfirmacoes . $po;
        echo $pi . "Código de Orçamento: " . $this->codigoOrcamento . $po;
        echo "<br/><br/>";
    }
}
