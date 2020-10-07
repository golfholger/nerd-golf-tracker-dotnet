using NerdGolfTracker.Befehle;
using System.Runtime.CompilerServices;

namespace NerdGolfTracker
{
    public class Tracker
    {
        private readonly Operation _startoperation;
        private readonly Scorecard _scorecard;
        private readonly Interpreter _interpreter;
        private bool _beendenAngefordert;

        public Tracker(Interpreter interpreter, Operation startoperation)
        {
            _interpreter = interpreter;
            _startoperation = startoperation;
            _scorecard = new EinfacheScorecard();
            _beendenAngefordert = false;
        }

        public bool BeendenAngefordert
        {
            get
            {
                return _beendenAngefordert;
            }
        }

        public string ReagiereAuf(string kommando)
        {
			var operation = _interpreter.OperationFuer(kommando);

			if (operation == null)
			{
				var hinweisText = "Die gemachte Eingabe konnte keinem gueltigen Befehl zugeordnet werden!" + System.Environment.NewLine + System.Environment.NewLine;
				var hilfeText = new HilfeBefehl().Operation.FuehreAus(_scorecard);
				return hinweisText + hilfeText;
			}
			else
			{
                if (operation is NerdGolfTracker.Operationen.Beenden)
                {
                    _beendenAngefordert = true;
                }
				return operation.FuehreAus(_scorecard);
			}
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}