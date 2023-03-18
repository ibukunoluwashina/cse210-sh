using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
    }



    public class Job
    {
        
        public string _jobTitle;
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }

}