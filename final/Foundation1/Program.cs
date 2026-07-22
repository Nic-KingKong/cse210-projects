using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Joy of Programming", "John Doe", 300);
        video1.AddComment(new Comment("Great video!", "Alice"));
        video1.AddComment(new Comment("Very informative.", "Bob"));
        video1.AddComment(new Comment("I learned a lot.", "Charlie"));
        Video video2 = new Video("Understanding Algorithms", "Jane Smith", 450);
        video2.AddComment(new Comment("This helped me a lot.", "Charlie"));
        video2.AddComment(new Comment("Thanks for sharing!", "David"));
        video2.AddComment(new Comment("I have a question about the sorting algorithm.", "Eve"));
        Video video3 = new Video("C# Basics", "Mike Johnson", 200);
        video3.AddComment(new Comment("Clear and concise.", "Eve"));
        video3.AddComment(new Comment("I learned a lot.", "Frank"));
        video3.AddComment(new Comment("Can you make a video on advanced topics?", "Grace"));
        Video video4 = new Video("Advanced C# Techniques", "Sarah Lee", 600);
        video4.AddComment(new Comment("This is exactly what I needed.", "Grace"));
        video4.AddComment(new Comment("Excellent explanation.", "Hannah"));
        video4.AddComment(new Comment("I appreciate the examples provided.", "Ian"));
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };
        foreach (Video video in videos)
        {
            Console.WriteLine(video.DisplayInfo()); 
        }
    }
}