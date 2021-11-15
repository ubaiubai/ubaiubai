using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsRequirement
{
    class Program
    {
        static void Main(string[] args)
        {
            int no_Of_Job;
            Console.WriteLine("PLEASE ENTER THE NUMBER OF JOB DETAILS YOU WANT TO PASS");
            no_Of_Job = Convert.ToInt32(Console.ReadLine());
            List<Job> jobs = new List<Job>();
            int press = 0;

            for (int i = 0; i < no_Of_Job; i++)
            {
                Console.WriteLine("The job details should be given as a comma-separated value in the below order-role, skillSet, employmentType, location, minExperience, salary");
                string job = Console.ReadLine();
                string[] job1 = job.Split(',');
                Job job_Details = new Job(job1[0], job1[1], job1[2], job1[3], int.Parse(job1[4]), double.Parse(job1[5]));
                jobs.Add(job_Details);


            }
            Console.WriteLine("ENTER 1 FOR SORTING JOB DETAILS BASED ON LOCATION/ENTER 2 FOR SORTING JOB DETAILS BASED ON SALARY");
            press = Convert.ToInt32(Console.ReadLine());
            JobBO j = new JobBO();
            List<Job> sort_Job_Details = new List<Job>();
            switch (press)
            {
                case 1:
                    Console.WriteLine("ENTER THE LOCATION");
                    sort_Job_Details = j.findJob(jobs, Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("ENTER THE SALARY AMOUNT");
                    sort_Job_Details = j.findJob(jobs, Convert.ToDouble(Console.ReadLine()));
                    break;

            }
            foreach (var item in sort_Job_Details)
            {
                Console.WriteLine(item);
            }

        }


    }
}