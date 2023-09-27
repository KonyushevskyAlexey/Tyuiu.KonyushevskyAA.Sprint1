using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1; 

namespace Tyuiu.KonyushevskyAA.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string value)
        {
            string[] words = value.Split(' ');
            string lastword = words.Last();
            int count = 0;
            foreach (string word in words)
            {
                if (word == lastword) { count++; }
            }
            if (count > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
