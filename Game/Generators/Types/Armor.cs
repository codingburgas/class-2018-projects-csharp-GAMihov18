using GeneratorLib.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFMiscLib.RandomNumber;
namespace GeneratorLib.Types
{
	public class Armor : IArmor
	{
		private string name;
		private double assemblyProtection;
		private double physicalProtection;
		private double magicalProtection;
		private Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double> resistances;
		private double currentDurability;
		private double durability;
		private COMMON_VALUES.RARITY rarity;
		private ARMOR_VALUES.EQUIP_SLOT equipSlot;
		private Dictionary<int, ARMOR_VALUES.PROTECTING_AREA> protectionAreas;
		private ARMOR_VALUES.TYPE type;
		public string Name => name;
		public double AssemblyProtection => assemblyProtection;
		public double PhysicalProtection => physicalProtection;
		public double MagicalProtection => magicalProtection;
		public Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double> Resistances => resistances;
		public double CurrentDurability => currentDurability;
		public double Durability => durability;
		public COMMON_VALUES.RARITY Rarity => rarity;
		public ARMOR_VALUES.EQUIP_SLOT EquipSlot => equipSlot;
		public Dictionary<int, ARMOR_VALUES.PROTECTING_AREA> ProtectionAreas => protectionAreas;
		public ARMOR_VALUES.TYPE Type => type;

		public Armor()
		{
			assemblyProtection = RAND.getRandDouble(300, 3001);
			resistances = new Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double>();
			type = (ARMOR_VALUES.TYPE)RAND.getRandInt(0, 3);
			rarity = (COMMON_VALUES.RARITY)RAND.getRandInt(0, 7);
			equipSlot = (ARMOR_VALUES.EQUIP_SLOT)RAND.getRandInt(0, 8);
			SetProtectionAreas();
			DecideResistances();
			SetName();
		}

		void SetProtectionAreas()
		{

		}

		void DecideResistances()
		{
			switch (type)
			{
				case ARMOR_VALUES.TYPE.HEAVY:
					if ((int)rarity>=3)
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, RAND.getRandDouble(15, 41));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, RAND.getRandDouble(-20, 1));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, RAND.getRandDouble(-20, 16));
					}
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE    , RAND.getRandDouble(0, 11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER   , RAND.getRandDouble(0, 11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH   , RAND.getRandDouble(0, 11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR     , RAND.getRandDouble(0, 11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX     , RAND.getRandDouble(0, 11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID    , RAND.getRandDouble(0, 11));
					break;
				case ARMOR_VALUES.TYPE.MEDIUM:
					if ((int)rarity >= 3)
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, RAND.getRandDouble(0, 16));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, RAND.getRandDouble(-10, 11));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, RAND.getRandDouble(0, 21));
					}
					
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE    , RAND.getRandDouble(0, 21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER   , RAND.getRandDouble(0, 21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH   , RAND.getRandDouble(0, 21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR     , RAND.getRandDouble(0, 21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX     , RAND.getRandDouble(0, 21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID    , RAND.getRandDouble(0, 21));
					break;
				case ARMOR_VALUES.TYPE.LIGHT:
					if ((int)rarity >= 3)
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, RAND.getRandDouble(-15, 1));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, RAND.getRandDouble(0, 11));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, RAND.getRandDouble(10, 31));
					}

					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE    , RAND.getRandDouble(10, 51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER   , RAND.getRandDouble(10, 51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH   , RAND.getRandDouble(10, 51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR     , RAND.getRandDouble(10, 51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX     , RAND.getRandDouble(10, 51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID    , RAND.getRandDouble(10, 51));
					break;
				default:
					break;
			}
		}
		void SetName()
		{

		}
		public bool Equip()
		{
			throw new NotImplementedException();
		}
	}
}
