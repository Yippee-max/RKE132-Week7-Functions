Console.WriteLine("Are you coming or leaving (in/out)");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else if (userChoice == "out")
{
    PrintGoodBye();
}
static void PrintHello() // function / method
{
    Console.WriteLine("Hello, World!");
}

static void PrintGoodBye()
{
    Console.WriteLine("Ciao!");
}
