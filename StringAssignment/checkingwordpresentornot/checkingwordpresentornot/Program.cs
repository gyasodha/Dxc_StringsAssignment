class Program
{
    static void Main()
    {
        string[] words = { "chennai", "Mumbai", "kolkatta", "delhi", "bangalore" };
        Array.Sort(words); 

        Console.WriteLine("Enter a word to search:");
        string word = Console.ReadLine();

        bool isPresent = words.Contains(word);
        if (isPresent)
        {
            Console.WriteLine("The word is present in the list.");
        }
        else
        {
            Console.WriteLine("The word is not present in the list.");
        }
    }
}
