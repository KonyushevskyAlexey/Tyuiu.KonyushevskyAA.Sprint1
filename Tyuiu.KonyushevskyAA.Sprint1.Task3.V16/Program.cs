using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint1.Task3.V16.Lib;


namespace Tyuiu.KonyushevskyAA.Sprint1.Task3.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

          
            Console.WriteLine("Введите первый корень:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй корень:");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Коэффицент приведенного квадратного уравнения = " + ds.CoeffOfQuadraticEquation(x1,y2));

            Console.ReadKey();
        }
    }
}
