using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1= new job();
        job1._jobTitle ="Software Engineer";
        job1._jobCompany ="Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = " Manager";
        job2._jobCompany ="Microsoft";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name ="Thompson Nkomo";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();



       
    }

    private class Resume
    {
        internal readonly object _jobs;
        internal string _name;

        public Resume()
        {
        }
    }
}

internal class Job
{
    internal string _jobTitle;
    internal string _jobCompany;
    internal int _endYear;
    internal int _startYear;

    public Job()
    {
    }
}