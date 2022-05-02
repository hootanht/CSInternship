/// <summary>
/// This is the class with immutable property
/// </summary>
public class SampleClass
{
    // Immutable field
    private readonly string myString;

    /// <summary>
    /// This is the constructor to initialize the value of immutable field
    /// </summary>
    /// <param name="str">This is default value of immutable field</param>
    public SampleClass(string str)
    {
        myString = str;
    }

    /// <summary>
    /// This is the property to get the value of immutable field
    /// </summary>
    public string GetStr => myString;

    // Another shape => public string GetStr { get { return myString; } }
}
public partial class Program
{
    public static void Main()
    {
        SampleClass sampleClass = new SampleClass("Hootan");
        Console.WriteLine(sampleClass.GetStr);
    }
}