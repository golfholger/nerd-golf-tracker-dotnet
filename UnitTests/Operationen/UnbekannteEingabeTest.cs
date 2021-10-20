using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
	[TestClass]
	public class UnbekannteEingabeTest
	{
		[TestMethod]
		public void UnbekannteEingabeGibtEinenTextAus()
		{
			Assert.IsFalse(string.IsNullOrEmpty(new UnbekannteEingabe().FuehreAus(null)));
		}
	}
}
