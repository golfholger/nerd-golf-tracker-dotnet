using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class LochwechselBefehl : Befehl
    {
        public string Kommando => "[N]aechstes Loch";

        public Operation Operation => new Lochwechsel(new Lochbegruessung(new Lochausgabe()));

        public string Erklaerung => "bringt Dich zum naechsten Loch";
    }
}