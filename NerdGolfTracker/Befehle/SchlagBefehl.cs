using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
	public class SchlagBefehl : Befehl
	{
		public string Kommando => "Schlage Ball";
		public string Alias => "sb";

		public Operation Operation => new Schlag(new Schlagausgabe(new Lochausgabe()));

		public string Erklaerung => "zaehlt einen Schlag";
	}
}
