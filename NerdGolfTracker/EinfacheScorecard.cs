using System.Collections.Generic;
using System.Linq;

namespace NerdGolfTracker
{
    public class EinfacheScorecard : Scorecard
    {


        public EinfacheScorecard()
        {
            LochSchlaege = new Dictionary<int, int>();
            LochSchlaege.Add(1, 0);
        }

        public void SchliesseLochAb()
        {
            LochSchlaege.Add(LochSchlaege.Keys.Count + 1, 0);
        }

        public Dictionary<int, int> LochSchlaege { get; }


        public int GetAnzahlSchlaege()
        {
            return LochSchlaege[LochSchlaege.Count];
        }

        public int GetGesamtAnzahlSchlaege()
        {
            var gesamt = LochSchlaege.Values.Sum();
            return gesamt;
        }

        public int GetLochnummer()
        {
            return LochSchlaege.Count;
        }

        public void ErhoeheAnzahlSchlaege()
        {
            LochSchlaege[LochSchlaege.Keys.Count] = LochSchlaege[LochSchlaege.Keys.Count] + 1;
        }
    }
}