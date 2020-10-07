using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace AkzeptanzTests.Bindings
{
    [Binding]
    public class SchlaegeZaehlenSteps
    {
        private readonly TrackerDriver _driver;

        public SchlaegeZaehlenSteps(TrackerDriver driver)
        {
            _driver = driver;
        }

        [Then(@"zaehlt.* (\d+) (Schlag|Schlaege)")]
        public void PruefeSchlagzahl(int schlagzahl, string schlagnomen)
        {
			try
			{
				_driver.AssertThatAntwortContains("{0}", schlagzahl);
				_driver.AssertThatAntwortContains("{0}", schlagnomen);
			}
			catch (System.Exception)
			{

				throw;
			}
			finally
			{
                Debug.WriteLine("Console output during test:");
                Debug.WriteLine(_driver._antwort);
                Console.WriteLine("Console output during test:");
                Console.WriteLine(_driver._antwort);
            }
        }
    }
}