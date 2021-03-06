﻿using NerdGolfTracker.Befehle;
using NerdGolfTracker.Operationen;
using System.Runtime.CompilerServices;

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

        public bool BeendenAngefordert
        {
            get
            {
                return _scorecard.SpielAbgeschlossen;
            }
        }

        public string ReagiereAuf(string kommando)
        {
			var operation = _interpreter.OperationFuer(kommando);
			return operation.FuehreAus(_scorecard);
        }

        public string Starte()
        {
            return _startoperation.FuehreAus(_scorecard);
        }
    }
}