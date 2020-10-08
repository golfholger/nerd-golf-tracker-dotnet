using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Operationen
{
    [TestClass]
    public class LochBegruessungTest
    {
        private Lochbegruessung _lochbegruessung;
        private Mock<Scorecard> _scorecardMock;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _lochbegruessung = new Lochbegruessung();
        }

        [TestMethod]
        public void GibtBegruessungAus()
        {
            Assert.IsTrue(_lochbegruessung.FuehreAus(_scorecardMock.Object).StartsWith("Du bist"));
        }
    }
}
