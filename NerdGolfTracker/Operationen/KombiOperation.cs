using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdGolfTracker.Operationen
{
	public class KombiOperation : Operation
	{
		private Operation[] _operationen;

		public KombiOperation(params Operation[] operationen)
		{
			_operationen = operationen;
		}

		public string FuehreAus(Scorecard scorecard)
		{
			string result = "";

			foreach(Operation operation in _operationen)
			{
				result += operation.FuehreAus(scorecard);
			}

			return result;
		}
	}
}
