string ISBN = "15?881111X";
double thing = 10;
double total = 0;
double mdigit = 0;
double num = 0;
for (int i = 0; i < 10; i++)
{
    string digit = ISBN[i].ToString();
    thing = 10 - i;
    if (digit == "?")
    {
        mdigit = i;
    }
    else
    {
        if (digit == "X")
        {
            total += (thing * 10);
        }
        else
        {
            num = Convert.ToDouble(digit);
            total += (thing * num);
        }
    }
}
double f = total % 11;
Console.WriteLine((11 - f) / mdigit);


//ISBN = "9514451570";
//thing = 10;
//total = 0;
//mdigit = 0;
//num = 0;
//for (int i = 0; i < 10; i++)
//{
//    string digit = ISBN[i].ToString();
//    thing = 10 - i;
   
//    if (digit == "X")
//    {
//        total += (thing * 10);
//    }
//    else
//    {
//        num = Convert.ToDouble(digit);
//        total += (thing * num);
//    }

//}
//Console.WriteLine(total%11);