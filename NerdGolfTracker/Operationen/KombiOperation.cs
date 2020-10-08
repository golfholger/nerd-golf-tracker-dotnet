using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdGolfTracker.Operationen
{
	public class KombiOperation : Operation
	{
		public Operation[] Operationen { private set; get; }

		public KombiOperation(params Operation[] operationen)
		{
			Operationen = operationen;
		}

		public string FuehreAus(Scorecard scorecard)
		{
			string result = "";

			foreach(Operation operation in Operationen)
			{
				result += operation.FuehreAus(scorecard);
			}

			return result;
		}
	}
}
