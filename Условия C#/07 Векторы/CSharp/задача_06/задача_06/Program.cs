using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace задача_06
{
    /*
     *    Текстовый файл Inlet.in содержит целочисленные значения элементов линейного массива A[1..N].
     *    Определить, количество таких чисел этого массива, записав это число в файл Outlet.out, которые являются 
     * положительными числами.
     * 
     *           Спецификация ввода : (Inlet.in)
     *              N
     *              Значения элементов массива А (в строку)
     *              
     *           Спецификация вывода:
     *              Количество положительных элементов массива А
     */
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader файлВВ = new StreamReader("Inlet.in");
            StreamWriter файлЫВ = new StreamWriter("Outlet.out");
            int n = int.Parse(файлВВ.ReadLine());
            char[] разделители = { ' ' };
            string[] astr = файлВВ.ReadLine().Split(разделители, StringSplitOptions.RemoveEmptyEntries);
            int количество = 0;
            for (int i = 0; i < astr.Length; i++)
            {
                количество += int.Parse(astr[i]) > 0 ? 1 : 0;
            }
            файлЫВ.Write(количество);
            файлЫВ.Close();
        }
    }
}
