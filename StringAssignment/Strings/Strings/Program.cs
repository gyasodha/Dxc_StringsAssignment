using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of words:");
        int num = Convert.ToInt32(Console.ReadLine());

        // Create an array to store the words
        string[] s = new string[num];

        // Get the words from the user
        Console.WriteLine("Enter the words:");
        for (int i = 0; i < num; i++)
        {
            s[i] = Console.ReadLine();
        }

        // Find the shortest word
        string shortestword = s[0];
        for (int i = 1; i < num; i++)
        {
            if (s[i].Length < shortestword.Length)
            {
                shortestword = s[i];
            }
        }

        // Output the shortest word
        Console.WriteLine("The shortest word is " + shortestword + ".");
    }
}