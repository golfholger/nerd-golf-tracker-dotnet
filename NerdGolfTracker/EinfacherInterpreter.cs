using System.Collections.Generic;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            var befehle = new AlleBefehle().Befehle();

			foreach (Befehl b in befehle)
			{
                if (b.Kommando.StartsWith(kommando))
                    return b.Operation;
			}
            return null;
        }
    }
}
