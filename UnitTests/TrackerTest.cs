using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class TrackerTest
    {
        [TestMethod]
        public void GibtErgebnisDerAusgeloestenOperationZurueck()
        {
            var interpreterStub = new Mock<Interpreter>();
            var operationStub = new Mock<Operation>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("Eingabe"))
                .Returns(operationStub.Object);
            operationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(interpreterStub.Object, null);
            Assert.AreEqual(tracker.ReagiereAuf("Eingabe"), "Ausgabe");
        }

        [TestMethod]
        public void GibtErgebnisDerStartoperationZurueck()
        {
            var startoperationStub = new Mock<Operation>();
            startoperationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
                .Returns("Ausgabe");
            var tracker = new Tracker(null, startoperationStub.Object);
            Assert.AreEqual(tracker.Starte(), "Ausgabe");
        }

		[TestMethod]
		public void GibtErgebnisDerUnbekanntenEingabeZurueck()
		{
			var interpreterStub = new Mock<Interpreter>();
			interpreterStub.Setup(interpreter => interpreter.OperationFuer("Unbekannte Eingabe")).Returns(
				new NerdGolfTracker.Operationen.UnbekannteOperation());
			var actualResult = new Tracker(interpreterStub.Object, null).ReagiereAuf("Unbekannte Eingabe");
			StringAssert.Contains(actualResult, "keinem gueltigen Befehl");
            StringAssert.Contains(actualResult, "folgende Befehle");
		}
        [TestMethod]
        public void RaiseExitFlag()
        {
            var interpreterStub = new Mock<Interpreter>();
            interpreterStub.Setup(interpreter => interpreter.OperationFuer("Beenden"))
                .Returns(new NerdGolfTracker.Operationen.Beenden());
            var tracker = new Tracker(interpreterStub.Object, null);
            Assert.IsFalse(tracker.BeendenAngefordert);
            Assert.AreEqual(tracker.ReagiereAuf("Beenden"), "Beende Anwendung");
            Assert.IsTrue(tracker.BeendenAngefordert);
        }
	}
}