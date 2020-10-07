using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class ZwischenErgebnisBefehl : Befehl
    {
        public string Kommando => "Zwischenergebnis";

        public Operation Operation => new Zwischenergebnis();

        public string Erklaerung => "zeigt dir das aktuelle Zwischenergebnis an";
    }
}