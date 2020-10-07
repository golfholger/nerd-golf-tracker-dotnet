using System.Collections.Generic;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            var befehle = new AlleBefehle().Befehle();

            string badString = "∩╗┐"; //possible error due to encoding issues
            string subkommando = kommando.Replace(badString, "");          

            foreach (Befehl b in befehle)
			{
                if (b.Kommando.StartsWith(subkommando))
                    return b.Operation;
			}
            return null;
        }
    }
}
