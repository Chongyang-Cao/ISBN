static void cnvBinary1(int a)
{
    while (a != 0)
    {
        Console.WriteLine(a%2);
        a = a / 2;
    }
}
//Console.WriteLine("What number to turn into binary?");
//int a = Convert.ToInt32(Console.ReadLine());
//cnvBinary1(a);

static void cnvBinary2(int a)
{
    List<int> list = new List<int>();
    while (a != 0)
    {
        list.Add(a % 2);
        a = a / 2;
        //Console.WriteLine(a%2);
        //Console.WriteLine(list.Count);
    }
    list.Reverse();
    Console.WriteLine(string.Join("", list));
}
//Console.WriteLine("What number to turn into binary?");
//int b = Convert.ToInt32(Console.ReadLine());
//cnvBinary2(b);