while (true)
{
    Console.WriteLine("write instruction:");

    var instruction = Console.ReadLine();
    if (instruction == null)
    {
        Console.WriteLine("Write something!!");
        continue;
    }
    instruction = instruction.Trim();
    switch (instruction)
    {
    case "add":
        Console.WriteLine("add not implemented");
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