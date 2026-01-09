class Inventory
{
    private readonly List<Product> products = [];
    public bool AddProduct(string name, int price, int quantity)
    {
        if (FindProductByName(name) is not null) return false;

        var p = new Product { Name = name, Price = price, Quantity = quantity };
        products.Add(p);
        return true;
    }

    public override string ToString() => string.Join("\n", from p in products select p.ToString());

    public Product? FindProductByName(string name) => products.Find(p => p.Name.Equals(name));

    // List.Remove allow null as input but throws warning anyways??
    public bool deleteProductByName(string name)
    {
        var index = products.FindIndex(p => p.Name.Equals(name));
        if (index >= 0)
        {
            products.RemoveAt(index);
            return true;
        }
        return false;
    }
}