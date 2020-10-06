namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        private readonly Operation _folgeOperation;

        public Schlagausgabe(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            if(scorecard.AnzahlSchlaegeAktuellesLoch == 1)
			{
                return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} Schlag {_folgeOperation.FuehreAus(scorecard)}";
            }
			else
			{
                return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} Schlaege {_folgeOperation.FuehreAus(scorecard)}";
            }
        }
    }
}