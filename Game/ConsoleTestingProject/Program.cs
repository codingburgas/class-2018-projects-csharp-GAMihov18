using System;
using GeneratorLib.Generator;
using GeneratorLib.Types;
using GeneratorLib.Values;
using DataAccessLayer.Models;
using BussinessLogicLayer;
namespace ConsoleTestingProject
{
	class Program
	{
		static void Main(string[] args)
		{
			UserHandler.UploadArmor(new Armor());
		}
	}
}