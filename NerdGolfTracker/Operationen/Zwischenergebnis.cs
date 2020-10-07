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
            string outputString = "Dein aktuelles Zwischenergebnis: " + scorecard.AnzahlSchlaege.ToString();

            if(scorecard.AnzahlSchlaege == 1)
            {
                outputString += " Schlag";
            }
            else
            {
                outputString += " Schlaege";
            }

            return outputString;
        }
    }
}
