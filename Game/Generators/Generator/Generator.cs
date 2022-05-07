using RFMiscLib.RandomNumber;
using GeneratorLib.Types;
using System.Collections.Generic;
namespace GeneratorLib.Generator
{
	public class Generator
	{
		Queue<Weapon> weaponQueue;
		//Add queues for Armor and Player when added

		//Unimplemented point system the generator will use
		int pointsAllowed = 0;
		public Generator(int pointsAllowed)
		{
			weaponQueue = new Queue<Weapon>();
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
		public Weapon NextWeapon()
		{
			if (weaponQueue.Count == 0)
			{
				GenerateWeapons(1);
			}
			return weaponQueue.Dequeue();
		}
	}
}