using AkzeptanzTests;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Features
{
    [Binding]
    public class ZwischenergebnisAnzeigenSteps
    {
        private readonly TrackerDriver _driver;

        public ZwischenergebnisAnzeigenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich Zwischenergebnis aufrufe")]
        public void WhenIchZwischenergebnisAufrufe()
        {
            _driver.EmpfangeAnweisung("Zwischenergebnis");
        }
        

        [Then(@"zeigt der NerdGolfTracker als Zwischenergebnis (.*) Schlag")]
        public void ThenZeigtDerNerdGolfTrackerAlsZwischenergebnisSchlag(int p0)
        {
            _driver.AssertThatAntwortContains("{0}", p0);
            _driver.AssertThatAntwortContains("Zwischenergebnis");
        }

        [Then(@"zeigt der NerdGolfTracker als Zwischenergebnis (.*) Schlaege")]
        public void ThenZeigtErAlsZwischenergebnisSchlaege(int p0)
        {
            _driver.AssertThatAntwortContains("{0}", p0);
            _driver.AssertThatAntwortContains("Zwischenergebnis");
        }

    }
}
