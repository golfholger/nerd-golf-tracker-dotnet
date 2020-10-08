using System.Collections.Generic;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker.Operationen
{
    public class UnbekannteOperation : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
			return "Die gemachte Eingabe konnte keinem gueltigen Befehl zugeordnet werden!" + System.Environment.NewLine + System.Environment.NewLine + new HilfeBefehl().Operation.FuehreAus(scorecard);
        }
    }
}