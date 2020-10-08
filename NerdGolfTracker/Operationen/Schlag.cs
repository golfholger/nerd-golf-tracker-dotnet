namespace NerdGolfTracker.Operationen
{
    public class Schlag : Operation
    {
        private readonly Operation _folgeOperation;

        public Schlag(Operation folgeOperation = null)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.ErhoeheAnzahlSchlaege();
            if(_folgeOperation != null)
			{
                return _folgeOperation.FuehreAus(scorecard);
            }

            return "";
        }
    }
}