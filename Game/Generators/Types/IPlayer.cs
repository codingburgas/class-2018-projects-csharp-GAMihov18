using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorLib.Values;

namespace GeneratorLib.Types
{
	public interface IPlayer
	{
		public string Name { get; }
		public IWeapon? MainHand { get; }
		public IEquipable? OffHand { get; }
		public IArmor? Head { get; }
		public IArmor? Shoulders { get; }
		public IArmor? Arms { get; }
		public IArmor? Hands { get; }
		public IArmor? Waist { get; }
		public IArmor? Chest { get; }
		public IArmor? Legs { get; }
		public IArmor? Feet { get; }

		public double Health { get; }
		public double Stamina { get; }
		public double StaminaRegenerationRate { get; }
		public double Mana { get; }
		public double ManaRegenerationRate { get; }
		public List<IItem> Inventory { get; }
		public bool ReceiveDamage(IPlayer player, ARMOR_VALUES.PROTECTING_AREA targetArea);
}
}
