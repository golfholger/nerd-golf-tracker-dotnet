using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : Befehl
    {
        public List<string> Kommandos => new List<string>(new string[] { "Schlage Ball", "S", string.Empty });

        public Operation Operation => new KombiOperation(new Schlag(), new Schlagausgabe(), new Lochausgabe());

        public string Erklaerung => "zaehlt einen Schlag (Default-Kommando mit Return)";
    }
}