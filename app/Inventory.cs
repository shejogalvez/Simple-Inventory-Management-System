class Inventory
{
    private readonly List<Product> products = [];
    public void AddProduct(string name, int price, int quantity)
    {
        var p = new Product {Name = name, Price = price, Quantity = quantity};
        products.Add(p);
    }
    
    public override string ToString() => string.Join("\n", from p in products select p.ToString());
}