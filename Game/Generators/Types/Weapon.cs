using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RFMiscLib.RandomNumber;
using GeneratorLib.Values;
namespace GeneratorLib.Types
{
	public class Weapon : IWeapon
	{
		private string name;
		private double assemblyDamage;
		private double physicalDamage;
		private double magicalDamage;
		private double critRate;
		private double critMult;
		private WEAPON_VALUES.TYPE weaponType;
		private COMMON_VALUES.RARITY rarity;
		private WEAPON_VALUES.DAMAGE_TYPE physicalDamageType;
		private WEAPON_VALUES.DAMAGE_TYPE magicalDamageType;
		private WEAPON_VALUES.DAMAGE_TYPE mainDamageType;
		public string Name
		{
			get { return name; }
			private set { name = value; }
		}
		public double AssemblyDamage
		{
			get { return assemblyDamage; }
			private set { assemblyDamage = value; }
		}
		public double PhysicalDamage
		{
			get { return physicalDamage; }
			private set { physicalDamage = value; }
		}
		public double MagicalDamage
		{
			get { return MagicalDamage; }
			private set { MagicalDamage = value; }
		}
		public double CritRate
		{
			get { return critRate; }
			private set { critRate = value; }
		}
		public double CritMult
		{
			get { return critMult; }
			private set { critMult = value; }
		}
		public WEAPON_VALUES.TYPE WeaponType
		{
			get { return weaponType; }
			private set { weaponType = value; }
		}
		public COMMON_VALUES.RARITY Rarity
		{
			get { return rarity; }
			private set { rarity = value; }
		}
		public WEAPON_VALUES.DAMAGE_TYPE PhysicalDamageType
		{
			get { return physicalDamageType; }
			private set { physicalDamageType = value; }
		}
		public WEAPON_VALUES.DAMAGE_TYPE MagicalDamageType
		{
			get { return magicalDamageType; }
			private set { magicalDamageType = value; }
		}
		public Weapon()
		{
			name = "";
			assemblyDamage = RAND.getRandDouble(1, 1001);
			critMult = RAND.getRandDouble(1.05, 2.51);
			critRate = RAND.getRandDouble(0.01, 0.21);
			weaponType = (WEAPON_VALUES.TYPE)RAND.getRandInt(0, 14);
			rarity = (COMMON_VALUES.RARITY)RAND.getRandInt(0, 7);
			SetPhysDamage();
			magicalDamageType = (WEAPON_VALUES.DAMAGE_TYPE)RAND.getRandInt(3, 9);
			SetMainDamageType();
			applyRarityMod();
			applyMainDamageMod();
			SetName();
		}
		public Weapon(COMMON_VALUES.RARITY rarity)
		{
			name = "";
			assemblyDamage = RAND.getRandDouble(1, 1001);
			critMult = RAND.getRandDouble(1.05, 2.51);
			critRate = RAND.getRandDouble(0.01, 0.21);
			weaponType = (WEAPON_VALUES.TYPE)RAND.getRandInt(0, 14);
			this.rarity = rarity;
			SetPhysDamage();
			magicalDamageType = (WEAPON_VALUES.DAMAGE_TYPE)RAND.getRandInt(3, 9);
			SetMainDamageType();
			applyRarityMod();
			applyMainDamageMod();
			SetName();
		}

		public Weapon(string name = "", double assemblyDamage = 0, double critMult = 0, double critRate = 0, WEAPON_VALUES.TYPE weaponType = default, COMMON_VALUES.RARITY rarity = default, WEAPON_VALUES.DAMAGE_TYPE magicalDamageType = default, WEAPON_VALUES.DAMAGE_TYPE physicalDamageType = default)
		{
			this.assemblyDamage = assemblyDamage;
			this.critMult = critMult;
			this.critRate = critRate;
			this.weaponType = weaponType;
			this.rarity= rarity;
			this.magicalDamageType = magicalDamageType;
			this.physicalDamageType = physicalDamageType;
			if (name == "")
			{
				SetName();
			}
			else
			{
				this.name = name;
			}
		}

