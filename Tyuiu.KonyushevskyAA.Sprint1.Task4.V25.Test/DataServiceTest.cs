﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint1.Task4.V25.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            double wait = (1 - (Math.Cos(a))) / (Math.Sin(a) * Math.Sin(a));
            var res = ds.Calculate(a);
            Assert.AreEqual(wait, res);
               
        }
    }
}
