using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderedJobs_Kata
{
    internal class OrderedJobs
    {
        private List<string> jobs;
        private Dictionary<string, string> dependencies;

        public OrderedJobs()
        {
            jobs = new List<string>();
            dependencies = new Dictionary<string, string>();
        }

        public List<string> Execute()
        {
            return jobs;
        }

        public void addJob(string job)
        {

            ComprobateAndAddJob(job);
        }

        public void addJobWithDependency(string job, string dependency)
        {
            ComprobateAndAddJob(job);
            dependencies.Add(job, dependency);
        }

        private void ComprobateAndAddJob(string job)
        {
            var keyValue = dependencies.FirstOrDefault(jobsDependency => jobsDependency.Value == job);
            var insertNextIndex = jobs.Count;

            if (keyValue.Key != null)
            {
                var index = jobs.FindIndex(jobsDependency => jobsDependency == keyValue.Key);
                insertNextIndex = ++index;
            }

            jobs.Insert(insertNextIndex, job);
        }
    }
}