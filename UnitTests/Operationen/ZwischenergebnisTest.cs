using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
    [TestClass]
    public class ZwischenergebnisTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Mock<Operation> _folgeOperationMock;
        private Mock<Schlag> _schlagMock;
        private Zwischenergebnis _zwischenergebnis;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _folgeOperationMock = new Mock<Operation>();
            _zwischenergebnis = new Zwischenergebnis();
        }

        [TestMethod]
        public void ZwischenergebnisOhneSchlag()
        {
            Assert.AreEqual("Dein aktuelles Zwischenergebnis: 0", _zwischenergebnis.FuehreAus(_scorecardMock.Object));
        }

        [TestMethod]
        public void ZwischenergebnisMitEinemSchlag()
        {
            _scorecardMock.Setup(x => x.AnzahlSchlaege).Returns(1);
            Assert.AreEqual("Dein aktuelles Zwischenergebnis: 1", _zwischenergebnis.FuehreAus(_scorecardMock.Object));
        }
    }
}
