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
			//User user = new User();
			//user.Name = "zarako";
			//user.Email = "Gkasd@gger";
			//user.Password = "123123";
			//user.Age = 18;
			//UserHandler.Register(user);

			UserHandler.Login("Zarako", "123123");
			UserHandler.GetCharacterById(5);
			//UserHandler.CreateCharacter(new Character());



		}
	}
}