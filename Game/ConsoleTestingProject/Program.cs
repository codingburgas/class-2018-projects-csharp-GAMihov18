using System;
using GeneratorLib.Generator;
using GeneratorLib.Types;
using GeneratorLib.Values;
namespace ConsoleTestingProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Generator generator = new Generator();
			generator.GenerateWeapons(100);
			generator.GenerateArmors(100);
			Character player = new Character(isGeared: true);
			Armor armor = new Armor(equipSlot: ARMOR_VALUES.EQUIP_SLOT.HELMET);
			player.Equip(armor);
			player.Unequip(player.Head);
			foreach (var item in player.Inventory)
			{
				Console.WriteLine(item);
			}
			player.Equip(player.Inventory[1] as Armor);
			Console.WriteLine(player.Head);

		}
	}
}