using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class SchlagausgabeTest
    {
        private Mock<Scorecard> _scorecardStub;
        private Schlagausgabe _schlagausgabe;
            
        [TestInitialize]
        public void Init()
        {
            _scorecardStub = new Mock<Scorecard>();
            _schlagausgabe = new Schlagausgabe();

        }

        [TestMethod]
        public void GibtSchlagzahlenAus()
        {
            _scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaegeAktuellesLoch).Returns(1);
            StringAssert.Contains(_schlagausgabe.FuehreAus(_scorecardStub.Object), "1 Schlag");
        }
        [TestMethod]
        public void GibtSchlagzahlenPluralAus()
        {
            int schlaege = 2;
            _scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaegeAktuellesLoch).Returns(schlaege);
            StringAssert.Contains(_schlagausgabe.FuehreAus(_scorecardStub.Object), schlaege.ToString() + " Schlaege");
        }
    }
}