using System;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTests.Operationen
{
    [TestClass]
    public class BeendenTest
    {
        private Mock<Scorecard> _scorecardMock;
        private Beenden _beenden;

        [TestInitialize]
        public void Init()
        {
            _scorecardMock = new Mock<Scorecard>();
            _beenden = new Beenden();
        }

        [TestMethod]
        public void BeendeProgrammTest()
        {
            // https://stackoverflow.com/questions/37340870/test-environment-exit-in-c-sharp
            // FuehreAus beendet nicht nur diesen Test sondern das gesamte Test-Framework
            // Wie können wir Beenden testen?

            // _beenden.FuehreAus(_scorecardMock.Object);
            // wenn wir hier ankommen wurde das Programm nicht beendet
            // Assert.IsTrue(false);
        }
    }
}
