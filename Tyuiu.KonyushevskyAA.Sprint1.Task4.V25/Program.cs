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
