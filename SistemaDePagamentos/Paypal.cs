namespace SistemaDePagamentos;

class Paypal : AnimacaoPagamento, IPagamentos
{
    // Propeties
    protected string Email { get; set; }

    // Constructor
    public Paypal(string email)
    {
        Email = email;
    }
    
    // Methods
    public void ProcessarPagamento(double valor)
    {
        AnimacaoProcessamento(valor);
        Console.WriteLine($"Pagamento no valor de R${valor:N0} realizado com Sucesso. Email: {Email}");
    }
    
    protected override void AnimacaoProcessamento(double valor)
    {
        for (int i = 0; i < 6; i++)
        {
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via PayPal");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via PayPal.");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via PayPal..");
            Thread.Sleep(200);
            Console.Clear();
            Console.WriteLine($"Processando pagamento no valor de R${valor:N0} via PayPal...");
            Thread.Sleep(500);
        }
    }
}