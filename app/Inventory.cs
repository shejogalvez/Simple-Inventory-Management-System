class Inventory
{
    private readonly List<Product> products = [];
    public void AddProduct(string name, string s_price, string s_quantity)
    {
        var p = new Product {Name = name, Price = int.Parse(s_price), Quantity = int.Parse(s_quantity)};
        products.Add(p);
    }
}