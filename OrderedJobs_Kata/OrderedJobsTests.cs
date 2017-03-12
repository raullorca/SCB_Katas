using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedJobs_Kata
{
    [TestClass]
    public class OrderedJobsTests
    {
        OrderedJobs orderedJobs;

        [TestInitialize]
        public void Setup()
        {
            orderedJobs = new OrderedJobs();
        }

        [TestMethod]
        public void Empty_String()
        {
            List<string> result = orderedJobs.Execute();

            var expected = new List<string>();

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Single_Job()
        {
            orderedJobs.addJob("a");
            List<string> result = orderedJobs.Execute();

            var expected = new List<string> { "a" };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiple_Jobs()
        {
            orderedJobs.addJob("a");
            orderedJobs.addJob("b");
            orderedJobs.addJob("c");
            List<string> result = orderedJobs.Execute();

            var expected = new List<string> { "a" , "b", "c"};

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Multiple_Jobs_Single_Dependency()
        {
            orderedJobs.addJob("a");
            orderedJobs.addJobWithDependency("b", "c");
            orderedJobs.addJob("c");

            List<string> result = orderedJobs.Execute();

            var expected = new List<string> { "a", "b", "c" };

            CollectionAssert.AreEqual(expected, result);
        }

    }
}
