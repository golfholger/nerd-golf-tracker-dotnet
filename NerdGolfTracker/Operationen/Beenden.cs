using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Beenden : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.SchliesseSpielAb();
            return "Beende Anwendung";
        }

        private string HilfstextFuer(Befehl befehl)
        {
            return $" * \"{befehl.Kommando}\" {befehl.Erklaerung}";
        }
    }
}