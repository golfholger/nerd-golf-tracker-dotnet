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
            return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} "
                + (scorecard.AnzahlSchlaegeAktuellesLoch == 1 ? "Schlag" : "Schlaege")
                + $" {_folgeOperation.FuehreAus(scorecard)}";
        }
    }
}