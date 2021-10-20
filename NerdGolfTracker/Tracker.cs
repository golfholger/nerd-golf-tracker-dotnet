using NerdGolfTracker.Operationen;

namespace NerdGolfTracker
{
	public class Tracker
	{
		private readonly Operation _startoperation;
		private readonly Scorecard _scorecard;
		private readonly Interpreter _interpreter;

		public Tracker(Interpreter interpreter, Operation startoperation)
		{
			_interpreter = interpreter;
			_startoperation = startoperation;
			_scorecard = new EinfacheScorecard();
		}

		public string ReagiereAuf(string input)
		{
			Operation kommandOperation = _interpreter.OperationFuerKommando(input);
			if (kommandOperation != null && !(kommandOperation is UnbekannteEingabe))
			{
				return kommandOperation.FuehreAus(_scorecard);
			}

			Operation aliasOperation = _interpreter.OperationFuerAlias(input);
			if (aliasOperation != null && !(aliasOperation is UnbekannteEingabe))
			{
				return aliasOperation.FuehreAus(_scorecard);
			}

			return new UnbekannteEingabe().FuehreAus(_scorecard);
		}

		public string Starte()
		{
			return _startoperation.FuehreAus(_scorecard);
		}
	}
}
