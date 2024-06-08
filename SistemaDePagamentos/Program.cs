using System.Runtime.InteropServices;
using SistemaDePagamentos;

class Program
{
    static void Main(string[] args)
    {
        MenuProgram.Menu();
        
        // Exemplo via PayPal:
        // Paypal usuario1 = new Paypal("juninho.minecraft75@gmail.com");
        // usuario1.ProcessarPagamento(2584);

        
        // Exemplo via Transferencia Bancaria:
        // TransferenciaBancaria usuario2 = new TransferenciaBancaria("57846512");
        // usuario2.ProcessarPagamento(55928);

        
        // Exemplo via Cartão de Credito:
        CartaoDeCredito usuario3 = new CartaoDeCredito("4253 5264 6987 1823");
        usuario3.ProcessarPagamento(3599);
        
    }
}