using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NikolaichukVS.Sprint3.Task3.V28.Lib;



namespace Tyuiu.NikolaichukVS.Sprint3.Task3.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string value = "f35hyt t4j 3gkg45";
            char c = '3';
           

            int res = ds.GetReplaceNumOnChar(value, c);

            string wait = "frrhyt trj rgkgrr";

            Assert.AreEqual(wait, res);

        }
    }
}
