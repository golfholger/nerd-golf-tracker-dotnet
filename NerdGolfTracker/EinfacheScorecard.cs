using System.Collections.Generic;
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

        List<int> anzahlSchlaege = new List<int>();

        public EinfacheScorecard()
        {
            Lochnummer = 1;
            anzahlSchlaege.Add(0);
        }

        public void SchliesseLochAb()
        {
            Lochnummer++;
            anzahlSchlaege.Add(0);
        }

        public void ErhoeheAnzahlSchlaege()
        {
            anzahlSchlaege[Lochnummer - 1]++;
        }

        public void Undo()
        {
            if(anzahlSchlaege[Lochnummer - 1] > 0)
                anzahlSchlaege[Lochnummer - 1]--;
        }
    }
}