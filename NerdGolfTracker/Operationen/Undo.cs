namespace NerdGolfTracker.Operationen
{
    public class Undo : Operation
    {
        public string FuehreAus(Scorecard scorecard)
        {
            scorecard.Undo();
            return "";
        }
    }
}