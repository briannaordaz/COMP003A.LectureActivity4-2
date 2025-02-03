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

    ///<summary>
    /// Calculates the sum of two numbers and returns the result.
    /// </summary>
    /// <param name="num1">Integer Input Number 1</param>
    /// param name="num2">Integer Input Number 2</param>
    /// <returns>Integer sum of the two integer inputs</returns>

    static int CalculateSum(int num1, int num2)
    {
        return num1 + num2;  // Add the two numbers and return the result
    }

    /// <summary>
    /// Displays the contents of an array.
    /// </summary>
    /// <param name="numbers">Array collection of integers</param>

    static void DisplayArray(int[] numbers)
    {
        foreach (int num in numbers) // Loop through the array
        {
            Console.WriteLine(num); // print each number
        }
    }
}