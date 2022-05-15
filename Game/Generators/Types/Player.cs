using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorLib.Values;
using RFMiscLib.RandomNumber;
namespace GeneratorLib.Types
{
	public class Player : IPlayer
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


		public bool ReceiveDamage(IPlayer player,ARMOR_VALUES.PROTECTING_AREA targetArea)
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
					break;
			}
			
		}
	}
}
