using ChangeOperator.Models;

//seed data
Post post = new Post()
{
    Title = "New Post",
    ViewCount = 1
};

Post post2 = new Post()
{
    Title = "New Post2",
    ViewCount = 5
};

//output result
Console.WriteLine(post + post2);