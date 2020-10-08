using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace NerdGolfTracker.Befehle
{
    public class BeendenBefehl : Befehl
    {
        public List<string> Kommandos => new List<string>(new string[] {"Beenden" , "B"});

        public Operation Operation => new Beenden();

        public string Erklaerung => "Beendet Anwendung";
    }
}