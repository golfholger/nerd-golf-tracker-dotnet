using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
	[TestClass]
	public class FizzbuzzTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("1", Generate(1));
			Assert.AreEqual("2", Generate(2));
			Assert.AreEqual("fizz", Generate(3));
			Assert.AreEqual("4", Generate(4));
			Assert.AreEqual("buzz", Generate(5));
			Assert.AreEqual("fizz", Generate(6));
			Assert.AreEqual("8", Generate(8));
			Assert.AreEqual("buzz", Generate(10));
			Assert.AreEqual("fizzbuzz", Generate(15));
			Assert.AreEqual("fizzbuzz", Generate(30));
			Assert.AreEqual("fizzbuzz", Generate(45));
			Assert.AreEqual("fooz", Generate(7));
			Assert.AreEqual("fooz", Generate(14));
			Assert.AreEqual("fizzbuzzfooz", Generate(105));
			Assert.AreEqual("fizzbuzzfooz", Generate(210));
			Assert.AreEqual("fizzfooz", Generate(21));
			Assert.AreEqual("fizzfooz", Generate(42));
		}

		private string Generate(int i)
		{
			if (i % 105 == 0)
			{
				return "fizzbuzzfooz";
			}
			if (i % 21 == 0)
			{
				return "fizzfooz";
			}
			if (i % 15 == 0)
			{
				return "fizzbuzz";
			}
			if (i % 7 == 0)
			{
				return "fooz";
			}
			if (i % 5 == 0)
			{
				return "buzz";
			}
			if (i % 3 == 0)
			{
				return "fizz";
			}

			return i.ToString();
		}
	}
}
