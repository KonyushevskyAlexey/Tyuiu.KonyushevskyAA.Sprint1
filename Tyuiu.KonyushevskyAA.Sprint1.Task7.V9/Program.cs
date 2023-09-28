using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint1.Task7.V9.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task7.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Конюшевский А.А  | ИИПБ-23-2";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема:  Базовые навыки работы в C#                                      *");
            Console.WriteLine("* Задание #7                                                             *");
            Console.WriteLine("* Вариант #9                                                             *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу , которая вычисляет математическое выражение по     *");
            Console.WriteLine("* исходным значениям данных , вводимых полтзователем . Ответ округлить   *");
            Console.WriteLine("* до 3 знаков после запятой                                              *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("            2      3            2                                         ");
            Console.WriteLine("     x    y  + cosx  + 12xy - 3x                                          ");                   
            Console.WriteLine("z = e  - --------------------------                                       ");
            Console.WriteLine("               3                                                          ");
            Console.WriteLine("          cos(x  + 3) + 18y - 1                                           ");

            double x, y;

            Console.WriteLine("Введите значение Х:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");


            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadKey();

        }
    }
}
