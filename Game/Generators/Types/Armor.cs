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
		/// <summary>
		///Extension for SetProtectionAreas().
		///Driving the addition of additional protection areas to armor pieces.
		/// </summary>
		void SetAdditionalProtectionAreas()
		{
			switch (protectionAreas[0])
			{
				case ARMOR_VALUES.PROTECTING_AREA.HEAD:
					//15% chance to get shoulder protection with helmet
					if (RAND.getRandInt(0,101) > 85)
					{
						protectionAreas.Add(1, ARMOR_VALUES.PROTECTING_AREA.SHOULDERS);
						assemblyProtection += 500;
						assemblyProtection *= 1.5;
						if (RAND.getRandInt(0, 101) > 95)
						{
							protectionAreas.Add(2, ARMOR_VALUES.PROTECTING_AREA.CHEST);
							assemblyProtection += 1000;
							assemblyProtection *= 1.3;
						}
					}
					break;
				case ARMOR_VALUES.PROTECTING_AREA.ARMS:
					//15% chance to get hand protection with sleeve armor
					if (RAND.getRandInt(0, 101) > 85)
					{
						protectionAreas.Add(1, ARMOR_VALUES.PROTECTING_AREA.HANDS);
						assemblyProtection += 120;
						assemblyProtection *= 1.1;
						if (RAND.getRandInt(0, 101) > 95)
						{
							protectionAreas.Add(2, ARMOR_VALUES.PROTECTING_AREA.SHOULDERS);
							assemblyProtection += 500;
							assemblyProtection *= 1.3;
						}
					}
					break;
				case ARMOR_VALUES.PROTECTING_AREA.CHEST:
					//20% chance to get waist protection with chestplate
					if (RAND.getRandInt(0,101) > 80)
					{
						protectionAreas.Add(1,ARMOR_VALUES.PROTECTING_AREA.WAIST);
						assemblyProtection += 100;
						assemblyProtection *= 1.2;
						if (RAND.getRandInt(0,101) > 97)
						{
							protectionAreas.Add(2, ARMOR_VALUES.PROTECTING_AREA.SHOULDERS);
							assemblyProtection += 300;
							assemblyProtection *= 1.1;
						}
					}
					break;
				case ARMOR_VALUES.PROTECTING_AREA.LEGS:
					//30% chance to have feet protection on leggings
					if (RAND.getRandInt(0,101) > 70)
					{
						protectionAreas.Add(1, ARMOR_VALUES.PROTECTING_AREA.FEET);
						assemblyProtection += 100;
						assemblyProtection *= 1.2;
					}
					break;
				default:
					break;
			}
		}
		/// <summary>
		/// Sets the main protection area of armor pieces.
		/// Calls SetAdditionalProtectionAreas() for handling of adding more protection areas to armor pieces.
		/// </summary>
		void SetProtectionAreas()
		{
			protectionAreas = new Dictionary<int, ARMOR_VALUES.PROTECTING_AREA>();
			switch (equipSlot)	
			{
				case ARMOR_VALUES.EQUIP_SLOT.HELMET:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.HEAD);
					SetAdditionalProtectionAreas();
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOULDERPLATES:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.SHOULDERS);
					break;
				case ARMOR_VALUES.EQUIP_SLOT.CHESTPLATE:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.CHEST);
					SetAdditionalProtectionAreas();
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SLEEVES:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.ARMS);
					SetAdditionalProtectionAreas();
					break;
				case ARMOR_VALUES.EQUIP_SLOT.GLOVES:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.HANDS);
					break;
				case ARMOR_VALUES.EQUIP_SLOT.BELT:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.WAIST);
					break;
				case ARMOR_VALUES.EQUIP_SLOT.LEGGINGS:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.LEGS);
					SetAdditionalProtectionAreas();
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOES:
					protectionAreas.Add(0, ARMOR_VALUES.PROTECTING_AREA.FEET);
					break;
				default:
					break;
			}
			
			if ((int)rarity>=4)
			{
				if (RAND.getRandInt(0,101)> 90)
				{

				}
			}
		}
		/// <summary>
		/// Sets the damage resistance types for armor pieces
		/// </summary>
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
