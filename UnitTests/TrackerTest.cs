using Moq;
using NerdGolfTracker;
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
			interpreterStub.Setup(interpreter => interpreter.OperationFuer("Unbekannte Eingabe")).Returns<Operation>(null);
			var actualResult = new Tracker(interpreterStub.Object, null).ReagiereAuf("Unbekannte Eingabe");
			StringAssert.Contains(actualResult, "keinem gueltigen Befehl");
            StringAssert.Contains(actualResult, "folgende Befehle");
		}
	}
}