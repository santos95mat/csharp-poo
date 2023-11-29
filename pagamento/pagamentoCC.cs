namespace csharp_poo.pagamento;

public class PagamentoCC : IPagamento
{
    public void Processar(Carrinho carrinho)
    {
        Console.WriteLine($"Realizando pagamento do carrinho no valor total de: { carrinho.ValorTotalFormatado }");
        Console.WriteLine("Pagamento com cartão de crédito efetuado com sucesso!");
    }
}