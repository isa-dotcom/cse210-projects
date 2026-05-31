using System;
using System.Collections.Generic;

public class Video
{
    // Basic information about the video
    private string _title;
    private string _author;
    private int _length;

    // Keep all comments related to this video in one list
    private List<Comment> _comments;

    // Initialize the video information and create an empty comment list
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

        // Don't forget to initialize the list
        _comments = new List<Comment>();
    }

    // Add a new comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return the total number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}