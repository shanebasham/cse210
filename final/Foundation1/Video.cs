class Video
{
    public string Title { get; }
    public string Author { get; }
    public int Length { get; }
    public List<Comment> Comments { get; }
    // Get video info
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }
    public void AddComment(string userName, string text)
    {
        Comments.Add(new Comment(userName, text));
    }
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }
}


// Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video. Each video also has responsibility to store a list of comments, and should have a method to return the number of comments. 