KratnoeChislo(161);
KratnoeChislo(16);
KratnoeChislo(41);


void KratnoeChislo(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine("Число " + number + " является кратным 7 и 23");
    }
    else
    {
        Console.WriteLine("Число " + number + " не является кратным 7 и 23");
    }
}


