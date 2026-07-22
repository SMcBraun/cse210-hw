/*===============================================================
    FILE: Comments.cs
    PURPOSE: Stores information about one YouTube comment
=================================================================*/

/*=========This creates the plan for each comment==============*/

public class Comment
{
    /*=========These codes record the comment information==============*/
    private string _name;
    private string _text;

    /*=========This fills in the comment information when it is created==============*/
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    /*=========This gives the commenter's name back to Program.cs==============*/
    public string GetName()
    {
        return _name;
    }

    /*=========This gives the comment back to Program.cs==============*/
    public string GetText()
    {
        return _text;
    }
}