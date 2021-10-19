using System.Collections.Generic;
using System.Linq;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
    public class EinfacherInterpreter : Interpreter
    {
        public Operation OperationFuer(string kommando)
        {
            var befehle = new AlleBefehle().Befehle();
            Befehl gefundenerBefehl = befehle.FirstOrDefault(befehl => kommando.EndsWith(befehl.Kommando));
            if (gefundenerBefehl != null)
            {
				return gefundenerBefehl.Operation;
            }

			return new UnbekannteEingabe();

        }
    }
}
