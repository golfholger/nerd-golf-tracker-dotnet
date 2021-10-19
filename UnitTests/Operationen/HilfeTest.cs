using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using System;

namespace UnitTests.Operationen
{
	[TestClass]
	public class HilfeTest
	{
		[TestMethod]
		public void GibtEineZeileProBefehlAus()
		{
			var ausgabe = new Hilfe().FuehreAus(null);
			var zeilen = ausgabe.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
			Assert.AreEqual(zeilen.Length, new AlleBefehle().Befehle().Count);
		}
	}
}
