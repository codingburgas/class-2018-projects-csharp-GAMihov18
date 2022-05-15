using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorLib.Values;
namespace GeneratorLib.Types
{
	public interface IWeapon : IEquipable, IItem
	{
		double AssemblyDamage { get; }
		double PhysicalDamage { get; }
		double MagicalDamage { get; }
		double CritRate	{ get; }
		double CritMult { get; }
		WEAPON_VALUES.TYPE WeaponType { get; }
		COMMON_VALUES.RARITY Rarity { get; }
		WEAPON_VALUES.DAMAGE_TYPE PhysicalDamageType { get; }
		WEAPON_VALUES.DAMAGE_TYPE MagicalDamageType { get; }
	}
}
