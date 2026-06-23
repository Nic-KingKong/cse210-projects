using System;

class Program
{
    static void Main(string[] args)
    {

        Reference myReference = new Reference("John", 3, 16);
        string scriptureText = "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        Scripture myScripture = new Scripture(myReference, scriptureText);
        
        string userInput = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetScriptureString());
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            if (userInput == "quit" || myScripture.IsCompletelyHidden())
            {
                break;
            }
            userInput = Console.ReadLine();
            if (userInput != "quit")
            {
                myScripture.HideRandomWord();
            }
        }

        // Console.WriteLine(myScripture.GetScriptureString());
        // myScripture.HideRandomWord();
        // Console.WriteLine(myScripture.GetScriptureString());
        // myScripture.HideRandomWord();
        // Console.WriteLine(myScripture.GetScriptureString());
    }
}