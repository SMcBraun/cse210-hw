using System;
using System.Collections.Generic;


/*===============================================================
    FILE: Video.cs
    PURPOSE: Stores informations about one YouTube video
=================================================================*/

/*=========This creates the plan for each video ==============*/
public class Video
{
    /*===These codes record the video's information===*/
    private string _title;
    private string _author;
    private int _length;

    /*======This list retains the comments for this video======*/
    private List<Comment> _comments = new List<Comment>();

    /*======This fills in the video information when it is created======*/
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }


    /*======This adds one comment to the video's list======*/
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);

    }

    /*======This reports how many comments the video has======*/
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    /*======This gives the title back to Program.cs======*/
    public string GetTitle()
    {
        return _title;
    }
    /*======This gives the author's name back to Program.cs======*/
    public string GetAuthor()
    {
        return _author;
    }
    /*======This command records and reports the video length data to Program.cs======*/
    public int GetLength()
    {
        return _length;
    }
    /*======This gives the comment list back to the Program.cs======*/
    public List<Comment> GetComments()
    {
        return _comments;
    }
}