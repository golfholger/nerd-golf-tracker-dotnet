using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AkzeptanzTests;
using TechTalk.SpecFlow;

namespace AcceptanceTests.Bindings
{
	[Binding]
	public sealed class Gross_und_KleinschreibungSteps
	{
		private TrackerDriver _driver;

		/// <summary>Initialisiert eine neue Instanz der <see cref="T:System.Object" />-Klasse.</summary>
		public Gross_und_KleinschreibungSteps(TrackerDriver driver)
		{
			_driver = driver;
		}

		[When(@"ich ""(.*)"" eingebe")]
		public void EmpfangeKommandoInGrossOderKleinschreibung(string kommando)
		{
			_driver.EmpfangeAnweisung(kommando);
		}
	}
}
