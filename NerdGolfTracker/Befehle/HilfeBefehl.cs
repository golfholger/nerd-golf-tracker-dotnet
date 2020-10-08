using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace NerdGolfTracker.Befehle
{
    public class HilfeBefehl : Befehl
    {
        public List<string> Kommandos => new List<string>(new string[] { "Hilfe", "H" });

        public Operation Operation => new Hilfe();

        public string Erklaerung => "zeigt Dir diese Erklaerung";
    }
}