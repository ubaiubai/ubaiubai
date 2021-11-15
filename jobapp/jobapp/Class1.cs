using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobsRequirement
{
    class JobBO
    {
        public List<Job> findJob(List<Job> jobList, String location)
        {

            List<Job> result = new List<Job>();
            foreach (var item in jobList)
            {
                if (item.Location.Equals(location))
                {

                    result.Add(item);

                }
            }
            return result;

        }
        public List<Job> findJob(List<Job> jobList, Double salary)

        {
            List<Job> result = new List<Job>();
            foreach (var item in jobList)
            {
                if (item.Salary >= salary)
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}