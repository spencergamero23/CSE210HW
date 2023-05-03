using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2006;
        job1._endYear = 2016;

        Job job2 = new Job();
        job2._company = "Boeing";
        job2._jobTitle = "Construction";
        job2._startYear = 2004;
        job2._endYear = 2023;

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        Resume myResume = new Resume();
        myResume._name = "Spencer Gamero";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResumeDetails();

        
    }
}