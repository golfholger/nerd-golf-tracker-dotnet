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

			if (scorecard.Lochnummer < 1)
			{
				return "Die Lochnummer ist ungültig";
			}
			return $"auf dem {scorecard.Lochnummer}.Loch.";
		}
	}
}
