static double HCF(double number1, double number2)
{
    double temp1 = number1;
    double temp2 = number2;
    while (temp1 != temp2)
    {
        if (temp1 > temp2)
        {
            temp1 = temp1 - temp2;
        }
        else
        {
            temp2 = temp2 - temp1;
        }
    }
    return temp1;
}
Console.WriteLine("Enter a whole number");
double number1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter another whole number");
double number2 = Convert.ToDouble(Console.ReadLine());
double result = HCF(number1, number2);
Console.WriteLine($"{result} is the HCF of {number1} and {number2}");