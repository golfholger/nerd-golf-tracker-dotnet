using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class ZwischenergebnisAnzeigenSteps
    {
        private readonly TrackerDriver _driver;

        public ZwischenergebnisAnzeigenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"Zwischenergebnis aufrufe")]
        public void WhenZwischenergebnisAufrufe()
        {
            _driver.EmpfangeAnweisung("Zwischenergebnis anzeigen");
        }

        [Then(@"zeigt der NerdGolfTracker insgesamt (.*) Schlaege")]
        [Then(@"zeigt der NerdGolfTracker insgesamt (.*) Schlag")]
        public void ThenZeigtDerNerdGolfTrackerInsgesamtSchlaege(int p0)
        {
            _driver.AssertThatAntwortContains("{0} Schla", p0);
        }

        //[Then(@"zaehlt.* auf dem (\d+)\. (.*)")]
        //[Then(@"begruesst.* auf dem (\d+)\. (.*)")]
        //public void PruefeLoch(int lochnummer, string lochnomen)
        //{
        //    _driver.AssertThatAntwortContains("{0}.", lochnummer, lochnomen);
        //}
    }
}