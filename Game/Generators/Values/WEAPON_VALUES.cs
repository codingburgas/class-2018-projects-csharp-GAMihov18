using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib.Values
{
	public struct WEAPON_VALUES
	{
		public enum TYPE
		{
			KNIFE, DAGGER, SHORTSWORD,
			LONGSWORD, BASTARD_SWORD, BOW,
			POLEARM, SPEAR, TWO_HANDED_SWORD,
			HAMMER, MACE, WAR_AXE,
			BATTLE_AXE, RAPIER
		}
		public enum DAMAGE_TYPE
		{
			SLASHING, PIERCING, BLUNT, FIRE, WATER, EARTH, AIR, VOID, LUX
		}

		public static string ToString(WEAPON_VALUES.TYPE type)
		{
			switch (type)
			{
				case TYPE.KNIFE:
					return "Knife";
				case TYPE.DAGGER:
					return "Dagger";
				case TYPE.SHORTSWORD:
					return "Short Sword";
				case TYPE.LONGSWORD:
					return "Long Sword";
				case TYPE.BASTARD_SWORD:
					return "Bastard Sword";
				case TYPE.BOW:
					return "Bow";
				case TYPE.POLEARM:
					return "Polearm";
				case TYPE.SPEAR:
					return "Spear";
				case TYPE.TWO_HANDED_SWORD:
					return "Two-handed Sword";
				case TYPE.HAMMER:
					return "Hammer";
				case TYPE.MACE:
					return "Mace";
				case TYPE.WAR_AXE:
					return "War Axe";
				case TYPE.BATTLE_AXE:
					return "Battle Axe";
				case TYPE.RAPIER:
					return "Rapier";
				default:
					return "Error";

			}
		}
		public static string ToString(WEAPON_VALUES.DAMAGE_TYPE dType)
		{
			switch (dType)
			{
				case DAMAGE_TYPE.SLASHING:
					return "Slashing";
				case DAMAGE_TYPE.PIERCING:
					return "Piercing";
				case DAMAGE_TYPE.BLUNT:
					return "Bludgeoning";
				case DAMAGE_TYPE.FIRE:
					return "Fire";
				case DAMAGE_TYPE.WATER:
					return "Water";
				case DAMAGE_TYPE.EARTH:
					return "Earth";
				case DAMAGE_TYPE.AIR:
					return "Air";
				case DAMAGE_TYPE.VOID:
					return "Void";
				case DAMAGE_TYPE.LUX:
					return "Lux";
				default:
					return "Error";
			}
		}
	}
}
