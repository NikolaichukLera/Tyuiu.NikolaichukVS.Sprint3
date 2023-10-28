﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint3.Task2.V29.Lib;

namespace Tyuiu.NikolaichukVS.Sprint3.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 0.5;
            int startValue = 1;
            int stopValue = 18;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = -0.186;

            Assert.AreEqual(wait, res);
        }
    }
}
