using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    public class BubbleSort
    {
        #region Bubble Sort
        /// <summary>
        /// Sort your array in bubble sort algorithm
        /// </summary>
        /// <param name="array">An array you want to sort it</param>
        /// <returns>Sorted array with bubble sort algorithm implementation</returns>
        public static int[] Sort(int[] array)
        {
            int arrayTempNumber;
            bool isSortCompleted = true;
            for (int i = 0; i < array.Length - 1 && isSortCompleted; i++)
            {
                isSortCompleted = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        arrayTempNumber = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = arrayTempNumber;
                        isSortCompleted = true;
                    }
                }
            }
            return array.ToArray();
        }
        #endregion
    }
}