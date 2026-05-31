using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Main list that will store all videos
        List<Video> videos = new List<Video>();

        // Create first video
        Video video1 = new Video(
            "Learn C# in 30 Minutes",
            "Programming Academy",
            1800);

        // Add comments to the first video
        video1.AddComment(new Comment("Maria", "Excellent tutorial!"));
        video1.AddComment(new Comment("John", "Very easy to follow."));
        video1.AddComment(new Comment("Lucas", "Helped me a lot."));

        videos.Add(video1);

        // Create second video
        Video video2 = new Video(
            "Top 10 Travel Destinations",
            "Travel World",
            950);

        video2.AddComment(new Comment("Anna", "Adding these to my bucket list."));
        video2.AddComment(new Comment("Pedro", "Amazing locations!"));
        video2.AddComment(new Comment("Sarah", "Loved the video."));

        videos.Add(video2);

        // Create third video
        Video video3 = new Video(
            "Best Smartphone Review 2026",
            "Tech Central",
            1200);

        video3.AddComment(new Comment("Michael", "Great review."));
        video3.AddComment(new Comment("Emma", "Very detailed."));
        video3.AddComment(new Comment("David", "Helped me decide what to buy."));

        videos.Add(video3);

        // Go through each video and display its information
        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            Console.WriteLine("\nComment List:");

            // Display every comment that belongs to the current video
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}:");
                Console.WriteLine(comment.GetCommentText());
                Console.WriteLine();
            }
            // Add an extra blank line before displaying the next video
            Console.WriteLine();
        }
    }
}