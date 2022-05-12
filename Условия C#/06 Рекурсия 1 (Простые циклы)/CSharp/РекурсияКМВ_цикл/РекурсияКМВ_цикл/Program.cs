using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace РекурсияКМВ_цикл
{
    /*    Найти сумму, закончив просчеты, как только абсолютная величина слагаемого станет
     * меньше величины переменной "точность":
     *                      5*x^4     7*x^6 
     *      S = 1 + 3x^2 + ------- + ------- + ...
     *                        2         6
     *     Спецификация ввода :
     *          x точность
     *     Спецификация вывода:
     *          значение суммы
     */
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double точность;
            вводДанных(out x, out точность);
            решениеЗадачи(x, точность);
        }
        static void вводДанных(out double x, out double точность)
        {
            StreamReader файлВВ = new StreamReader("Inlet.in");
            string строкаВвода = файлВВ.ReadLine();
            string[] арг = строкаВвода.Split(' ');
            x = double.Parse(арг[0]);
            точность = double.Parse(арг[1]);
        }
        static void решениеЗадачи(double x, double точность)
        {
            double сумма = рекурсивноеВычислениеСуммы(1, 0, точность, x);
            StreamWriter файлЫв = new StreamWriter("Outlet.out");
            файлЫв.Write(сумма);
            файлЫв.Close();
        }
        static double рекурсивноеВычислениеСуммы(double слагаемое, int n, double точность, double x)
        {
            if (Math.Abs(слагаемое * (2 * n + 1)) <= точность)
                return 0;
            else
                return слагаемое * (2 * n + 1) + рекурсивноеВычислениеСуммы(слагаемое * x * x / (n + 1), n + 1, точность, x);
        }
    }
}