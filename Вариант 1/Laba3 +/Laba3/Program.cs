Console.WriteLine("Введите k, x:");
int k = Convert.ToInt32(Console.ReadLine());
double x = Convert.ToDouble(Console.ReadLine());
double sl = 1.0;
double s = .0;
for (int n = 1; n < k + 1; n++)
{
    s += sl;
    sl = sl * x * (Math.Log(3) / n);
}
Console.WriteLine($"Сумма: {s}");
