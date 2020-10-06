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
        private Mock<Operation> _folgeOperationMock;
            
        [TestInitialize]
        public void Init()
        {
            _scorecardStub = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _schlagausgabe = new Schlagausgabe(_folgeOperationMock.Object);

        }

        [TestMethod]
        public void GibtSchlagzahlenAus()
        {
            _scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(1);
            StringAssert.Contains(_schlagausgabe.FuehreAus(_scorecardStub.Object), "1 Schlag");
        }
        [TestMethod]
        public void GibtSchlagzahlenPluralAus()
        {
            int schlaege = 2;
            _scorecardStub.Setup(scorecard => scorecard.AnzahlSchlaege).Returns(schlaege);
            StringAssert.Contains(_schlagausgabe.FuehreAus(_scorecardStub.Object), schlaege.ToString() + " Schlaege");
        }

        [TestMethod]
        public void FuehrtFolgeOperationAus()
        {
            _schlagausgabe.FuehreAus(_scorecardStub.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardStub.Object));
        }

    }
}