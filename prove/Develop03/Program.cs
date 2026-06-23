using System;

class Program
{
    static void Main(string[] args)
    {

        Reference myReference = new Reference("John", 3, 16);
        string scriptureText = "\nFor God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
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

        Reference myReference1 = new Reference("Proverbs", 3, 5, 6);
        string scriptureText1 = "\nTrust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture myScripture1 = new Scripture(myReference1, scriptureText1);
        
        string userInput1 = "";
        while (true)
        {
            Console.Clear();
            Console.WriteLine(myScripture1.GetScriptureString());
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            if (userInput1 == "quit" || myScripture1.IsCompletelyHidden())
            {
                break;
            }
            userInput1 = Console.ReadLine();
            if (userInput1 != "quit")
            {
                myScripture1.HideRandomWord();
            }
        }

        // Console.WriteLine(myScripture.GetScriptureString());
        // myScripture.HideRandomWord();
        // Console.WriteLine(myScripture.GetScriptureString());
        // myScripture.HideRandomWord();
        // Console.WriteLine(myScripture.GetScriptureString());
    }
}