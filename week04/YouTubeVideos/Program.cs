public class Program
{
    public static void Main(string[] args)
    {
        Video video1 = new Video("Understanding Abstraction", "Tech Guru", 300);
        Video video2 = new Video("C# from Scratch", "Code Academy", 600);
        Video video3 = new Video("Encapsulation Explained", "Programming Hub", 450);

        video1.AddComment(new Comment("Alice", "Great explanation. Thanks!"));
        video1.AddComment(new Comment("Jhon", "Very clear and concise. Good job!"));
        video1.AddComment(new Comment("Charlie", "Thanks for the video!"));

        video2.AddComment(new Comment("David", "Amazing tutorial! I was looking for a clear explanation like this."));
        video2.AddComment(new Comment("Eve", "I finally understand encapsulation. Thank you so much!"));
        video2.AddComment(new Comment("Frank", "I think this video is perfect for beginners."));

        video3.AddComment(new Comment("Grace", "This is the best explanation that I have found. Helpful content!"));
        video3.AddComment(new Comment("Tom", "Great examples.Thank you very much for this content."));
        video3.AddComment(new Comment("Ivonne", "I definitely learned a lot."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}
