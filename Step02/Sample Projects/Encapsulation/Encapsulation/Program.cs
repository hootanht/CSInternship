using Encapsulation;

User u = new User();
// set accessors will invoke
u.Name = "Suresh Dasari";
// set accessors will invoke
u.Location = "Hyderabad";
// get accessors will invoke
Console.WriteLine("Name: " + u.Name);
// get accessors will invoke
Console.WriteLine("Location: " + u.Location);
Console.WriteLine("\nPress Enter Key to Exit..");
Console.ReadLine();