using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual("1", Convert(1));
			Assert.AreEqual("2", Convert(2));
			Assert.AreEqual("Fizz", Convert(3));
			Assert.AreEqual("4", Convert(4));
			Assert.AreEqual("Buzz", Convert(5));
			Assert.AreEqual("Fizz", Convert(6));
			Assert.AreEqual("7", Convert(7));
			Assert.AreEqual("8", Convert(8));
			Assert.AreEqual("Fizz", Convert(9));
			Assert.AreEqual("Buzz", Convert(10));
			Assert.AreEqual("FizzBuzz", Convert(15));
		}

		private string Convert(int v)
		{
			if (v % 3 == 0 && v % 5 == 0)
			{
				return Convert(3) + Convert(5);
			}
			if (v % 3 == 0)
			{
				return "Fizz";
			}
			if (v % 5 == 0)
			{
				return "Buzz";
			}
		
			return v.ToString();
		}
	}
}
