﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint1.Task2.V27.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task2.V27
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
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #27                                                            *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович | ИИПБ-23-2                *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу , которая запрашивает у пользователя исходные денные*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране             *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Квадрат числа X = " + ds.CalculateSquarePerimetr(x));

            Console.ReadLine();
        }
    }
}
