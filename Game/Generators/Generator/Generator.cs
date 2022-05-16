using RFMiscLib.RandomNumber;
using GeneratorLib.Types;
using System.Collections.Generic;
namespace GeneratorLib.Generator
{
	public class Generator
	{
		Queue<Weapon> weaponQueue;
		Queue<Armor> armorQueue;
		//Add queues for Player when added

		//Unimplemented point system the generator will use
		int pointsAllowed = 0;
		public Generator()
		{
			weaponQueue = new Queue<Weapon>();
			armorQueue = new Queue<Armor>();
			pointsAllowed = 100;
		}
		public Generator(int pointsAllowed)
		{
			weaponQueue = new Queue<Weapon>();
			armorQueue = new Queue<Armor>();
			this.pointsAllowed = pointsAllowed;
		}
		public bool GenerateWeapons(int numberOfWeapons)
		{

			weaponQueue = new Queue<Weapon>();
			for (int i = 0; i < numberOfWeapons; i++)
				weaponQueue.Enqueue(new Weapon());
			return true;
		}

		public bool GenerateArmors(int numberOfArmors)
		{

			armorQueue = new Queue<Armor>();
			for (int i = 0; i < numberOfArmors; i++)
				armorQueue.Enqueue(new Armor());
			return true;
		}
		public Weapon NextWeapon()
		{
			return weaponQueue.Count == 0 ? null : weaponQueue.Dequeue();
		}
		public Armor NextArmor()
		{

			return armorQueue.Count == 0 ? null : armorQueue.Dequeue();
		}
		public void ClearMemory()
		{
			weaponQueue.Clear();
			armorQueue.Clear();
		}
		public void DumpDebug()
		{
			StreamWriter generatedWeaponsWriter = new StreamWriter("generatedWeaponsDump.txt",false);
			StreamWriter generatedArmorsWriter = new StreamWriter("generatedArmorsDump.txt", false);


			generatedWeaponsWriter.WriteLine("Name:Assembly Damage:Physical Damage:Magical Damage:Crit Multiplier:Crit Rate:Rarity:Weapon Type:Main Damage Type:Physical Damage Type:Magical Damage Type");


			generatedArmorsWriter.WriteLine("Name:Assembly Protection:Physical Protection:Magical Protection:Slashing Resistance:Piercing Resistance:Blunt Resistance:Fire Resistance:Water Resistance:Earth Resistance:Air Resistance:Lux Resistance:Void Resistance:Current Durability:Max Durability:Rarity:Equip Slot:Protection Areas:Type");

			if (weaponQueue.Count != 0)
			{
				foreach (var weapon in weaponQueue)
				{
					generatedWeaponsWriter.WriteLine(weapon.GetData(false));
				}
				generatedWeaponsWriter.Close();
			}

			if (armorQueue.Count != 0)
			{
				foreach (var armor in armorQueue)
				{
					generatedArmorsWriter.WriteLine(armor.GetData(false));
				}
				generatedArmorsWriter.Close();
			}
			//Add writer for players when players are implemented
		}
	}
}