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

        //Call bubble sort method
        int[]? result = BubbleSort.BubbleSort.Sort(randomArray);

        Console.WriteLine("\n\nSorted Array :");
        //Print bubble sort array (sorted)
        PrintArray(result);
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
            array[i] = random.Next(1, 100);
        }
        return array;
    }
    #endregion



}