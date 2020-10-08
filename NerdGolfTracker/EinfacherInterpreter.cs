using NerdGolfTracker.Befehle;
using NerdGolfTracker.Operationen;
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

            string badString = "∩╗┐"; //possible error due to encoding issues
            string subkommando = kommando.Replace(badString, "");          

            foreach (Befehl b in befehle)
			{
                if (b.Kommando.StartsWith(subkommando))
                    return b.Operation;
			}

            return new UnbekannteOperation();
        }
    }
}
