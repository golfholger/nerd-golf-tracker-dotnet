using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace NerdGolfTracker.Befehle
{
    public class ZwischenErgebnisBefehl : Befehl
    {
        public List<string> Kommandos => new List<string>(new string[] { "Zwischenergebnis", "Z" });

        public Operation Operation => new Zwischenergebnis();

        public string Erklaerung => "zeigt dir das aktuelle Zwischenergebnis an";
    }
}