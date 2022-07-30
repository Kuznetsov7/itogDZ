Console.WriteLine("Введите координату x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + GetLength(x1,y1,x2,y2));

Double GetLength(int x1, int y1, int x2, int y2)
{
  Double Distance = Math.Sqrt ((x2 - x1)*(x2 - x1) + (y2-y1)*(y2-y1));
  return Distance;
}
