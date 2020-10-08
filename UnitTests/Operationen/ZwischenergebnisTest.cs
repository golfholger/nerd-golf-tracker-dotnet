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
        private Zwischenergebnis _zwischenergebnis;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _zwischenergebnis = new Zwischenergebnis();
        }

        [TestMethod]
        public void ZwischenergebnisOhneSchlag()
        {
            Assert.AreEqual("Dein aktuelles Zwischenergebnis: 0 Schlaege", _zwischenergebnis.FuehreAus(_scorecardMock.Object));
        }

        [TestMethod]
        public void ZwischenergebnisMitEinemSchlag()
        {
            _scorecardMock.Setup(x => x.AnzahlSchlaege).Returns(1);
            Assert.AreEqual("Dein aktuelles Zwischenergebnis: 1 Schlag", _zwischenergebnis.FuehreAus(_scorecardMock.Object));
        }

        [TestMethod]
        public void ZwischenergebnisMitZweiSchlaegen()
        {
            _scorecardMock.Setup(x => x.AnzahlSchlaege).Returns(2);
            Assert.AreEqual("Dein aktuelles Zwischenergebnis: 2 Schlaege", _zwischenergebnis.FuehreAus(_scorecardMock.Object));
        }
    }
}
