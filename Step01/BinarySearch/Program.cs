public class Program
{
    #region Main Method
    public static void Main(string[] args)
    {
        //Generate random array
        int[]? randomArray = GenerateRandomArray();

        Console.WriteLine("UnSort Array :");
        //Print random array (unsorted)
        PrintArray(randomArray);

        //Sort random array with default sort method of array class
        Array.Sort(randomArray);

        //Print sorted array (sorted)
        Console.WriteLine("\n\nSorted Array :");
        PrintArray(randomArray);

        //Call binary search method , mentor my example is 5
        Console.WriteLine("\n\nResult is :");

        int result = BinarySearch.BinarySearch.Search(randomArray, 5, 0, (0 + randomArray.Length - 1) / 2, randomArray.Length - 1);

        //Print binary search result
        if (result == 0)
        {
            Console.WriteLine("\nYour search isn't exist , search value : 5");
        }
        else
        {
            Console.WriteLine("\nYour search is exist , search value : 5");
        }
    }
    #endregion

    #region Print Array
    /// <summary>
    /// Print array in output
    /// </summary>
    /// <param name="array">An array you want to print in output</param>
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
    }
    #endregion

    #region Generate Random Array
    /// <summary>
    /// Generate random array
    /// </summary>
    /// <returns>Return random array with random values every time</returns>
    public static int[] GenerateRandomArray()
    {
        //Initial empty array with 10 member
        int[] array = new int[10];

        //Initial random number
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            //append random number to array index with value between 0 and 100
            array[i] = random.Next(1, 6);
        }
        return array;
    }
    #endregion
}