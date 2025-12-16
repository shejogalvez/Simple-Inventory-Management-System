Inventory inventory = new();
while (true)
{
    Console.WriteLine("\nwrite instruction:");

    var instruction = Console.ReadLine();
    if (instruction == null)
    {
        Console.WriteLine("Write something!!");
        continue;
    }
    instruction = instruction.Trim();
    Tuple<string, int, int>? arguments;
    switch (instruction)
    {
        case "add":
            arguments = getArgumentsFromUser();
            if (arguments is null) continue;
            var res = inventory.AddProduct(arguments.Item1, arguments.Item2, arguments.Item3);
            if (res) Console.WriteLine("Product added");
            else Console.WriteLine($"Product {arguments.Item1} is already in the inventory");
            break;
        case "list":
            Console.WriteLine("Current products:");
            Console.WriteLine(inventory.ToString());
            break;
        case "edit":
            Console.WriteLine("Enter name of the product:");
            string name = Console.ReadLine() ?? "";
            Product? p = inventory.FindProductByName(name);
            if (p is null)
            {
                Console.WriteLine("Product not found");
                continue;
            }
            arguments = getArgumentsFromUser();
            if (arguments is null) continue;
            p.Update(arguments.Item1, arguments.Item2, arguments.Item3);
            Console.WriteLine("Product updated");
            break;
        case "delete":
            Console.WriteLine("Enter name of the product to delete:");
            name = Console.ReadLine() ?? "";
            bool result = inventory.deleteProductByName(name);
            if (result) Console.WriteLine($"{name} was deleted");
            else Console.WriteLine($"{name} was not found");
            break;
        case "search":
            Console.WriteLine("Enter name of the product:");
            name = Console.ReadLine() ?? "";
            p = inventory.FindProductByName(name);
            Console.WriteLine(p is not null ? p.ToString() : "Product not found");
            break;
        case "exit":
            Console.WriteLine("exit not implemented");
            break;
        default:
            Console.WriteLine("unrecognized instruction");
            break;

    }
}

Tuple<string, int, int>? getArgumentsFromUser()
{
    Console.WriteLine("write name, price and quantity separated by commas:");
    string input = Console.ReadLine() ?? "";
    string[]? arguments = input.Split(",");
    if (arguments.Length != 3)
    {
        Console.WriteLine("three arguments are expected");
        return null;
    }
    return new Tuple<string, int, int>(arguments[0], int.Parse(arguments[1]), int.Parse(arguments[2]));
}