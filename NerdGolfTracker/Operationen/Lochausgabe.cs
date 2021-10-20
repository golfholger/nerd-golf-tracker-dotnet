namespace NerdGolfTracker.Operationen
{
	public class Lochausgabe : Operation
	{
		public string FuehreAus(Scorecard scorecard)
		{
			if (scorecard == null)
			{
				return "Es existiert keine Scorecard";

			}

			if (scorecard.GetLochnummer() < 1)
			{
				return "Die Lochnummer ist ungültig";
			}

			return $"auf dem {scorecard.GetLochnummer()}.Loch.";
		}
	}
}
