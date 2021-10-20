using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests
{
	[TestClass]
	public class StringCalcTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.AreEqual(3, Calc("1,2"));
			Assert.AreEqual(6, Calc("1,2,3"));
			Assert.AreEqual(10, Calc("1,2,3,4"));
			Assert.AreEqual(4, Calc("2,2"));
			Assert.AreEqual(44, Calc("21,23"));

			Assert.AreEqual(44, Calc("21\n23"));
			Assert.AreEqual(10, Calc("1\n2\n3\n4"));

			Assert.AreEqual(10, Calc("1\n2,3\n4"));
		}

		private int Calc(string s)
		{
			if (!s.Contains(",") && !s.Contains("\n"))
			{
				return Int32.Parse(s);
			}

			string firstNumber = s.Split(',', '\n')[0];

			string restString = s.Substring(firstNumber.Length + 1);

			return Int32.Parse(firstNumber) + Calc(restString);
		}
	}
}
