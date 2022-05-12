﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Пример_решения_задачи_по_теме_Строки
{
    /*   Дан текстовый файл Inlet.in, содержащий строковые величины S. В последней его строке 
     * находится символьная величина Symbol.
     *   Подсчитать число вхождений указанного символа, в предпоследние слова введенных литерных величин. 
     * Если этого сделать нельзя, значением результата положить –1.
     * 
     *     Определение. Слово - это последовательность символов строковой величины, не содержащая в себе символ пробела.
     *     
     *     Спецификация ввода (файл Inlet.in):
     *        Строковая величина
     *        Строковая величина
     *        . . . . . . . . . . . . . . . . . . . . .
     *        Строковая величина
     *        Символьная величина
     *     Спецификация вывода (файл Outlet.out):
     *        Количество вхождений или -1
     * 
     */ 
    class Program
    {
        static StreamReader ФайлIn = new StreamReader("1.in");
        static StreamWriter ФайлOut = new StreamWriter("outlet.out");
        
        static void Main(string[] args)
        {
            int N;
            string[] предпоследнееСловоСтроки;
            char буква;
            вводДанных(out N, out предпоследнееСловоСтроки, out буква);
            int количествоВхождений = подсчетБукв(предпоследнееСловоСтроки, буква);
            ФайлOut.Write(количествоВхождений);
            ФайлOut.Close();
        }
        static int подсчетБукв(string[] предпоследнееСловоСтроки, char буква)
        {
            int количество = -1;
            foreach (string слово in предпоследнееСловоСтроки)
                if (слово == "null") // Ничего делать не надо
                {
                }
                else // Подсчет букв
                {
                    if (количество==-1) количество=0;
                    foreach (char букваСлова in слово)
                        количество += буква == букваСлова ? 1 : 0;
                }
            return количество;
        }
        static int количествоПредложений(string текст)
        {
            int количество = 0, индексКонцаСтроки = текст.IndexOf("\r\n");
            while (индексКонцаСтроки != -1)
            {
                количество++;
                индексКонцаСтроки = текст.IndexOf("\r\n", индексКонцаСтроки + 1);
            }
            return количество;
        }
        static void вводДанных(out int N, out string[] слова, out char буква)
        {
            string текст = ФайлIn.ReadToEnd(); 
            string предложение;
            N = количествоПредложений(текст) - 1;
            слова = new string[N];
            int индексРазделителяСтрок = текст.IndexOf("\r\n");
            for (int i = 0; i < N; i++)
            {
                предложение = текст.Substring(0, индексРазделителяСтрок).Trim();
                текст = текст.Remove(0, индексРазделителяСтрок + 2);            // Удаление выделенного предложения
                int последнийПробел = предложение.LastIndexOf(' ');
                if (последнийПробел != -1)                                    // В предложении не менее 2-х слов
                {
                    предложение = предложение.Remove(последнийПробел).Trim();
                    последнийПробел = предложение.LastIndexOf(' ');
                    if (последнийПробел == -1)                                // В предложении только 2-а слова
                        слова[i] = предложение;
                    else                                                      // В предложении более 2-х слов
                    {
                        последнийПробел = предложение.LastIndexOf(' ');
                        слова[i] = предложение.Substring(последнийПробел + 1);
                    }
                }
                else                                                          // В предложении только одно слово
                    слова[i] = "null";
                индексРазделителяСтрок = текст.IndexOf("\r\n");
            }
            char[] буквы = текст.Substring(0, 1).ToCharArray();
            буква = буквы[0];
            ФайлIn.Close();
        }
    }
}
