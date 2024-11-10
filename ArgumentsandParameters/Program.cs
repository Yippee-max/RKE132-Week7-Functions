

//PrintAnyWord(); () utleb et pane function toole

Console.WriteLine("Enter a word");
string userInput = Console.ReadLine();

PrintAnyWord(userInput); // userInput on argument

static void PrintAnyWord(string anyString) // () sulgude sees defineerib mida teeb // anyString parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }
}
