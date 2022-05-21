using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorLib.Values;
using GeneratorLib.Types;
using RFMiscLib.RandomNumber;
namespace GeneratorLib.Types
{
	public class Character : ICharacter
	{
		string name;
		IWeapon? mainHand;
		IEquipable? offHand;

		IArmor? head;
		IArmor? shoulders;
		IArmor? arms;
		IArmor? hands;
		IArmor? waist;
		IArmor? chest;
		IArmor? legs;
		IArmor? feet;

		double health;
		double stamina;
		double staminaRegenerationRate;
		double mana;
		double manaRegenerationRate;
		List<IItem> inventory = new List<IItem>();

		public string Name => name;
		public IWeapon? MainHand => mainHand;
		public IEquipable? OffHand => offHand;
		public IArmor? Head => head;
		public IArmor? Shoulders => shoulders;
		public IArmor? Arms => arms;
		public IArmor? Hands => hands;
		public IArmor? Waist => waist;
		public IArmor? Chest => chest;
		public IArmor? Legs => legs;
		public IArmor? Feet => feet;

		public double Health => health;
		public double Stamina => stamina;
		public double StaminaRegenerationRate => staminaRegenerationRate;
		public double Mana => mana;
		public double ManaRegenerationRate => manaRegenerationRate;
		public List<IItem> Inventory => inventory;

		public Character(bool isGeared = true)
		{

			if (isGeared)
			{
				mainHand = new Weapon();
				head = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.HELMET);
				shoulders = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.SHOULDERPLATES);
				arms = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.SLEEVES);
				hands = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.GLOVES);
				waist = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.BELT);
				chest = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.CHESTPLATE);
				legs = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.LEGGINGS);
				feet = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.SHOES);
			}
			else
			{
				mainHand = null;
				head = null;
				shoulders = null;
				arms = null;
				hands = null;
				waist = null;
				chest = null;
				legs = null;
				feet = null;
			}
		}
		public bool Equip(IEquipable equipable)
		{
			if (equipable.ItemType == COMMON_VALUES.ITEM_TYPE.ARMOR)
			{
				EquipArmor(equipable as IArmor);
			}
			return true;
		}
		public bool Unequip(IEquipable equipable)
		{
			if (equipable.ItemType == COMMON_VALUES.ITEM_TYPE.ARMOR)
			{
				UnequipArmor(equipable as IArmor);
			}
			return true;
		}
		private bool UnequipArmor(IArmor armor)
		{
			
			switch (armor.EquipSlot)
			{
				case ARMOR_VALUES.EQUIP_SLOT.HELMET:
					inventory.Add(head);
					if (head.ProtectionAreas.Count == 2)
					{
						head = null;
						shoulders = null;
					}
					else if (head.ProtectionAreas.Count == 3)
					{
						head = null;
						shoulders = null;
						chest = null;
					}
					else
						head = null;
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOULDERPLATES:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.CHESTPLATE:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SLEEVES:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.GLOVES:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.BELT:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.LEGGINGS:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOES:
					break;
				default:
					break;
			}


			return true;
		}
		private bool EquipArmor(IArmor armor)
		{
			switch (armor.EquipSlot)
			{
				case ARMOR_VALUES.EQUIP_SLOT.HELMET:
					if (head != null)
					{
						UnequipArmor(head);
						EquipArmor(armor);
					}
					else
					{
						if (armor.ProtectionAreas.Count == 2)
						{
							head = armor;
							shoulders = armor;
						}
						else if (armor.ProtectionAreas.Count == 3)
						{
							head = armor;
							shoulders = armor;
							chest = armor;
						}
						else
							head = armor;
					}
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOULDERPLATES:

					break;
				case ARMOR_VALUES.EQUIP_SLOT.CHESTPLATE:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SLEEVES:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.GLOVES:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.BELT:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.LEGGINGS:
					break;
				case ARMOR_VALUES.EQUIP_SLOT.SHOES:
					break;
				default:
					break;
			}
			return true;

		}
		public bool ReceiveDamage(ICharacter player,ARMOR_VALUES.PROTECTING_AREA targetArea)
		{
			IWeapon enemyWeapon = player.MainHand;
			switch (targetArea)
			{
				case ARMOR_VALUES.PROTECTING_AREA.HEAD:
					if (RAND.getRandDouble(0,1)>0.7)
					{
						head.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					/*
					else if(RAND.getRandDouble(0, 1) > 0.4)
					{
						shoulders.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					*/
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.SHOULDERS:
					if (RAND.getRandDouble(0, 1) > 0.6)
					{
						shoulders.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					/*
					else if (RAND.getRandDouble(0, 1) > 0.7)
					{
						head.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else if (RAND.getRandDouble(0, 1) > 0.5)
					{
						arms.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else if (RAND.getRandDouble(0, 1) > 0.3)
					{
						chest.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					*/
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.ARMS:
					if (RAND.getRandDouble(0, 1) > 0.5)
					{
						arms.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.HANDS:
					if (RAND.getRandDouble(0, 1) > 0.8)
					{
						hands.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.WAIST:
					if (RAND.getRandDouble(0, 1) > 0.5)
					{
						waist.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.CHEST:
					if (RAND.getRandDouble(0, 1) > 0.3)
					{
						chest.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.LEGS:
					if (RAND.getRandDouble(0, 1) > 0.3)
					{
						legs.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					else
						return false;
				case ARMOR_VALUES.PROTECTING_AREA.FEET:
					if (RAND.getRandDouble(0, 1) > 0.8)
					{
						feet.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					/*
					else if (RAND.getRandDouble(0,1) > 0.5)
					{
						legs.ReceiveDamageFrom(enemyWeapon);
						return true;
					}
					*/
					else
						return false;
				default:
					return false;
			}
			
		}
	}
}
