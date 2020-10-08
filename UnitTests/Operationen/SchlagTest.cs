using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class SchlagTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Schlag _schlag;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _schlag = new Schlag();
        }

        [TestMethod]
        public void ErhoehtDieSchlagzahlAufDerScorecard()
        {
            _schlag.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.ErhoeheAnzahlSchlaege());
        }
    }
}
