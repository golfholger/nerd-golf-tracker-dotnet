namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} "
                + (scorecard.AnzahlSchlaegeAktuellesLoch == 1 ? "Schlag" : "Schlaege") + " ";
        }
    }
}