using System;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Operationen
{
    [TestClass]
    public class HilfeTest
    {
        [TestMethod]
        public void GibtEineZeileProBefehlAusPlusEine()
        {
            var ausgabe = new Hilfe().FuehreAus(null);
            var zeilen = ausgabe.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.None);
            int anzahlBefehle = (new NerdGolfTracker.AlleBefehle()).Befehle().Count;

            Assert.AreEqual(anzahlBefehle + 1, zeilen.Length);
        }
    }
}
