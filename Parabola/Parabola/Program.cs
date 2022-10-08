using System.Drawing;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    static string coords(decimal x, decimal y)
    {
        decimal p = 0.9m * x * x + 1.3m * x - 0.7m;
        if (p == y)
            return "True";
        else
            return "False";
    }
    private static void Main(string[] args)
    {
        string g = coords(1, (decimal)1.5);
        Console.WriteLine(g);
    }
}
