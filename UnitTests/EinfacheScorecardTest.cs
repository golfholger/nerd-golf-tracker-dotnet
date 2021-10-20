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
            Assert.AreEqual(_scorecard.GetAnzahlSchlaege(), 1);
        }

        [TestMethod]
        public void InkrementiertSchlagzahlMehrmals()
        {
            _scorecard.ErhoeheAnzahlSchlaege();
            _scorecard.ErhoeheAnzahlSchlaege();
            Assert.AreEqual(_scorecard.GetAnzahlSchlaege(), 2);
        }

        [TestMethod]
        public void ErhoehtLochnummerBeiLochwechsel()
        {
            _scorecard.SchliesseLochAb();
            Assert.AreEqual(_scorecard.GetLochnummer(), 2);
        }
    }
}