using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using System;

namespace UnitTests
{
	[TestClass]
	public class EinfacherInterpreterTest
	{
		[TestMethod]
		public void FindetAlleOperationenZubefehlen()
		{
			FindetOperation("Naechstes Loch", "nl", typeof(Lochwechsel));
			FindetOperation("Schlage Ball", "sb", typeof(Schlag));
			FindetOperation("Hilfe", "h", typeof(Hilfe));
			FindetOperation("Loch anzeigen", "la", typeof(Lochausgabe));
			FindetOperation("Irgendwas", "Irgendwas", typeof(UnbekannteEingabe));
			FindetOperation("", "", typeof(UnbekannteEingabe));
		}

		public void FindetOperation(string kommando, string alias, Type operationstyp)
		{
			Interpreter interpreter = new EinfacherInterpreter();
			Assert.IsInstanceOfType(interpreter.OperationFuerKommando(kommando), operationstyp);
			Assert.IsInstanceOfType(interpreter.OperationFuerAlias(alias), operationstyp);
		}
	}
}
