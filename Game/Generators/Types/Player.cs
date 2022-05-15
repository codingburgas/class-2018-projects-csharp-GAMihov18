using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib.Types
{
	public class Player
	{
		string name;
		IEquipable mainHand;
		IEquipable offHand;

		IArmor head;
		IArmor shoulders;
		IArmor arms;
		IArmor hands;
		IArmor waist;
		IArmor chest;
		IArmor legs;
		IArmor feet;
		Dictionary<string, int[]> stats = new Dictionary<string, int[]>();

	}
}
