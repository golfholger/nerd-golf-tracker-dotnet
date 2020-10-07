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
        private Mock<Operation> _folgeOperationMock;
        private Undo _undo;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _undo = new Undo(_folgeOperationMock.Object);
        }

        [TestMethod]
        public void MacheSchlagRueckgaengig()
        {
            _undo.FuehreAus(_scorecardMock.Object);
            _scorecardMock.Verify(scorecard => scorecard.Undo());
        }

        [TestMethod]
        public void FuehrtFolgeOperationAus()
        {
            _undo.FuehreAus(_scorecardMock.Object);
            _folgeOperationMock.Verify(operation => operation.FuehreAus(_scorecardMock.Object));
        }
    }
}
