using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NerdGolfTracker.Befehle;

namespace NerdGolfTracker
{
	public class AlleBefehle
	{
		public List<Befehl> Befehle()
		{
			List<Befehl> _alleBefehle = new List<Befehl>();
			foreach (Type type in Assembly.GetAssembly(typeof(Befehl)).GetTypes())
			{
				if (type.IsAbstract == false && typeof(Befehl).IsAssignableFrom(type))
				{
					_alleBefehle.Add((Befehl)Activator.CreateInstance(type));
				}
			}
			return _alleBefehle;
		}
	}
}
