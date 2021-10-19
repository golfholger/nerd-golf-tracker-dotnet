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
            string schlagWort = "Schlag";
            if (scorecard.AnzahlSchlaege > 1) schlagWort = "Schlaege";
            return $"Du hast {scorecard.AnzahlSchlaege} {schlagWort} {_folgeOperation.FuehreAus(scorecard)}";
        }
    }
}