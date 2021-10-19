using System;
using System.Collections.Generic;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdGolfTracker;

namespace UnitTests.Operationen
{
    [TestClass]
    public class HilfeTest
    {
        [TestMethod]
        public void GibtEineZeileProBefehlAus()
        {
	        int anzahlDerBefehle = new AlleBefehle().Befehle().Count;
            var ausgabe = new Hilfe().FuehreAus(null);
            var zeilen = ausgabe.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            Assert.AreEqual(zeilen.Length, anzahlDerBefehle + 1);
        }

        [TestMethod]
        public void JederBefehlHatEineAusreichendeErklärung()
        {
	        List<Befehl> befehle = new AlleBefehle().Befehle();
	        foreach (Befehl befehl in befehle)
	        {
                Assert.IsFalse(string.IsNullOrEmpty(befehl.Erklaerung));
	        }
        }
    }
}
