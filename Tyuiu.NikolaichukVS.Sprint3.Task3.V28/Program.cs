using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.NikolaichukVS.Sprint3.Task3.V28.Lib;

namespace Tyuiu.NikolaichukVS.Sprint3.Task3.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Николайчук В. С.| РПСБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнила: Николайчук Валерия Сергеевна | РПСБ-23-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу через цикл do-while, которая вычисляет сумму ряда по *");
            Console.WriteLine("* формуле.                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "f35hyt t4j 3gkg45";
            char c = '3';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + c);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Конечная строка = " + ds.GetReplaceNumOnChar(value, c);

            Console.ReadLine();
        }
    }
}
