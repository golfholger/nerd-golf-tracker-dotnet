using NerdGolfTracker.Befehle;
using System.Collections.Generic;

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
				new SchlagBefehl(),
				new LochausgabeBefehl(),
			};
			return befehle;
		}
	}
}
