using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

 
namespace Tyuiu.NikolaichukVS.Sprint3.Task6.V19.Lib
{
    public class DataService : ISprint3Task6V19
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int sum = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= 8; d++)
                {
                    if (x % d == 0)
                    {
                        sum += d;
                    }
                }
            }
            return sum;
        }

    }
}
