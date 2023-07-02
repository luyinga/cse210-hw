using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in",
         "the lord with all thine understanding ");
        

        while (userInput != "quit")
        {
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.HideRandomWords();

            Console.Clear();
        }
    }
}