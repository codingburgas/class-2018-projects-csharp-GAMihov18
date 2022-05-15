using System;
using GeneratorLib.Generator;
using GeneratorLib.Types;
namespace ConsoleTestingProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Generator generator = new Generator();
			generator.GenerateWeapons(1);
			Weapon weapon = generator.NextWeapon();
			generator.GenerateArmors(1);
			IArmor equipable = generator.NextArmor();
			IArmor armor1 = equipable;
			IArmor armor2 = equipable;
			Console.WriteLine(weapon.GetWeaponData(false));
			Console.WriteLine();
			Console.WriteLine(equipable.GetArmorData(false));
			Console.WriteLine();
			Console.WriteLine(armor1.GetArmorData(false));
			Console.WriteLine();
			Console.WriteLine(armor2.GetArmorData(false));
			armor1.ReceiveDamageFrom(weapon);
			Console.WriteLine(equipable.GetArmorData(false));
			Console.WriteLine();
			Console.WriteLine(armor1.GetArmorData(false));
			Console.WriteLine();
			Console.WriteLine(armor2.GetArmorData(false));
			Console.WriteLine();
			armor1.ReceiveDamageFrom(weapon);
			Console.WriteLine(equipable.GetArmorData(false));
			Console.WriteLine();
			Console.WriteLine(armor1.GetArmorData(false));
			Console.WriteLine();
			Console.WriteLine(armor2.GetArmorData(false));
		}
	}
}