using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public class Fibonacci
    {
        /// <summary>
        /// Calculate Fibonacci algorithm
        /// </summary>
        /// <param name="numberOfCalculate">Number of algorithm you want to calculate</param>
        /// <returns>Return all sentences of Fibonacci algorithm</returns>
        public static int[] CalculateFibonacciAlgorithm(int numberOfCalculate)
        {
            //initial result array
            int[] result = new int[numberOfCalculate];

            //implementation first value = 0
            result[0] = 0;

            //implementation first value = 1
            result[1] = 1;

            ////implementation other value
            for (int i = 2; i < numberOfCalculate; i++)
            {
                result[i] = result[i-1] + result[i - 2];
            }

            return result;
        }
    }
}
