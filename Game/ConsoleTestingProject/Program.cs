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
			Player player1= new Player();
			Player player2 = new Player();
			Console.WriteLine(player2.MainHand.GetWeaponData(true));
			Console.WriteLine();
			Console.WriteLine(player1.Head.GetArmorData(true));
			while (!player1.ReceiveDamage(player2, GeneratorLib.Values.ARMOR_VALUES.PROTECTING_AREA.HEAD));
			{
				Console.WriteLine("Player 2 missed :pensive:");
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine(player1.Head.GetArmorData(true));
		}
	}
}