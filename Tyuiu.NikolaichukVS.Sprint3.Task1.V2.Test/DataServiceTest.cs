﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint3.Task1.V2.Lib;

namespace Tyuiu.NikolaichukVS.Sprint3.Task1.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(startValue, stopValue);

            double wait = 0;

            Assert.AreEqual(wait, res);
        }
    }
}
