class Product
{
    public string Name = "";
    public int Price;
    public int Quantity;

    public override string ToString() => $"{Name}: price = {Price}, quantity = {Quantity}";
}