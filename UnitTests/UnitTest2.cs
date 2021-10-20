using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, Convert("1"));
            Assert.AreEqual(3, Convert("1,2"));
            Assert.AreEqual(7, Convert("1,2" + Environment.NewLine + "4"));
            Assert.AreEqual(5, Convert("1,2?3" + Environment.NewLine + "4,-5"));
            Assert.AreEqual(5, Convert("1,2?/\\3" + Environment.NewLine + "4,-5"));
        }

        private int Convert(string v)
        {
            var seperators = new[] { Environment.NewLine, ",", "?", "/", "\\" };
            var numbersAsString = v.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            var numbers = numbersAsString.Select(x => int.Parse(x));

            return numbers.Sum();
        }
    }
}
