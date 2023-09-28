using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint1.Task7.V9.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 1;
            double wait = 18;
            var res = ds.Calculate(x, y);
       
            Assert.AreEqual(wait, res);

        }
    }
}
