class Comment
{
    public string UserName { get; }
    public string Text { get; }
    // Get comment info
    public Comment(string userName, string text)
    {
        UserName = userName;
        Text = text;
    }
}


// A comment should be defined by the Comment class which has the responsibility for tracking both the name of the person who made the comment and the text of the comment.