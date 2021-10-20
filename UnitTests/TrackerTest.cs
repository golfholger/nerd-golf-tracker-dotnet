using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

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
			interpreterStub.Setup(interpreter => interpreter.OperationFuerKommando("Eingabe"))
				.Returns(operationStub.Object);
			operationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
				.Returns("Ausgabe");
			var tracker = new Tracker(interpreterStub.Object, null);
			Assert.AreEqual(tracker.ReagiereAuf("Eingabe"), "Ausgabe");
		}

		[TestMethod]
		public void GibtErgebnisDerAusgeloestenOperationZurueckAlias()
		{
			var interpreterStub = new Mock<Interpreter>();
			var operationStubE = new Mock<Operation>();
			Operation unbekanntOp = new UnbekannteEingabe();
			interpreterStub.Setup(interpreter => interpreter.OperationFuerAlias("e"))
				.Returns(operationStubE.Object);
			interpreterStub.Setup(interpreter => interpreter.OperationFuerKommando("e"))
				.Returns(unbekanntOp);
			interpreterStub.Setup(interpreter => interpreter.OperationFuerAlias("?"))
				.Returns(unbekanntOp);
			interpreterStub.Setup(interpreter => interpreter.OperationFuerKommando("?"))
				.Returns(unbekanntOp);
			operationStubE.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
				.Returns("Ausgabe");

			var tracker = new Tracker(interpreterStub.Object, null);
			Assert.AreEqual(tracker.ReagiereAuf("e"), "Ausgabe");
			Assert.AreEqual(tracker.ReagiereAuf("?"), "Ein unbekannter Befehl wurde eingegeben. Verwenden Sie \"Hilfe\" für eine Uebersicht der moeglichen Befehle.");
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
	}
}
