using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;

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

			Assert.AreEqual(tracker.ReagiereAuf("Loch anzeigen"), "auf dem 1.Loch");
		}

		[TestMethod]
		public void GibtErgebnisDerAusgeloestenOperationZurueckAlias()
		{
			var interpreterStub = new Mock<Interpreter>();
			var operationStub = new Mock<Operation>();
			interpreterStub.Setup(interpreter => interpreter.OperationFuerAlias("e"))
				.Returns(operationStub.Object);
			operationStub.Setup(operation => operation.FuehreAus(It.IsAny<Scorecard>()))
				.Returns("Ausgabe");
			var tracker = new Tracker(interpreterStub.Object, null);
			Assert.AreEqual(tracker.ReagiereAuf("e"), "Ausgabe");
			Assert.AreEqual(tracker.ReagiereAuf("?"), "Eingabe nicht bekannt");
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
