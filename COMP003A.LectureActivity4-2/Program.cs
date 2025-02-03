namespace COMP003A.LectureActivity4_2;
//Author: Brianna Ordaz
//Course: Comp003A
//Faculty: Jonathan Cruz
//Purpose: Practice implementing methods in C#
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    /// <summary>
    /// Greets the user by name.
    /// </summary>

    static void GreetUser()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine(); //Store user input in 'name'
        Console.WriteLine($"Hello, {name}! Welcome to the Methods Activity.");
    }
    
   
}