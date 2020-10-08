using System.Collections.Generic;

namespace NerdGolfTracker
{
    public interface Befehl
    {
        List<string> Kommandos { get; }
        Operation Operation { get; }
        string Erklaerung { get; }
    }
}