Inventory inventory = new ();
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
    string? input;
    string[] arguments;
    switch (instruction)
    {
    case "add":
        Console.WriteLine("write name, price and quantity separated by commas:");
        input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Write something!!");
            continue;
        }
        arguments = input.Split(",");
        inventory.AddProduct(arguments[0], arguments[1], arguments[2]);
        Console.WriteLine("Product added");
        break;
    case "list":
        Console.WriteLine("list not implemented");
        break;
    case "edit":
        Console.WriteLine("edit not implemented");
        break;
    case "delete":
        Console.WriteLine("delete not implemented");
        break;
    case "search":
        Console.WriteLine("search not implemented");
        break;
    case "exit":
        Console.WriteLine("exit not implemented");
        break;
    default:
        Console.WriteLine("unrecognized instruction");
        break;

    };
}