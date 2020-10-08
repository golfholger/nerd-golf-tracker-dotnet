using NerdGolfTracker.Operationen;
using System.Collections.Generic;

namespace NerdGolfTracker.Befehle
{
    public class UndoBefehl : Befehl
    {
        public List<string> Kommandos => new List<string>(new string[] { "Undo", "U" });

        public Operation Operation => new KombiOperation(new Undo(), new Schlagausgabe(), new Lochausgabe());

        public string Erklaerung => "macht einen Schlag rueckgaengig";
    }
}