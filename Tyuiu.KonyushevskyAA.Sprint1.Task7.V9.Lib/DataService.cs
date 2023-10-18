using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Exp(x) - ((y*y) + (Math.Cos(Math.Pow(x, 3)) + (12 * x * y) - 3 * (x*x))) / (( Math.Cos((Math.Pow(x, 3)) + 3)) + 18 * y - 1);
            res = Math.Round(res, 3);
            return res;

            
        }
    }
}
