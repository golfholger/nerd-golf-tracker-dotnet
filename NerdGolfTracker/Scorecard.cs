using System.Security.Cryptography;

namespace NerdGolfTracker
{
    public interface Scorecard
    {
        int AnzahlSchlaege { get; }

        int AnzahlSchlaegeAktuellesLoch { get; }

        int Lochnummer { get; }

        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();
		void Undo();
	}
}