using System;
using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
	public class EinfacherInterpreter : Interpreter
	{
		public Operation OperationFuerKommando(string kommando)
		{
			var befehle = new AlleBefehle().Befehle();
			Befehl gesuchterBefehl = befehle.Find(befehl => kommando.EndsWith(befehl.Kommando, StringComparison.InvariantCultureIgnoreCase));
			if (gesuchterBefehl != null)
			{
				return gesuchterBefehl.Operation;
			}
			return new UnbekannteEingabe();
		}

		public Operation OperationFuerAlias(string alias)
		{
			var befehle = new AlleBefehle().Befehle();

			Befehl gesuchterBefehl = befehle.Find(befehl => alias.EndsWith(befehl.Alias, StringComparison.InvariantCultureIgnoreCase));
			if (gesuchterBefehl != null)
			{
				return gesuchterBefehl.Operation;
			}
			return new UnbekannteEingabe();
		}
	}
}
