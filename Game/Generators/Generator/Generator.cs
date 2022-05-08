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
			{
				weaponQueue.Enqueue(new Weapon());
			}

			return true;
		}

		public bool GenerateArmors(int numberOfArmors)
		{

			armorQueue = new Queue<Armor>();
			for (int i = 0; i < numberOfArmors; i++)
			{
				armorQueue.Enqueue(new Armor());
			}
			return true;
		}
		public Weapon NextWeapon()
		{
			if (weaponQueue.Count == 0)
			{
				return null;
			}
			return weaponQueue.Dequeue();
		}
		public Armor NextArmor()
		{
			if (armorQueue.Count == 0)
			{
				return null;
			}
			return armorQueue.Dequeue();
		}
		public void ClearMemory()
		{
			weaponQueue.Clear();
			armorQueue.Clear();
		}
		public void DumpDebug()
		{

		}
	}
}