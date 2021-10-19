using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkzeptanzTests;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Bindings
{
	[Binding]
	class UnbekannteEingabeSteps
	{
		private TrackerDriver _driver;

		/// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
		public UnbekannteEingabeSteps(TrackerDriver driver)
		{
			_driver = driver;
		}

		[When(@"ich eine dem NerdGolfTracker unbekannte Eingabe mache")]
		public void RufeUnbekannteEingabeAuf()
		{
			_driver.EmpfangeAnweisung("Irgendwas");
		}

		[Then(@"weist mich der Tracker auf die Hilfe hin")]
		public void HinweisAufDieHilfe()
		{
			_driver.AssertThatAntwortContains("Übersicht der möglichen Befehle");
			_driver.AssertThatAntwortContains("Hilfe");
		}
	}
}
