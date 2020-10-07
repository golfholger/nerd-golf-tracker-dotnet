using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
    public class UndoBefehl : Befehl
    {
        public string Kommando => "Undo";

        public Operation Operation => new Undo(new Schlagausgabe(new Lochausgabe()));

        public string Erklaerung => "macht einen Schlag rueckgaengig";
    }
}