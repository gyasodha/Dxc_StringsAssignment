using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prompt the user to enter some strings
        Console.WriteLine("Enter some strings (separated by spaces):");
        string input = Console.ReadLine();

        // Split the input into an array of words
        string[] words = input.Split(' ');

        // Find the shortest word
        string shortestWord = words[0];
        foreach (string word in words)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
        }

        // Output the shortest word
        Console.WriteLine($"The shortest word is: {shortestWord}");

        // Find the palindromic words
        var palindromes = words.Where(word => IsPalindrome(word)).ToList();

        // Output the count and the palindromic words
        Console.WriteLine($"Found {palindromes.Count} palindromic word(s): {string.Join(", ", palindromes)}");
    }

    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}