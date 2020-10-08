namespace NerdGolfTracker.Operationen
{
    public class Schlagausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            return $"Du hast {scorecard.AnzahlSchlaegeAktuellesLoch} "
                + FormatHelper.SchlagNomen(scorecard.AnzahlSchlaegeAktuellesLoch) + " ";
        }
    }
}