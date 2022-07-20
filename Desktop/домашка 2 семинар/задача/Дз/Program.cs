Console.Write("Enter number: ");
int num = int.Parse(Console.ReadLine());

if ( num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while ( num > 999)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.WriteLine("Result: " + num);
}