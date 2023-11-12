using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._company = "BYU Aspen Grove";
        job1._jobTitle = "Arts and Crafts Counselor";
        job1._startYear = "2022";
        job1. _endYear = "2023";
 
        Job job2 = new Job();
        job2._company = "Fiore Pizza";
        job2._jobTitle = "Pizza Cook";
        job2._startYear = "2023";
        job2._endYear = "2024";

        Resume myResume = new Resume();
        myResume._name = "Shane Basham";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayResume();
    }
}