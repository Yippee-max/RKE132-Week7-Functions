

Console.WriteLine("Vali kas teisendadakse Fahrenheit or Celsiust teise temperatuuriskaalasse ( F or C )");
char userTemp = Char.Parse(Console.ReadLine());
{
    if (userTemp == 'F')
    {
        Console.WriteLine("Sisesta Fahrenheiti väärtuse numbrides");
    }
    else
    {
        Console.WriteLine("Siseta Celsius väärtuse numbrides");
    }
}
//esitatud on float kujul kuna väärtus tuleb välja täpsemana kui string
float userNumber = float.Parse(Console.ReadLine());

switch (userTemp)
{
    case 'F':
        ConvertToFahrenheit(userNumber);
        break;
    case 'C':
        ConvertToCelsius(userNumber);
        break;
    default:
        Console.WriteLine("Mitte sobiv väärtus, valige kas F or C");
        break;
}

static void ConvertToFahrenheit(float celsius)
{
    Console.WriteLine($"{celsius} Celsius väärtus Fahrenheitis on: {(celsius - 32) * 5 / 9}");
}
static void ConvertToCelsius(float fahrenheit)
{
    Console.WriteLine($"{fahrenheit} Fahrenheit väärtus Celsiuses on: {(fahrenheit * 9) / 5 + 32}");
}
