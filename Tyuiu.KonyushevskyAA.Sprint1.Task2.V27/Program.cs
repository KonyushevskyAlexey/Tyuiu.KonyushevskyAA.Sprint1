using System;
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
