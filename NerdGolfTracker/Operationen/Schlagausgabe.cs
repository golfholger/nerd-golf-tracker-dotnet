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
            if (scorecard.GetAnzahlSchlaege() > 1) schlagWort = "Schlaege";
            return $"Du hast {scorecard.GetAnzahlSchlaege()} {schlagWort} {_folgeOperation.FuehreAus(scorecard)}";
        }
    }
}