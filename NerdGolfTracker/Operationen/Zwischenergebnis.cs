using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdGolfTracker.Operationen
{
    public class Zwischenergebnis : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return "Dein aktuelles Zwischenergebnis: "
                + $"{scorecard.AnzahlSchlaege} "
                + (scorecard.AnzahlSchlaege == 1 ? "Schlag" : "Schlaege");
		}
    }
}
