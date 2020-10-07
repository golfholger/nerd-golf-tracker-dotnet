using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    class HilfeSteps
    {
        private TrackerDriver _driver;

        public HilfeSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich die Hilfe aufrufe")]
        public void RufeHilfeAuf()
        {
            _driver.EmpfangeAnweisung("Hilfe");
        }

        [Then(@"zeigt der NerdGolfTracker die Hilfe zu jedem Kommando in einer separaten Zeile an")]
        public void ThenZeigtDerNerdGolfTrackerDieHilfeZuJedemKommandoInEinerSeparatenZeileAn()
        {
            _driver.AssertThatBulletPointsAreProperlyFormated();
        }

        [Then(@"zeigt der NerdGolfTracker seine Benutzung an")]
        public void PruefeHilfeZurBenutzung()
        {
            _driver.AssertThatAntwortContains("folgende Befehle");
        }

        [Then(@"erklaert der NerdGolfTracker das Kommando ""(.*)""")]
        public void PruefeHilfeZuKommando(string kommando)
        {
            _driver.AssertThatAntwortContains("[" + kommando.Substring(0, 1) + "]" + kommando.Substring(1));
        }
    }
}
