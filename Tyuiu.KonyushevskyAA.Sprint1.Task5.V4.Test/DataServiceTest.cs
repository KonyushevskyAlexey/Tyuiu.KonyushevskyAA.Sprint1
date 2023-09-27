using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            int sec = 12345;
            DataService NEWCALASS = new DataService();
            int hour = NEWCALASS.SecondsToHours(sec);

            int wait = 3;

            Assert.AreEqual(wait, hour);
        }
    }
}
