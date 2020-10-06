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
            if(scorecard.AnzahlSchlaege == 1)
			{
                return $"Du hast {scorecard.AnzahlSchlaege} Schlag {_folgeOperation.FuehreAus(scorecard)}";
            }
			else
			{
                return $"Du hast {scorecard.AnzahlSchlaege} Schlaege {_folgeOperation.FuehreAus(scorecard)}";
            }
        }
    }
}