using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;

namespace UnitTests.Operationen
{
	[TestClass]
	public class LochausgabeTest
	{
		[TestMethod]
		public void LiefertTextMitAktuellemLoch()
		{
			var scorecardStub = new Mock<Scorecard>();
			scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(2);
			Assert.IsTrue(new Lochausgabe().FuehreAus(scorecardStub.Object).Contains("auf dem 2.Loch"));

			scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(3);
			Assert.IsTrue(new Lochausgabe().FuehreAus(scorecardStub.Object).Contains("auf dem 3.Loch"));

			scorecardStub.Setup(scorecard => scorecard.Lochnummer).Returns(0);
			Assert.IsTrue(new Lochausgabe().FuehreAus(scorecardStub.Object).Contains("Die Lochnummer ist ungültig"));

			Assert.IsTrue(new Lochausgabe().FuehreAus(null).Contains("Es existiert keine Scorecard"));
		}
	}
}
