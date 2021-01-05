using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> AllJobs = new List<string> { "Coder", "Programmer", "Developer" };
            List<string> AllJobsCopy = new List<string>(AllJobs);
            AllJobs.Add("Software Engineer");
            Console.WriteLine(AllJobs.Count);  //4
            Console.WriteLine(AllJobsCopy.Count);  //4
        }
    }
}
