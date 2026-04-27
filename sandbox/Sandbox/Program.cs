using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // int x = 10;

        // if(x == 11)
        // {
        //     Console.Write("Hey Bob");

        // }

        // for (int i = 10000; i >= -10000; i--)
        // {
        //     // if (i % 2 == 1)
        //         Console.WriteLine(i);
        // }

        int age = -1;

        while (age < 0 || age > 125)
        {
            Console.WriteLine("Please write your age: ");
            age = int.Parse(Console.ReadLine());

        }
    }
}