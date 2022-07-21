Console.WriteLine("Введите первое число");
int First = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int Second = int.Parse(Console.ReadLine());

if(IsSqr(First, Second))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}


bool IsSqr (int num1, int num2)
{
    if(num1 * num1 == num2 || num2 * num2 == num1)
{
    return true;
}
else
{
    return false;
}
}