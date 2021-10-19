﻿using NerdGolfTracker.Operationen;

namespace NerdGolfTracker.Befehle
{
	public class LochausgabeBefehl : Befehl
	{
		public string Kommando => "Loch anzeigen";
		public Operation Operation => new Lochausgabe();
		public string Erklaerung => "Gibt das akutelle Loch aus";
	}
}
