namespace NerdGolfTracker
{
	public interface Befehl
	{
		string Kommando { get; }
		string Alias { get; }
		Operation Operation { get; }
		string Erklaerung { get; }
	}
}
