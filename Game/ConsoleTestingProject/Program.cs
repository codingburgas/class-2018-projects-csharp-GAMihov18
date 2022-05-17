using System;
using GeneratorLib.Generator;
using GeneratorLib.Types;
using GeneratorLib.Values;
using BussinessLogicLayer;
namespace ConsoleTestingProject
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine(UserHandler.Login("admin", "admi").Name);
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
				
			}
			
			
		}
	}
}