namespace NerdGolfTracker
{
	public interface Interpreter
	{
		Operation OperationFuerKommando(string kommando);
		Operation OperationFuerAlias(string alias);
	}
}
