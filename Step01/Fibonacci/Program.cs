public class Program
{
    #region Main Method
    public static void Main(string[] args)
    {
        //Calculate and print Fibonacci algorithm with sample value of 14
        PrintArray(Fibonacci.Fibonacci.CalculateFibonacciAlgorithm(14));
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
}