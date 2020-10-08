using NerdGolfTracker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class EinfacheScorecardTest
    {
        private Scorecard _scorecard;

        [TestInitialize]
        public void InitialisiereScorecard()
        {
            _scorecard = new EinfacheScorecard();
        }

        [TestMethod]
        public void InkrementiertSchlagzahlEinmal()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.AreEqual(_scorecard.AnzahlSchlaege, 1);
        }

        [TestMethod]
        public void InkrementiertSchlagzahlMehrmals()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.AreEqual(_scorecard.AnzahlSchlaege, 2);
        }

        [TestMethod]
        public void ErhoehtLochnummerBeiLochwechsel()
        {
            _scorecard.SchliesseLochAb();
            Assert.AreEqual(_scorecard.Lochnummer, 2);
        }

        [TestMethod]
        public void ResetSchlagzahlBeiLochwechsel()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.AreEqual(_scorecard.AnzahlSchlaegeAktuellesLoch, 1);
            _scorecard.SchliesseLochAb();
            Assert.AreEqual(_scorecard.AnzahlSchlaegeAktuellesLoch, 0);
        }

        [TestMethod]
        public void UndoSchlagTest()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.AreEqual(_scorecard.AnzahlSchlaegeAktuellesLoch, 1);
            Assert.AreEqual(_scorecard.Lochnummer, 1);
            _scorecard.Undo();
            Assert.AreEqual(_scorecard.AnzahlSchlaegeAktuellesLoch, 0);
            Assert.AreEqual(_scorecard.Lochnummer, 1);
        }

        [TestMethod]
        public void SchliesseSpielAbTest()
        {
            Assert.AreEqual(_scorecard.SpielAbgeschlossen, false);
            _scorecard.SchliesseSpielAb();
            Assert.AreEqual(_scorecard.SpielAbgeschlossen, true);
        }
    }
}