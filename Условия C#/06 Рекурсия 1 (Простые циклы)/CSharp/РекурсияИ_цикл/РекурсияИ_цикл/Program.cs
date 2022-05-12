using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace РекурсияИ_цикл
{
    class Program
    {
        /*
         *    Решить уравнение вида
         *             ___
         *      3 sin\/ x  +0.35 x -3.8 = 0,
         *      
         *   методом Ньютона, если известно, что корень уравнения находится на отрезке [2, 3]
         *   с контролем за окончанием вычислений по малости невязки.
         *       Спецификация ввода (файл Inlet.in)
         *          a b точность
         *       Спецификация вывода (файл Outlet.out)
         *          решение
         *          
         */ 
        static void Main(string[] args)
        {
            double a, b, точность;
            вводДанныхИзФайла(out a, out b, out точность);
            выводРезультатаВФайл(решениеЗадачи(a, b, точность));
        }
        static void выводРезультатаВФайл(double решение)
        {
            StreamWriter файлOutlet = new StreamWriter("Outlet.out");
            файлOutlet.Write(решение);
            файлOutlet.Close();
        }
        static double решениеЗадачи(double a, double b, double точность)
        {
            double x = начальноеПриближение(a, b);
            return методНьютона(x, точность);
        }
        static double методНьютона(double x, double точность)
        {
            if (Math.Abs(f(x)) < точность)
                return x;
            else
                return методНьютона(x - f(x) / производнаяf(x), точность);
        }
        static double f(double x)
        {
            return 3 * Math.Sin(Math.Sqrt(x)) + 0.35 * x - 3.8;
        }
        static double производнаяf(double x)
        {
            return 1.5 * Math.Cos(Math.Sqrt(x)) / Math.Sqrt(x) + 0.35;
        }
        static double втораяПроизводнаяf(double x)
        {
            return -0.75 * (Math.Sqrt(x) * Math.Sin(Math.Sqrt(x)) + Math.Cos(Math.Sqrt(x))) / (x * Math.Sqrt(x));
        }
        static double начальноеПриближение(double a, double b)
        {
            return f(a) * втораяПроизводнаяf(a) > 0 ? a : b;
        }
        static void вводДанныхИзФайла(out double a, out double b, out double точность)
        {
            StreamReader файлInlet = new StreamReader("Inlet.in");
            string[] аргументы = файлInlet.ReadLine().Split(' ');
            a = Convert.ToDouble(аргументы[0]);
            b = Convert.ToDouble(аргументы[1]);
            точность = Convert.ToDouble(аргументы[2]);
        }
    }
}
