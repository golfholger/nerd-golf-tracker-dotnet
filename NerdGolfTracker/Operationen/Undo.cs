namespace NerdGolfTracker.Operationen
{
    public class Undo : Operation
    {
        private readonly Operation _folgeOperation;

        public Undo(Operation folgeOperation)
        {
            _folgeOperation = folgeOperation;
        }

        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.Undo();
            return _folgeOperation.FuehreAus(scorecard);
        }
    }
}