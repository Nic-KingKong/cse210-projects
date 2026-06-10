class Program
{
    public static void Main(string[] args)
    {

        int sleepTime = 1000; // Time in milliseconds

        Console.Clear();
        Console.CursorVisible = false;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("+");
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(sleepTime);
            Console.Write("\b \b");
        }

        //string animationString = "\\|/-";

        int count = 15;
        DateTime now = DateTime.Now;
        DateTime endTime = now.AddSeconds(count); // Run the animation for 10 seconds
        //for (int i = 0; i < 50; i++)
        //int index = 0;
        //while(DateTime.Now < endTime)
        while (count >= 0)
        {
            Console.Write($"{count--,2}");
            //Console.Write(animationString[index++ % animationString.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b");

            // Console.Write("-");
            // Thread.Sleep(sleepTime);
            // Console.Write("\b \b");
        }

        Console.CursorVisible = true;

    }
}