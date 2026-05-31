using System;

public class Comment
{
    // Store the name of the person who made the comment
    private string _commenterName;

    // Store the actual comment text
    private string _commentText;

    // Create a comment object with a name and message
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Return the commenter's name
    public string GetCommenterName()
    {
        return _commenterName;
    }

    // Return the comment text
    public string GetCommentText()
    {
        return _commentText;
    }
}