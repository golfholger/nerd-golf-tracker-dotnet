using System;
using NerdGolfTracker;
using NerdGolfTracker.Operationen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            FindetOperation("Beenden", typeof(Beenden));
            FindetOperation("Zwischenergebnis", typeof(Zwischenergebnis));
            FindetOperation("Undo", typeof(Undo));

            //Kurzbefehle
            FindetOperation("N", typeof(Lochwechsel));
            FindetOperation("S", typeof(Schlag));
            FindetOperation("H", typeof(Hilfe));
            FindetOperation("B", typeof(Beenden));
            FindetOperation("Z", typeof(Zwischenergebnis));
            FindetOperation("U", typeof(Undo));
        }
		
		[TestMethod]
		public void UnbekannteEingabe()
		{
			Interpreter interpreter = new EinfacherInterpreter();
			Assert.IsNull(interpreter.OperationFuer("Unbekannte Eingabe"));
		}

		public void FindetOperation(string kommando, Type operationstyp)
        {
            Interpreter interpreter = new EinfacherInterpreter();
            Assert.IsInstanceOfType(interpreter.OperationFuer(kommando), operationstyp);
        }
    }
}
