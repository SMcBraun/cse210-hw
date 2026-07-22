using System;
using System.Collections.Generic;

/*===============================================================
    FILE: Program.cs
    PURPOSE: Creates videos, add comments, and displays them.
=================================================================*/


/*========This is where the program begins running==============*/
class Program
{
    static void Main(string[] args)
    {

        /*========This list stores all of the videos==============*/
        List<Video> videos = new List<Video>();

        /*========This create the first video==============*/
        Video video1 = new Video(
            "How to Make Musubis",
            "Chef Uncle Sam",
             579
        );

        /*========These create comments for the first video==============*/
        video1.AddComment(new Comment("Sina", "Very easy to follow!"));
        video1.AddComment(new Comment("Kekoa", "Thanks for sharing your recipe."));
        video1.AddComment(new Comment("Kahi", "I'll take a crack at it for Family Home Evening Dinner."));

        /*========This saves the video into the list==============*/
        videos.Add(video1);





        /*========This creates the second video==============*/

        Video video2 = new Video(
            "Championship Highlights",
             "Coach Neff",
             890
        );


        /*========These create comments for the second video==============*/


        video2.AddComment(new Comment("Kekoa", "nice Pick-6!"));
        video2.AddComment(new Comment("Kala'i", "what happened?"));
        video2.AddComment(new Comment("Kainoa", "I missed the block."));

        /*========This saves the video into the list==============*/
        videos.Add(video2);




        /*========This creates the third video==============*/

        Video video3 = new Video(
            "Seminary Bowl Prep",
            "Waianae Ward Young Women",
            786

        );

        /*========These create comments for the third video==============*/
        video3.AddComment(new Comment("Sara", "Seminary Bowl Competition coming up!"));
        video3.AddComment(new Comment("Liko", "Makakilo Stake always takes it!"));
        video3.AddComment(new Comment("Lani", "We better start practicing now!"));

        /*========This saves the video into the list==============*/
        videos.Add(video3);


        /*========This goes through each video one at a time==============*/
        foreach (Video video in videos)
        {
            Console.WriteLine("----------------------------------------");

            /*========These display the video's information==============*/
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");
            Console.WriteLine();


            /*========These display each comment for the video=============*/
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }

}


