// kui summa vaiksem kui < 10 on allahindlus - 1%
// total >= 10 && 20 < (&& on vahemik) - 5%
// total >= 20 - 10 %

// void eemaldab functioni parast kasutamist

Console.WriteLine("Provide total:");
int userInput = Int32.Parse (Console.ReadLine());

double discount  = DiscountCalculator(userInput);

Console.WriteLine($"Your discount is {discount} %");

double NewTotal = CalculateNewTotal(userInput, discount);

Console.WriteLine($"Your updated total with {discount}% is {NewTotal}");

static double DiscountCalculator(int total) // double salvestab andmeid
{
    if (total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total < 20)
    {
        return 5;
    }
    else
    {
        return 10;
    }
}

static double CalculateNewTotal(double total, double discount) // mõlema function totalid ei ole sama
{
    double result = total - (total  * discount) / 100;
    return result;
}
