namespace csharp_poo.pagamento;

public class PagamentoBoleto : IPagamento
{
    public void Processar(Carrinho carrinho)
    {
        Console.WriteLine($"Gerando boleto do carrinho no valor total de: { carrinho.ValorTotalFormatado }");
        Console.WriteLine("Boleto gerado com sucesso!");
    }
}