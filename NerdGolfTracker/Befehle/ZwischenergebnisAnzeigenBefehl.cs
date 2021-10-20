using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
	public class ZwischenergebnisAnzeigenBefehl : Befehl
	{
        public string Kommando => "Zwischenergebnis anzeigen";
        public Operation Operation => new Zwischenergebnisausgabe();
        public string Erklaerung => "Gibt das akutelle Zwischenergebnis aus";
	}
}
