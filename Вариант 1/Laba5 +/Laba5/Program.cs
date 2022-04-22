using static System.Math;
Console.WriteLine("Введите x, точность:");
double x = .0;
double e = .0;
x = Convert.ToDouble(Console.ReadLine());
e = Convert.ToDouble(Console.ReadLine());
double s = .0;
double sl = 1.0;
int n = 0;
while (Abs((2 * n + 1) * sl) > e)
{
	s += (2 * n + 1) * sl;
	n++;
	sl *= (x * x / n);
}
Console.WriteLine($"Сумма:{s}");

