namespace BinarySearch
{
    public class BinarySearch
    {
        #region BinarySearch Implementation
        /// <summary>
        /// This method search expected value into the array and write result message
        /// </summary>
        /// <param name="array">actual sorted array</param>
        /// <param name="expect">expected array</param>
        /// <param name="start">start index of array</param>
        /// <param name="mid">middle index of array</param>
        /// <param name="end">end index of array</param>
        public static void Search(int[] array, int expect, int start = 0, int mid = 0, int end = 0)
        {
            try
            {
                //When we hit end of the steps
                if (start == end)
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
                //Check middle array is smaller than expect value
                else if (array[mid] < expect)
                {
                    Search(array, expect, start, ((start + mid - 1) / 2), mid - 1);
                }
                //Check middle array is grater than expect value
                else if (array[mid] > expect)
                {
                    Search(array, expect, mid + 1, ((mid + 1 + end) / 2), end);
                }
                //Check middle array is equals expect value , if we have multiple value of 5
                else if (array[mid] == expect)
                {
                    Console.WriteLine("\nYour search is exist , search value : 5");
                }
                else
                {
                    Console.WriteLine("\nYour search isn't exist , search value : 5");
                }
            }
            //If any errors happens , let me know!
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion
    }
}
