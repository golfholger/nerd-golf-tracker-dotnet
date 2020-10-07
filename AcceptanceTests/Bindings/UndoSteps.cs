using System;
using AkzeptanzTests;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Bindings
{
    [Binding]
    public class UndoSteps
    {
        private readonly TrackerDriver _driver;

        public UndoSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich den Schlag rueckgaengig mache")]
        public void WhenIchDenSchlagRueckgaengigMache()
        {
            _driver.EmpfangeAnweisung("Undo");
        }
    }
}
