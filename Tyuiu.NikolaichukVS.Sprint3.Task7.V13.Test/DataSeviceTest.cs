using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint3.Task7.V13.Lib;

namespace Tyuiu.NikolaichukVS.Sprint3.Task7.V13.Test
{
    [TestClass]
    public class DataSeviceTest
    {
        [TestMethod]
        public void ValitGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 3.63;
            valueWaitArray[1] = -17.12;
            valueWaitArray[2] = -11.03;
            valueWaitArray[3] = -9.81;
            valueWaitArray[4] = -0.15;
            valueWaitArray[5] = 1.00;
            valueWaitArray[6] = 2.15;
            valueWaitArray[7] = 11.81;
            valueWaitArray[8] = 13.03;
            valueWaitArray[9] = 19.12;
            valueWaitArray[10] = -1.63;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
            

        }
    }
}
