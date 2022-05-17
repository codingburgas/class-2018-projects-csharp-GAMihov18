using DataAccessLayer.Models;
namespace BussinessLogicLayer
{
	public class UserHandler
	{
		static GameDbContext ctx = new GameDbContext();
		public static User Login(string username, string password)
		{
			
			User? user = ctx.Users.Where(u => u.Name == username && u.Password == password).FirstOrDefault();
			if (user == null)
			{
				throw new ArgumentException("Username or password was incorrect");
			}
			else
				return user;
		}
	}
}