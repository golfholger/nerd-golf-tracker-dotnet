using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : Befehl
    {
        public List<string> Kommandos => new List<string>(new string[] { "Naechstes Loch", "N" });

        public Operation Operation => new KombiOperation(new Lochwechsel(), new Lochbegruessung(), new Lochausgabe());

        public string Erklaerung => "bringt Dich zum naechsten Loch";
    }
}