using NerdGolfTracker.Befehle;
using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            var befehle = new AlleBefehle().Befehle();

			if (kommando == "")
				return new SchlagBefehl().Operation;

			foreach (Befehl b in befehle)
			{
                if (b.Kommando.StartsWith(kommando))
                    return b.Operation;
			}
            return null;
        }
    }
}
