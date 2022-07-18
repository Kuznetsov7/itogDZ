/* 
Напишите программу,которая выдает случайные числа из отрезка [10, 99] и показывает цифру числа

78 -> 8
12 -> 2
85 -> 8
*/

int num = new Random().Next(10, 100);
Console.WriteLine("Random number: " + num);

int firstDigit = num / 10;
int secondDigit = num % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine("Max number is " + firstDigit);
}
else
{
    Console.WriteLine("Max number is " + secondDigit);
}

int getMax(int a, int b)
{
 if (a > b)
 {
    return a;
 }
 else
 {
    return b;
 }
}
