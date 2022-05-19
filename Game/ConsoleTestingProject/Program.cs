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
			/*
			UserHandler.Register(new DataAccessLayer.Models.User()
			{
				Name = "admin",
				Email = "gamih@coddkka",
				Password = "admin",
				Age	= 15
			});
			*/
			UserHandler.Login("admin","admn");
		}
	}
}