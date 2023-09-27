using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.KonyushevskyAA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string phrase = "Alexey Okey Yamakasi Okey";
            bool res = ds.CheckLastWordRepetiton(phrase);
            bool wait = true;

            Assert.AreEqual(wait, res);




        }
    }
}
