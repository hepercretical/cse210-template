using System;

class Program
{
    static void Main(string[] args)
    {
        // Creates the resume and assigns the name to it.
        Resume resume = new Resume();
        resume._name = "Talmage";

        // Uses the Job class to store information about the first job and store it in the jobs list of the resume.
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        resume._jobs.Add(job1);

        // Uses the job class to store infoirmation abou the second job and store it in the jobs list of the resume.
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        resume._jobs.Add(job2);

        // Displays all of the information.
        resume.Display();
    }
}