using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class ZwischenergebnisAusgabeTest
    {
        private Mock<Scorecard> _scorecardStub;
        private Zwischenergebnisausgabe _schlagausgabe;
        private Mock<Operation> _folgeOperationMock;
            
        [TestInitialize]
        public void Init()
        {
            _scorecardStub = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _schlagausgabe = new Zwischenergebnisausgabe();

        }

        [TestMethod]
        public void GibtSchlagzahlenAus()
        {
            _scorecardStub.Setup(scorecard => scorecard.GetGesamtAnzahlSchlaege()).Returns(1);
            Assert.IsTrue(_schlagausgabe.FuehreAus(_scorecardStub.Object).Contains("1 Schlag"));
        }

    }
}