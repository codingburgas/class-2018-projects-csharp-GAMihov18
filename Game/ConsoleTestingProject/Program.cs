using System;
using GeneratorLib.Generator;
namespace ConsoleTestingProject
{
	class Program
	{
		static void Main(string[] args)
		{
			Generator generator = new Generator();
			generator.GenerateWeapons(100);
			generator.GenerateArmors(100);
			generator.DumpDebug();

		}
	}
}