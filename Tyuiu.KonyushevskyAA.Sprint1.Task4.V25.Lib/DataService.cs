using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task4.V25.Lib
{
    public class DataService : ISprint1Task4V25
    {
        public double Calculate(double a)
        {
            var res = (1 - (Math.Cos(a)))/(Math.Sin(a) * Math.Sin(a));
            return res;
        }
    }
}
