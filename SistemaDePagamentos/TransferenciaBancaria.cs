namespace SistemaDePagamentos;

class TransferenciaBancaria : AnimacaoPagamento, IPagamentos
{
    // Propeties
    protected string NumeroConta { get; set; }

    // Constructor
    public TransferenciaBancaria(string numeroConta)
    {
        NumeroConta = numeroConta;
    }
    
    // Method
    public void ProcessarPagamento(double valor)
    {
        AnimacaoProcessamento(valor);
        Console.WriteLine($"Pagamento no valor de R${valor:N0} realizado com Sucesso. Numero da conta: {NumeroConta}");
    }
    
    protected override void AnimacaoProcessamento(double valor)
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Transferencia Bancaria");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Transferencia Bancaria.");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Transferencia Bancaria..");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via Transferencia Bancaria...");
            Thread.Sleep(500);
        }
    }
}