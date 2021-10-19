using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdGolfTracker.Operationen
{
	public class UnbekannteEingabe : Operation
	{
		public string FuehreAus(Scorecard scorecard)
		{
			return
				"Ein unbekannter Befehl wurde eingegeben. Verwenden Sie \"Hilfe\" für eine Uebersicht der moeglichen Befehle.";
		}
	}
}
