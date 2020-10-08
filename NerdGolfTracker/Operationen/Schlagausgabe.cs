namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {

        public string FuehreAus(Scorecard scorecard)
        {
            if(scorecard.AnzahlSchlaegeAktuellesLoch == 1)
			{
                return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} Schlag ";
            }
			else
			{
                return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} Schlaege ";
            }
        }
    }
}