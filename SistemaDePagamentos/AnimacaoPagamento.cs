namespace SistemaDePagamentos;

abstract class AnimacaoPagamento
{ 
    // Animação de processamento
    protected abstract void AnimacaoProcessamento(double valor);
}