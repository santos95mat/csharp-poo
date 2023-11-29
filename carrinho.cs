namespace csharp_poo;

public class Carrinho {
    private readonly IList<Item> _itens = [];

    public IEnumerable<Item> Itens{
        get { return _itens.AsEnumerable(); }
    }

    public int TotalItens => _itens.Sum(x => x.Quantity);
    public decimal ValorTotal => _itens.Sum(x => x.Price * x.Quantity);
    public string ValorTotalFormatado => ValorTotal.ToString("C");

    public void AddItem(Item item) {
        if (item == null) {
            throw new ArgumentException("Item");
        }

        _itens.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _itens.Remove(item);
    }

    public override string ToString()
    {
        return $"Qtd Itens: {TotalItens} | Total: {ValorTotalFormatado}";
    }
}
