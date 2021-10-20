using System.Collections.Generic;

namespace NerdGolfTracker
{
    public interface Scorecard
    {

        int GetGesamtAnzahlSchlaege();
        int GetAnzahlSchlaege();
        int GetLochnummer();

        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();
 
    }
}