using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class BeendenBefehl : Befehl
    {
        public string Kommando => "Beenden";

        public Operation Operation => new Beenden();

        public string Erklaerung => "Beendet Anwendung";
    }
}