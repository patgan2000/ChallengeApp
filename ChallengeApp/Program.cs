int No = 2759071;
string NoInString = No.ToString();
char[] letters = NoInString.ToCharArray();
Console.WriteLine("To twoja liczba: " + No);
int number0 = 0;
int number1 = 0;
int number2 = 0;
int number3 = 0;
int number4 = 0;
int number5 = 0;
int number6 = 0;
int number7 = 0;
int number8 = 0;
int number9 = 0;

foreach (char x in letters)
{
    if (x == '0')
    {
        number0++;
    }
    else if (x == '1')
    {
        number1++;
    }
    else if (x == '2')
    {
        number2++;
    }
    else if (x == '3')
    {
        number3++;
    }
    else if (x == '4')
    {
        number4++;
    }
    else if (x == '5')
    {
        number5++;
    }
    else if (x == '6')
    {
        number6++;
    }
    else if (x == '7')
    {
        number7++;
    }
    else if (x == '8')
    {
        number8++;
    }
    else if (x == '9')
    {
        number9++;
    }
}
Console.WriteLine("0 => " + number0);
Console.WriteLine("1 => " + number1);
Console.WriteLine("2 => " + number2);
Console.WriteLine("3 => " + number3);
Console.WriteLine("4 => " + number4);
Console.WriteLine("5 => " + number5);
Console.WriteLine("6 => " + number6);
Console.WriteLine("7 => " + number7);
Console.WriteLine("8 => " + number8);
Console.WriteLine("9 => " + number9);