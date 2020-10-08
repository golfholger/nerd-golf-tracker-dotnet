namespace NerdGolfTracker.Operationen
{
    public class Schlag : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            return "";
        }
    }
}