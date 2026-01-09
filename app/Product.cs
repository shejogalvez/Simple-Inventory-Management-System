class Product
{
    public string Name = "";
    public int Price;
    public int Quantity;

    public override string ToString() => $"{Name}: price = {Price}, quantity = {Quantity}";

    public void Update(string new_name, int new_price, int new_quantity)
    {
        Name = new_name;
        Price = new_price;
        Quantity = new_quantity;
    }
}