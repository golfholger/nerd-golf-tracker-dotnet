using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    class UnbekannteEingabeSteps
    {
        private TrackerDriver _driver;

        public UnbekannteEingabeSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich eine dem NerdGolfTracker unbekannte Eingabe mache")]
        public void UnbekannteEingabe()
        {
            _driver.EmpfangeAnweisung("UnbekannteEingabe");
        }

        [Then(@"weist mich der Nerd Tracker auf eine unbekannte Eingabe hin")]
        public void PruefeUnbekannteEingabeHinweis()
        {
            _driver.AssertThatAntwortContains("Die gemachte Eingabe konnte keinem gueltigen Befehl zugeordnet werden, du Nerd!");
        }

        [Then(@"weist mich der Tracker auf die Hilfe hin")]
        public void PruefeUnbekannteEingabeHilfe()
        {
			_driver.AssertThatAntwortContains("folgende Befehle");
        }
    }
}
