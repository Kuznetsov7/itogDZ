Console.WriteLine("Введите координату x1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату r1: ");
int r1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату y2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату r2: ");
int r2 = int.Parse(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + Math.Round(GetLength(x1,y1,r1,x2,y2,r2),2));

Double GetLength(int x1, int y1, int r1, int x2, int y2, int r2)
{
  Double Distance = Math.Sqrt ((x2 - x1)*(x2 - x1) + (y2-y1)*(y2-y1) + (r2 - r1)*(r2 - r1));
  return Distance;
}
