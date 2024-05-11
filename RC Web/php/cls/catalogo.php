class Catalogo 
{
    public int $codigoServico;
    public string $nomeServico;
    public float $precoServico;

    public function __construct(
        int $codigoServico,
        string $nomeServico,
        float $precoServico
    )
    {
        $this->codigoServico = $codigoServico;
        $this->nomeServico = $nomeServico;
        $this->precoServico = $precoServico;
    }

    public function show()
    {
        $pi = "<p>";
        $po = "</p>";

        echo $pi . "Código do Serviço: " . $this->codigoServico . $po;
        echo $pi . "Nome do Serviço: " . $this->nomeServico . $po;
        echo $pi . "Preço do Serviço: $" . number_format($this->precoServico, 2) . $po;
        echo "<br/><br/>";
    }
}
