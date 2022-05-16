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

		public string GetData(bool isReadable)
		{
			return GetArmorData(isReadable);
		}
		private string GetArmorData(bool isReadable)
		{
			string resistances = "";
			string protectionAreas = "";
			if (isReadable)
			{
				foreach (var resistance in this.resistances)
				{
					resistances += $"\t- {WEAPON_VALUES.ToString(resistance.Key)}: {resistance.Value:p}\n";
				}
				foreach (var protectionArea in this.protectionAreas)
				{
					protectionAreas += $"\t- {ARMOR_VALUES.ToString(protectionArea.Value)}\n";
				}
				return $"Name: {name}\n" +
					$"Assembly Protection: {assemblyProtection:f2}\n" +
					$"Physical Protection: {physicalProtection:f2}\n" +
					$"Magical Protection: {magicalProtection:f2}\n" +
					$"Resistances:\n{resistances}" +
					$"Durability(current/max): {currentDurability:f2}/{durability:f2}\n" +
					$"Rarity: {COMMON_VALUES.ToString(rarity)}\n" +
					$"Equip slot: {ARMOR_VALUES.ToString(equipSlot)}\n" +
					$"Protection Areas:\n{protectionAreas}" +
					$"Type: {ARMOR_VALUES.ToString(type)} armor";
			}
			else
			{
				foreach (var resistance in this.resistances)
				{
					resistances += $"{resistance.Value:p}:";
				}
				foreach (var protectionArea in this.protectionAreas)
				{
					protectionAreas += $"{ARMOR_VALUES.ToString(protectionArea.Value):p}, ";
				}
				return $"{name}:{assemblyProtection:f2}:{physicalProtection:f2}:{magicalProtection:f2}:{resistances}{currentDurability:f2}:{durability:f2}:{COMMON_VALUES.ToString(rarity)}:{ARMOR_VALUES.ToString(equipSlot)}:{protectionAreas}:{ARMOR_VALUES.ToString(type)}";
			}
		}

		public COMMON_VALUES.ITEM_TYPE ItemType => COMMON_VALUES.ITEM_TYPE.ARMOR;
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
		//Creates a randomly generated armor piece
		public Armor()
		{
			assemblyProtection = RAND.getRandDouble(300, 3001);
			resistances = new Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double>();
			type = (ARMOR_VALUES.TYPE)RAND.getRandInt(0, 3);
			durability = RAND.getRandDouble(100,1000);
			currentDurability = durability;
			rarity = (COMMON_VALUES.RARITY)RAND.getRandInt(0, 7);
			equipSlot = (ARMOR_VALUES.EQUIP_SLOT)RAND.getRandInt(0, 8);
			Dictionary<int, ARMOR_VALUES.PROTECTING_AREA> protectionAreas = new Dictionary<int, ARMOR_VALUES.PROTECTING_AREA>(); 
			SetRarityModifiers();
			SetTypeModifiers();
			SetRelativeArmorPieceProtectionModifiers();
			SetProtectionAreas();
			DecideResistances();
			setPhysicalAndMagicalProtection();
			SetName();
		}
		//Parametarised Armor Constructor.
		public Armor(
			ARMOR_VALUES.EQUIP_SLOT equipSlot = (ARMOR_VALUES.EQUIP_SLOT)8,
			double assemblyProtection = -1,
			ARMOR_VALUES.TYPE type = (ARMOR_VALUES.TYPE)3,
			double durability = -1,
			COMMON_VALUES.RARITY rarity = (COMMON_VALUES.RARITY)7)
		{

			Dictionary<int, ARMOR_VALUES.PROTECTING_AREA> protectionAreas = new Dictionary<int, ARMOR_VALUES.PROTECTING_AREA>();
			if (assemblyProtection == -1)
				this.assemblyProtection = RAND.getRandDouble(300, 3001);
			else
				this.assemblyProtection = assemblyProtection;
			this.resistances = new Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double>();
			if ((int)type == 3)
				this.type = (ARMOR_VALUES.TYPE)RAND.getRandInt(0, 3);
			else
				this.type = type;
			if (durability == -1)
				this.durability = RAND.getRandDouble(100, 1000);
			else
				this.durability = durability;
			this.currentDurability = this.durability;
			if ((int)rarity == 7)
				this.rarity = (COMMON_VALUES.RARITY)RAND.getRandInt(0, 7);
			else
				this.rarity = rarity;
			if ((int)equipSlot == 8)
				equipSlot = (ARMOR_VALUES.EQUIP_SLOT)RAND.getRandInt(0, 8);
			else
				this.equipSlot = equipSlot;
			SetRarityModifiers();
			SetTypeModifiers();
			SetRelativeArmorPieceProtectionModifiers();
			SetProtectionAreas();
			DecideResistances();
			setPhysicalAndMagicalProtection();
			SetName();
		}
		void setPhysicalAndMagicalProtection()
		{
			switch (type)
			{
				case ARMOR_VALUES.TYPE.HEAVY:
					physicalProtection = assemblyProtection * 0.8;
					magicalProtection = assemblyProtection * 0.3;
					break;
				case ARMOR_VALUES.TYPE.MEDIUM:
					physicalProtection = assemblyProtection * 0.6;
					magicalProtection = assemblyProtection * 0.65;
					break;
				case ARMOR_VALUES.TYPE.LIGHT:
					physicalProtection = assemblyProtection * 0.3;
					magicalProtection = assemblyProtection * 0.8;
					break;
				default:
					break;
			}
		}
		void SetRarityModifiers()
		{
			switch (rarity)
			{
				case COMMON_VALUES.RARITY.COMMON:
					assemblyProtection *= 0.8;
					break;
				case COMMON_VALUES.RARITY.UNCOMMON:
					assemblyProtection += 100;
					assemblyProtection *= 0.9;
					break;
				case COMMON_VALUES.RARITY.RARE:
					assemblyProtection += 300;
					assemblyProtection *= 1;
					break;
				case COMMON_VALUES.RARITY.EPIC:
					assemblyProtection += 500;
					assemblyProtection *= 1.2;
					break;
				case COMMON_VALUES.RARITY.LEGENDARY:
					assemblyProtection += 700;
					assemblyProtection *= 1.4;
					break;
				case COMMON_VALUES.RARITY.MYTHIC:
					assemblyProtection += 900;
					assemblyProtection *= 1.6;
					break;
				case COMMON_VALUES.RARITY.SPECIAL:
					assemblyProtection += 1100;
					assemblyProtection *= 1.7;
					break;
				default:
					break;
			}
		}
		void SetTypeModifiers()
		{
			switch (type)
			{
				case ARMOR_VALUES.TYPE.HEAVY:
					assemblyProtection += 200;
					assemblyProtection *= 1.3;
					break;
				case ARMOR_VALUES.TYPE.LIGHT:
					assemblyProtection -= 100;
					assemblyProtection *= 0.9;
					break;
				default:
					break;
			}
		}
		void SetRelativeArmorPieceProtectionModifiers()
		{
			switch (equipSlot)
			{
				case ARMOR_VALUES.EQUIP_SLOT.HELMET:
					assemblyProtection *= 0.3;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOULDERPLATES:
					assemblyProtection *= 0.5;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SLEEVES:
					assemblyProtection *= 0.4;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.GLOVES:
					assemblyProtection *= 0.1;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.BELT:
					assemblyProtection *= 0.2;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.LEGGINGS:
					assemblyProtection *= 0.8;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOES:
					assemblyProtection *= 0.2;
					break;
				default:
					break;
			}
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
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, RAND.getRandDouble(0.15, 0.41));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, RAND.getRandDouble(-0.20, 0.1));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, RAND.getRandDouble(-0.20, 0.16));
					}
					else
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, 0);
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, 0);
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, 0);
					}

					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE    , RAND.getRandDouble(0, 0.11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER   , RAND.getRandDouble(0, 0.11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH   , RAND.getRandDouble(0, 0.11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR     , RAND.getRandDouble(0, 0.11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX     , RAND.getRandDouble(0, 0.11));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID    , RAND.getRandDouble(0, 0.11));
					break;
				case ARMOR_VALUES.TYPE.MEDIUM:
					if ((int)rarity >= 3)
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, RAND.getRandDouble(0, 0.16));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, RAND.getRandDouble(-0.10, 0.11));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, RAND.getRandDouble(0, 0.21));
					}
					else
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, 0);
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, 0);
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, 0);
					}

					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE    , RAND.getRandDouble(0, 0.21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER   , RAND.getRandDouble(0, 0.21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH   , RAND.getRandDouble(0, 0.21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR     , RAND.getRandDouble(0, 0.21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX     , RAND.getRandDouble(0, 0.21));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID    , RAND.getRandDouble(0, 0.21));
					break;
				case ARMOR_VALUES.TYPE.LIGHT:
					if ((int)rarity >= 3)
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, RAND.getRandDouble(-0.15, 0.1));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, RAND.getRandDouble(0, 0.11));
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, RAND.getRandDouble(0.10, 0.31));
					}
					else
					{
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, 0);
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, 0);
						resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, 0);
					}

					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE    , RAND.getRandDouble(0.10, 0.51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER   , RAND.getRandDouble(0.10, 0.51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH   , RAND.getRandDouble(0.10, 0.51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR     , RAND.getRandDouble(0.10, 0.51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX     , RAND.getRandDouble(0.10, 0.51));
					resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID    , RAND.getRandDouble(0.10, 0.51));
					break;
				default:
					break;
			}
		}
		void SetName()
		{
			name = $"{COMMON_VALUES.ToString(rarity)} {ARMOR_VALUES.ToString(type)} {ARMOR_VALUES.ToString(equipSlot)}";
		}


		public void ReceiveDamageFrom(IWeapon weapon)
		{
			if (weapon == null)
				return;
			else
			{
				switch (weapon.PhysicalDamageType)
				{
					case WEAPON_VALUES.DAMAGE_TYPE.SLASHING:
						physicalProtection -= weapon.PhysicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.SLASHING]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.PIERCING:
						physicalProtection -= weapon.PhysicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.PIERCING]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.BLUNT:
						physicalProtection -= weapon.PhysicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.BLUNT]);
						break;
					default:
						break;
				}
				switch (weapon.MagicalDamageType)
				{
					case WEAPON_VALUES.DAMAGE_TYPE.FIRE:
						magicalProtection -= weapon.MagicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.FIRE]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.WATER:
						magicalProtection -= weapon.MagicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.WATER]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.EARTH:
						magicalProtection -= weapon.MagicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.EARTH]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.AIR:
						magicalProtection -= weapon.MagicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.AIR]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.VOID:
						magicalProtection -= weapon.MagicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.VOID]);
						break;
					case WEAPON_VALUES.DAMAGE_TYPE.LUX:
						magicalProtection -= weapon.MagicalDamage * (1 - resistances[WEAPON_VALUES.DAMAGE_TYPE.LUX]);
						break;
					default:
						break;
				}
				if (physicalProtection < 0)
				{
					physicalProtection = 0;
				}
				if (magicalProtection < 0)
				{
					magicalProtection = 0;
				}
			}
		}
		public override string ToString()
		{
			return name;
		}
	}
}
