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
            StringAssert.Contains(_beenden.FuehreAus(_scorecardMock.Object),"Beende");
            _scorecardMock.Verify(x => x.SchliesseSpielAb());
        }
    }
}
