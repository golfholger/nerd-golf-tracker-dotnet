using System.Security.Cryptography;

namespace NerdGolfTracker
{
    public interface Scorecard
    {
        int AnzahlSchlaege { get; }

        int AnzahlSchlaegeAktuellesLoch { get; }

        int Lochnummer { get; }

        bool SpielAbgeschlossen { get; }

        void ErhoeheAnzahlSchlaege();
        void SchliesseLochAb();
		void Undo();

        void SchliesseSpielAb();
	}
}