			private void SetPhysDamage()
		{
			switch (weaponType)
			{
				case WEAPON_VALUES.TYPE.KNIFE:
				case WEAPON_VALUES.TYPE.SHORTSWORD:
				case WEAPON_VALUES.TYPE.LONGSWORD:
				case WEAPON_VALUES.TYPE.BASTARD_SWORD:
				case WEAPON_VALUES.TYPE.POLEARM:
				case WEAPON_VALUES.TYPE.TWO_HANDED_SWORD:
				case WEAPON_VALUES.TYPE.BATTLE_AXE:
				case WEAPON_VALUES.TYPE.WAR_AXE:
					physicalDamageType = WEAPON_VALUES.DAMAGE_TYPE.SLASHING;
					break;
				case WEAPON_VALUES.TYPE.DAGGER:
				case WEAPON_VALUES.TYPE.BOW:
				case WEAPON_VALUES.TYPE.SPEAR:
				case WEAPON_VALUES.TYPE.RAPIER:
					physicalDamageType = WEAPON_VALUES.DAMAGE_TYPE.PIERCING;
					break;
				case WEAPON_VALUES.TYPE.MACE:
				case WEAPON_VALUES.TYPE.HAMMER:
					physicalDamageType = WEAPON_VALUES.DAMAGE_TYPE.BLUNT;
					break;
				default:
					Exception exc = new Exception("Invalid weapon type");
					throw exc;
			}
		}
		private void SetMainDamageType()
		{
			if (RAND.getRandInt(0, 101) < 50)
				mainDamageType = physicalDamageType;
			else
				mainDamageType = magicalDamageType;
		}
		private void SetName()
		{
			name = $"{COMMON_VALUES.ToString(rarity)} {WEAPON_VALUES.ToString(weaponType)} of {WEAPON_VALUES.ToString(mainDamageType)}";
		}
		public string GetWeaponData(bool isReadable)
		{
			if (isReadable)
			{
				return $"Name: {name}\nAssembly Damage: {assemblyDamage:f2}\nPhysical Damage: {physicalDamage:f2}\nMagical Damage: {magicalDamage:f2}\nCrit Mult: {critMult:p2}\nCrit Rate: {critRate:p2}\nRarity: {COMMON_VALUES.ToString(rarity)}\nWeapon Type: {WEAPON_VALUES.ToString(weaponType)}\nMain Damage Type: {WEAPON_VALUES.ToString(mainDamageType)}\nPhysical Damage: {WEAPON_VALUES.ToString(physicalDamageType)}\nMagical Damage: {WEAPON_VALUES.ToString(magicalDamageType)}";
			}
			else
			{
				return $"{name}:{assemblyDamage:f2}:{physicalDamage:f2}:{magicalDamage:f2}:{critMult:p}:{critRate:p}:{COMMON_VALUES.ToString(rarity)}:{WEAPON_VALUES.ToString(weaponType)}:{WEAPON_VALUES.ToString(mainDamageType)}:{WEAPON_VALUES.ToString(physicalDamageType)}:{WEAPON_VALUES.ToString(magicalDamageType)}";
			}
		}
		private void applyRarityMod()
		{
			switch (rarity)
			{
				case COMMON_VALUES.RARITY.COMMON:
					assemblyDamage *= 0.7;
					critRate *= 0.5;
					critMult *= 1;
					break;
				case COMMON_VALUES.RARITY.UNCOMMON:
					assemblyDamage += 100;
					assemblyDamage *= 0.9;
					critRate *= 0.6;
					critMult *= 1.08;
					break;
				case COMMON_VALUES.RARITY.RARE:
					assemblyDamage += 150;
					assemblyDamage *= 1;
					critRate *= 0.8;
					critMult *= 1.2;
					break;
				case COMMON_VALUES.RARITY.EPIC:
					assemblyDamage += 200;
					assemblyDamage *= 1.1;
					critRate *= 0.9;
					critMult *= 1.3;
					break;
				case COMMON_VALUES.RARITY.LEGENDARY:
					assemblyDamage += 250;
					assemblyDamage *= 1.175;
					critRate *= 1.05;
					critMult *= 1.5;
					break;
				case COMMON_VALUES.RARITY.MYTHIC:
					assemblyDamage += 300;
					assemblyDamage *= 1.2;
					critRate *= 1.1;
					critMult *= 1.6;
					break;
				case COMMON_VALUES.RARITY.SPECIAL:
					assemblyDamage += 400;
					assemblyDamage *= 1.3;
					critRate *= 1.2;
					critMult *= 1.7;
					break;
				default:
					break;
			}
		}

		private void magicalDamageSwitch()
		{
			switch (physicalDamageType)
			{
				case WEAPON_VALUES.DAMAGE_TYPE.SLASHING:
					physicalDamage = 0.5 * assemblyDamage;
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.PIERCING:
					physicalDamage = 0.1 * assemblyDamage;
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.BLUNT:
					physicalDamage = 0.4 * assemblyDamage;
					break;
				default:
					break;
			}
		}
		private void applyMainDamageMod()
		{
			switch (mainDamageType)
			{
				case WEAPON_VALUES.DAMAGE_TYPE.SLASHING:
					physicalDamage = 1 * assemblyDamage;
					magicalDamage = 0.01 * assemblyDamage;
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.PIERCING:
					physicalDamage = 0.5 * assemblyDamage;
					magicalDamage = 0.01 * assemblyDamage;
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.BLUNT:
					physicalDamage = 0.8 * assemblyDamage;
					magicalDamage = 0.01 * assemblyDamage;
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.FIRE:
					magicalDamage = 0.4 * assemblyDamage;
					magicalDamageSwitch();
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.WATER:
					magicalDamage = 0.4 * assemblyDamage;
					magicalDamageSwitch();
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.EARTH:
					magicalDamage = 0.4 * assemblyDamage;
					magicalDamageSwitch();
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.AIR:
					magicalDamage = 0.4 * assemblyDamage;
					magicalDamageSwitch();
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.VOID:
					magicalDamage = 0.4 * assemblyDamage;
					magicalDamageSwitch();
					break;
				case WEAPON_VALUES.DAMAGE_TYPE.LUX:
					magicalDamage = 0.4 * assemblyDamage;
					magicalDamageSwitch();
					break;
				default:
					break;
			}
		}

		public bool Equip()
		{
			throw new NotImplementedException();
		}
	}
}
