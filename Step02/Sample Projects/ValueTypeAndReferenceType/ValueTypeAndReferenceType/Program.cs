public partial class Program
{
    public static void Main()
    {
        Student student = new Student
        {
            Name = "Behzad"
        };

        //Reference type
        Console.WriteLine(student.Name);
        // Change the name of the student
        ChangeStudentName(student, "Hootan");
        Console.WriteLine(student.Name);

        // Reset the name of the student
        student.Name = "Behzad";
        Console.WriteLine("------------------");

        //Value type
        Console.WriteLine(student.Name);
        // Change the name of the student
        ChangeStudentName("Hootan");
        Console.WriteLine(student.Name);

    }

    /// <summary>
    /// Student class with name 
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student name
        /// </summary>
        public string Name { get; set; }
    }

    /// <summary>
    /// Change student name by reference
    /// </summary>
    public static void ChangeStudentName(Student student, string newName)
    {
        student.Name = newName;
        Console.WriteLine(newName);
    }

    /// <summary>
    /// Change student name by value
    /// </summary>
    /// <param name="newName"></param>
    public static void ChangeStudentName(string newName)
    {
        newName = "Hootan";
        Console.WriteLine(newName);
    }
}

