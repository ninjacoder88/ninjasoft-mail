Console.WriteLine("Welcome to Ninjasoft Mail");

Console.Write("username: ");
string? username = Console.ReadLine();
Console.Write("password: ");
string? password = Console.ReadLine();

while(true)
{
    Console.WriteLine("1. Check Mail");
    Console.WriteLine("2. Send Mail");
    Console.WriteLine("3. Exit");
    Console.Write("Select an option: ");

    string? input = Console.ReadLine();
    if(string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid input. Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        continue;
    }
    if(!int.TryParse(input, out int option))
    {
        Console.WriteLine("Invalid input. Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        continue;
    }
    if(option < 1 || option > 3)
    {
        Console.WriteLine("Invalid input. Press any key to continue");
        Console.ReadLine();
        Console.Clear();
        continue;
    }
    if(option == 3)
    {
        Console.WriteLine("Goodbye");
        return;
    }
}