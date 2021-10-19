using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
    public class AlleBefehle
    {
        public List<Befehl> Befehle()
        {
            var befehle = new List<Befehl>
            {
                new HilfeBefehl(),
                new LochwechselBefehl(),
                new SchlagBefehl()
            };
            return befehle;
        }
    }
}
