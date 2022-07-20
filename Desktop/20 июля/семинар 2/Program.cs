int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (b % a == 0) 
{
    Console.WriteLine("Число "+ b +" кратно числу"+ a);
}
else
{
    Console.WriteLine("Число "+ b +" не кратно числу "+ a +" , остаток от деления "+ (b % a));
}
