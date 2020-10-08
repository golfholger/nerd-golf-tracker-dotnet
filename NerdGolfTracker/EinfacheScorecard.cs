using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {
        List<int> anzahlSchlaege = new List<int>();
        bool _spielAbgeschlossen = false;

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

        public bool SpielAbgeschlossen
        {
            get
            {
                return _spielAbgeschlossen;
            }
        }


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

        public void SchliesseSpielAb()
        {
            _spielAbgeschlossen = true;
        }
    }
}