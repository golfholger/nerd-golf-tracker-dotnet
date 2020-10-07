using AkzeptanzTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Bindings
{
    [Binding]
    public class BeendenSteps
    {
        private readonly TrackerDriver _driver;

        public BeendenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [When(@"ich den Befehl zum Beenden des Programmes gebe")]
        public void BefehlBeendeDasProgramm()
        {
            _driver.EmpfangeAnweisung("Beenden");
        }

        [Then(@"laeuft das ausgefuehrte Programm nicht mehr")]
        public void ThenLaeuftDasAusgefuehrteProgrammNichtMehr()
        {
            _driver.AssertThatDriverExited();
        }
    }
}
