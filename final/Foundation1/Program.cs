using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
    }
}

// You have been hired by a company that does product awareness monitoring by tracking the placement of their products in YouTube videos. They want you to write a program that can help them work with the tens of thousands of videos they have identified as well as the comments on them.
// Program Specification
// Write a program to keep track of YouTube videos and comments left on them. As mentioned this could be part of a larger project to analyze them, but for this assignment, you will only need to worry about storing the information about a video and the comments.
// Your program should have a class for a Video that has the responsibility to track the title, author, and length (in seconds) of the video. Each video also has responsibility to store a list of comments, and should have a method to return the number of comments. A comment should be defined by the Comment class which has the responsibility for tracking both the name of the person who made the comment and the text of the comment.
// Once you have the classes in place, write a program that creates 3-4 videos, sets the appropriate values, and for each one add a list of 3-4 comments (with the commenter's name and text). Put each of these videos in a list.
// Then, have your program iterate through the list of videos and for each one, display the title, author, length, number of comments (from the method) and then list out all of the comments for that video. Repeat this display for each video in the list.
// Note: The YouTube example is just to give you a context for creating classes to store information. You will not actually be connecting to YouTube or downloading content in any way.


// In the Foundation1 abstraction project I will create a Video class that tracks the title, author, and length of youtube videos and a Comment class which tracks the name and text of each comment on the videos.
// In the Foundation2 encapsulation project I will have 4 classes called Product, Customer, Address, and Order that creates and displays orders containing the packing label, the shipping label, and the total price of the order.
// In the Foundation3 inheritance project I will create a base Event class and 3 types of event classes called Lectures, Receptions, and Outdoor gatherings and give each of the classes the ability to generate 3 types of messages.
// In the Foundation4 polymorphism project I will create an app that tracks exercises in 3 different classes called Running, Bicycles, and Swimming and stores the date and length of time of the activity, the distance ran, the cycling speed, and the number of laps swam and it will display a summary of the exercise data.