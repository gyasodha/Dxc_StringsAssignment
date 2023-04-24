using System;

class Program
{
    static void Main(string[] args)
    {
        string[] s1 = { "Mumbai", "Chennai", "Kolkatta", "Bangalore", "Delhi" };

        Console.WriteLine("The original array is:");
        foreach (string word in s1)
        {
            Console.WriteLine(word);
        }

        Array.Sort(s1);

        Console.WriteLine("\nThe sorted array is:");
        for (int i = 0; i < s1.Length; i++)
        {
            Console.WriteLine(s1[i]);
        }
    }
}