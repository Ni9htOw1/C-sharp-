using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace РекурсияА_цикл
{
    class Program
    {        
        static void Main(string[] args)
        {
            int k;
            double x;
            вводДанных(out k, out x);
            решениеЗадачи(k, x);
        }
        static void вводДанных(out int k, out double x)
        {
            StreamReader файлВВ = new StreamReader("Inlet.in");
            string строкаВвода = файлВВ.ReadLine();
            string[] арг = строкаВвода.Split(' ');
            k = Convert.ToInt32(арг[0]);
            x = double.Parse(арг[1]);
        }
        static void решениеЗадачи(int k, double x)
        {
            double сумма = рекурсивныйПросчетСуммы(0, k, x, 1);
            StreamWriter файлЫВ = new StreamWriter("Outlet.out");
            файлЫВ.Write(сумма);
            файлЫВ.Close();
        }
        static double рекурсивныйПросчетСуммы(int i, int k, double x, double слагаемое)
        {
            if (i == k)
                return слагаемое;
            else
                return (слагаемое + рекурсивныйПросчетСуммы(i + 1, k, x, Math.Log(3.0) * x * слагаемое / (i + 1)));
        }
    }
}
