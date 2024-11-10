Console.WriteLine("Enter the operation (+/-):");
char userOperator = Char.Parse(Console.ReadLine());

Console.WriteLine("Enter number a:");
int FirstNum= Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter number b:");
int SecondNum = Int32.Parse(Console.ReadLine());

switch (userOperator)
{
    case '+':
        Addition(FirstNum, SecondNum);
        break;
    case '-':
        Subtraction(FirstNum, SecondNum);
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}
static void Addition(int a, int b) // functionis saab olla mitu vaartusi
{
    Console.WriteLine($"{a} + {b} = {a + b}");
}

static void Subtraction(int a, int b) 
{
    Console.WriteLine($"{a} - {b} = {a - b}");
}
