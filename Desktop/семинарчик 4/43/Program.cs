Console.Write("Введите число: ");
int NumberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int NumberN)
{ 
  int count = Convert.ToString(NumberN).Length;
  int a = 0;
  int res = 0;
  for (int i = 0; i < count; i++)
  {
    a = NumberN - NumberN % 10;
    res = res + (NumberN - a);
    NumberN = NumberN / 10;
      }
      return res;
}
int sumNumber = SumNumber(NumberN);
Console.WriteLine("Сумма цифр: " + sumNumber);
