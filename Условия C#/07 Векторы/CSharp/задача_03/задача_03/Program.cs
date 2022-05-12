using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace задача_03
{
    /*
     *    Текстовый файл Inlet.in содержит целочисленные значения элементов линейного массива A[1..N].
     *    Выделить те элементы этого массива в массив B, записав их в файл Outlet.out, индексы которых являются 
     * элементами последовательности Фибоначчи, начиная с элемента 0.
     *       Определение. Последовательность чисел Фибоначчи – это последовательность, получаемая по формулам вида:
     *       
     *                /  1, k = 0;    
     *          Fk = <   1, k = 1;  
     *                \  Fk-1 + Fk-2 ; k > 1:
     *                
     *            Спецификация ввода (Inlet.in):
     *               N
     *               Значения элементов массива А
     *               
     *            Спецификация вывода (Outlt.out):
     *               Значения элементов массива В
     */
    class Program
    {
        static StreamReader файлВВ = new StreamReader("Inlet.in");
        static StreamWriter файлЫВ = new StreamWriter("Outlet.out");

        static void Main(string[] args)
        {
            int N = int.Parse(файлВВ.ReadLine().Trim());
            string[] astr = файлВВ.ReadLine().Trim().Split(' ');
            int F_1 = 1, F_2 = 1, F = F_1 + F_2;
            string строкаОтвета = astr[0]+" "+astr[0];
            while (F <= N)
            {
                строкаОтвета = строкаОтвета +" "+astr[F-1];
                F_2 = F_1;
                F_1 = F;
                F = F_1 + F_2;
            }
            файлЫВ.Write(строкаОтвета.Trim());
            файлЫВ.Close();
        }
    }
}
