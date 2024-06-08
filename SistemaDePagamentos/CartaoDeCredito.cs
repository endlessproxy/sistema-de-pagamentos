namespace SistemaDePagamentos;

class CartaoDeCredito : AnimacaoPagamento, IPagamentos
{
    // Propeties
    protected string NumeroCartao { get; set; }

    // Constructor
    public CartaoDeCredito(string numeroCartao)
    {
        NumeroCartao = numeroCartao;
    }
    
    // Methods
    public void ProcessarPagamento(double valor)
    {
        AnimacaoProcessamento(valor);
        Console.WriteLine($"Pagamento no valor de R${valor:N0} realizado com Sucesso. Numero do Cartão: {NumeroCartao}");
    }
    
    protected override void AnimacaoProcessamento(double valor)
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Cartão de Credito");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Cartão de Credito.");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Cartão de Credito..");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Cartão de Credito...");
            Thread.Sleep(500);
        }
    }
}