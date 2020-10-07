using System.Collections.Generic;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            var befehle = new AlleBefehle().Befehle();
            var eingabeBefehl =  befehle.Find(befehl => kommando.EndsWith(befehl.Kommando));

			return eingabeBefehl == null ? null : eingabeBefehl.Operation;
		}
    }
}
