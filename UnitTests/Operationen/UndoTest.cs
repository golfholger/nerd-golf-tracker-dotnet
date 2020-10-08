using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class UndoTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Undo _undo;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _undo = new Undo();
        }

        [TestMethod]
        public void MacheSchlagRueckgaengig()
        {
            _undo.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.Undo());
        }
    }
}
