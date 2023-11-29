namespace csharp_poo;

public class Item(string name, int q=1, decimal p=1M)
{
    public string Name { get; set; } = name;
    
    private int _quantity = q;
    public int Quantity {
        get { return _quantity; }
        set {
            if (value <= 0) {
                _quantity = 1;
            }
            _quantity = value;
        }
    }

    private decimal _price = p;
    public decimal Price {
        get { return _price; }
        set {
            if (value <= 0) {
                _price = 1M;
            }
            _price = value;
        }
    }

    public static string Info() {
        return "this is a class that create a item";
    }
}
