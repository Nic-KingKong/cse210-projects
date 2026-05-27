using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord = new Word("Hello");
        Console.WriteLine(myWord.GetWordString());

        myWord.Hide();
        Console.WriteLine(myWord.GetWordString());

        myWord.displayWord();
        if (myWord.IsHidden())
        {
            Console.WriteLine(myWord.GetWordString());
        } 
    }
}