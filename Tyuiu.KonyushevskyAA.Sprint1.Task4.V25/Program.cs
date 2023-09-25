using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint1.Task4.V25.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task4.V25
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
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #25                                                            *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу , которая запрашивает у пользователя исходные данные*");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экран                 *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            
            double alpha;

            Console.Write("Введите значение угла alpha в градусах: ");

            if (double.TryParse(Console.ReadLine(), out alpha))
            {
                double alphaRadians = Math.PI * alpha / 180.0; // Переводим угол из градусов в радианы
                double cosAlpha = Math.Cos(alphaRadians);
                double sinAlpha = Math.Sin(alphaRadians);

                if (sinAlpha != 0)
                {
                    double result = 1 - cosAlpha / (sinAlpha * sinAlpha);
                    Console.WriteLine($"Результат вычислений: {result}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Знаменатель равен нулю (sin^2(alpha) = 0).");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: Введите числовое значение угла alpha.");
            }

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("1 - (Math.Cos(a)) / (Math.Sin(a) * Math.Sin(a)) = " + ds.Calculate(alpha));

            Console.ReadKey();


        }
    }
}
