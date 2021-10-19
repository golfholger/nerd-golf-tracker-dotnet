namespace NerdGolfTracker
{
	public class EinfacherInterpreter : Interpreter
	{
		public Operation OperationFuerKommando(string kommando)
		{
			var befehle = new AlleBefehle().Befehle();
			Befehl gesuchterBefehl = befehle.Find(befehl => kommando.EndsWith(befehl.Kommando));
			if (gesuchterBefehl != null)
			{
				return gesuchterBefehl.Operation;
			}
			return null;
		}

		public Operation OperationFuerAlias(string alias)
		{
			var befehle = new AlleBefehle().Befehle();

			Befehl gesuchterBefehl = befehle.Find(befehl => alias.EndsWith(befehl.Alias));
			if (gesuchterBefehl != null)
			{
				return gesuchterBefehl.Operation;
			}
			return null;
		}
	}
}
