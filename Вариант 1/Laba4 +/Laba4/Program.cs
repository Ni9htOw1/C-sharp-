using static System.Math;
double fun, pr1, pr2, toch, x;
int a,b, prib;
double f(double x)
{
	fun = 3 * Sin(Sqrt(x)) + 0.35 * x - 3.8;
	return fun;
}
double fpr1(double x)
{
	pr1 = 1.5 * Cos(Sqrt(x)) / Sqrt(x) + 0.35;
	return pr1;
}
double fpr2(double x)
{
	pr2 = -0.75 * (Sqrt(x) * Sin(Sqrt(x)) + Cos(Sqrt(x))) / (x * Sqrt(x));
	return pr2;
}
int priblig(int a, int b)
{
	if (f(a) * fpr2(a) > 0) prib = a;
	else prib = b;
	return prib;
}
Console.WriteLine("Введите: a, b, точность:");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
toch = Convert.ToDouble(Console.ReadLine());
x = priblig(a, b);
while (Abs(f(x)) > toch)
{
	x -= f(x) / fpr1(x);
}
Console.WriteLine(x);
