using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class Beenden : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            System.Environment.Exit(0);
            return "Beende Anwendung";
        }

        private string HilfstextFuer(Befehl befehl)
        {
            return $" * \"{befehl.Kommando}\" {befehl.Erklaerung}";
        }
    }
}