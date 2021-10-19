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
			FindetOperation("Naechstes Loch", typeof(Lochwechsel));
			FindetOperation("Schlage Ball", typeof(Schlag));
			FindetOperation("Hilfe", typeof(Hilfe));
			FindetOperation("Loch anzeigen", typeof(Lochausgabe));
		}

		public void FindetOperation(string kommando, Type operationstyp)
		{
			Interpreter interpreter = new EinfacherInterpreter();
			Assert.IsInstanceOfType(interpreter.OperationFuer(kommando), operationstyp);
		}
	}
}
