using AkzeptanzTests;
using System;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Bindings
{
    [Binding]
    public class KurzbefehlSteps
    {
        private TrackerDriver _driver;

        public KurzbefehlSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich den Kurzbefehl ""(.*)"" verwende")]
        public void WhenIchDenKurzbefehlVerwende(string p0)
        {
            _driver.EmpfangeAnweisung(p0);
        }

    }
}
