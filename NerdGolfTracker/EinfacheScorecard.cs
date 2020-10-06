using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    { 
        public int AnzahlSchlaegeAktuellesLoch
        {
            get
            {
                return anzahlSchlaege[Lochnummer - 1];
            }
        }

        public int Lochnummer { get; private set; }

        public int AnzahlSchlaege 
        { 
            get
            {
                return anzahlSchlaege.Sum();
            }
        }

        int[] anzahlSchlaege;

        public EinfacheScorecard()
        {
            Lochnummer = 1;
            anzahlSchlaege = new int[18];
        }

        public void SchliesseLochAb()
        {
            Lochnummer++;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            anzahlSchlaege[Lochnummer - 1]++;
        }
    }
}