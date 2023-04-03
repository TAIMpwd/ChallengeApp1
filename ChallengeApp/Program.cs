int number = 4456;
String numberInString = number.ToString();
char[] letters = numberInString.ToCharArray();

Console.WriteLine("Ilość cyfr danych cyfr w:");
int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;

foreach (char item in letters)
{
    if (item == '0')
    {
        counter0++;
    }
    else if (item == '1')
    {
        counter1++;
    }
    else if (item == '2')
    {
        counter2++;
    }
    else if (item == '3')
    {
        counter3++;
    }
    else if (item == '4')
    {
        counter4++;
    }
    else if (item == '5')
    {
        counter5++;
    }
    else if (item == '6')
    {
        counter6++;
    }
    else if (item == '7')
    {
        counter7++;
    }
    else if (item == '8')
    {
        counter8++;
    }
    else if (item == '9')
    {
        counter9++;
    }

    
}
Console.WriteLine("Cyfr 0 jest:" + counter0);
Console.WriteLine("Cyfr 1 jest:" + counter1);
Console.WriteLine("Cyfr 2 jest:" + counter2);
Console.WriteLine("Cyfr 3 jest:" + counter3);
Console.WriteLine("Cyfr 4 jest:" + counter4);
Console.WriteLine("Cyfr 5 jest:" + counter5);
Console.WriteLine("Cyfr 6 jest:" + counter6);
Console.WriteLine("Cyfr 7 jest:" + counter7);
Console.WriteLine("Cyfr 8 jest:" + counter8);
Console.WriteLine("Cyfr 9 jest:" + counter9);