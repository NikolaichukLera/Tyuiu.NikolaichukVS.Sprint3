﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint3.Task0.V4.Lib;

namespace Tyuiu.NikolaichukVS.Sprint3.Task0.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();


            int startValue = 1;
            int stopValue = 7;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = 6482.439;

            Assert.AreEqual(wait, res);

        }
    }
}
