using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class SchlagBefehl : Befehl
    {
        public string Kommando => "Schlage Ball";

        public Operation Operation => new KombiOperation(new Schlag(), new Schlagausgabe(), new Lochausgabe());

        public string Erklaerung => "zaehlt einen Schlag (Default-Kommando mit Return)";
    }
}