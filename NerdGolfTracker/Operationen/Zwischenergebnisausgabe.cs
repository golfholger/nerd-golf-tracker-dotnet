namespace NerdGolfTracker.Operationen
{
    public class Zwischenergebnisausgabe : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            var gesamtAnzahlSchlaege = scorecard.GetGesamtAnzahlSchlaege();

            if (gesamtAnzahlSchlaege == 1)
            {
                return $"Du hast {gesamtAnzahlSchlaege} Schlag.";
            }

            return $"Du hast {gesamtAnzahlSchlaege} Schlaege.";
        }
    }
}