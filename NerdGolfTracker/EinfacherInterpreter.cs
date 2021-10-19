namespace NerdGolfTracker
{
	public class EinfacherInterpreter : Interpreter
	{
		public Operation OperationFuerKommando(string kommando)
		{
			var befehle = new AlleBefehle().Befehle();
			return befehle.Find(befehl => kommando.EndsWith(befehl.Kommando)).Operation;
		}

		public Operation OperationFuerAlias(string alias)
		{
			var befehle = new AlleBefehle().Befehle();

			return befehle.Find(b => alias.EndsWith(b.Alias)).Operation;
		}
	}
}
