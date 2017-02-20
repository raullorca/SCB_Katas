using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Diamond_Kata
{
    [TestClass]
    public class DiamondTest
    {
        Diamond diamond;

        [TestInitialize]
        public void Initialize()
        {
            diamond = new Diamond();
        }

        [TestMethod]
        public void TestWithCString()
        {

            var result = diamond.Execute('C');

            var expected = new[]
            {
                "--A--",
                "-B-B-",
                "C---C",
                "-B-B-",
                "--A--",
            };

            CollectionAssert.AreEqual(expected, result);
        }
       
        [TestMethod]
        public void TestWith_A_String()
        {

            var result = diamond.Execute('A');

            string[] expected = new string[]
            {
                "A"
            };

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestWith_B_String()
        {

            var result = diamond.Execute('B');

            string[] expected = new string[]
            {
                "-A-",
                "B-B",
                "-A-",

            };

            CollectionAssert.AreEqual(expected, result);
        }
    }
}
