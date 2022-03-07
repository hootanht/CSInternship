using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class BinarySearch
    {
        public static void Search(int[] array, int expect, int start = 0, int mid = 0, int end = 0)
        {
            try
            {
                if (start == mid && mid == end)
                {
                    if (array[mid] == expect)
                    {
                        Console.WriteLine("\nYour search is exist , search value : 5");
                    }
                    else
                    {
                        Console.WriteLine("\nYour search isn't exist , search value : 5");
                    }
                }

                else if (array[mid] < expect)
                {
                    Search(array, expect, start, ((start + mid - 1) / 2), mid - 1);
                }
                else if (array[mid] > expect)
                {
                    Search(array, expect, mid + 1, ((mid + 1 + end) / 2), end);
                }
                else if(array[mid] == expect)
                {
                    Console.WriteLine("\nYour search is exist , search value : 5");
                }
                else
                {
                    Console.WriteLine("\nYour search isn't exist , search value : 5");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
