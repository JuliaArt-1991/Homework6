/* 41

Console.Clear();
Console.Write("Введите значения через пробел: ");
int[] n = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int summa = 0;
for (int i = 0; i < n.Length; i++)
{
    if (n[i] > 0)
    {
        summa++;
    }
}
Console.WriteLine($"Количество значений > 0: {summa}"); 
*/

/* 43

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})"); 
*/

/* Площадь треугольника

Console.Write("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double S = Math.Abs(Math.Round((((double)(x1-x3)*(y2-y3)- (x2-x3)*(y1-y3)) * 1/2), 2));

Console.WriteLine($"Площадь: {S}"); 
*/