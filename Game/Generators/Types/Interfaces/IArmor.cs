using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorLib.Values;
namespace GeneratorLib.Types
{
	public interface IArmor : IEquipable, IItem
	{
		double AssemblyProtection { get; }
		double PhysicalProtection { get; }
		double MagicalProtection { get; }
		Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double> Resistances { get; }
		double CurrentDurability { get; }
		double Durability { get; }
 		COMMON_VALUES.RARITY Rarity { get; }
		ARMOR_VALUES.EQUIP_SLOT EquipSlot { get; }
		Dictionary<int, ARMOR_VALUES.PROTECTING_AREA> ProtectionAreas { get; }
		ARMOR_VALUES.TYPE Type { get; }
		void ReceiveDamageFrom(IWeapon weapon);
	}
}