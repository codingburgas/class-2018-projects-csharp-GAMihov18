using DataAccessLayer.Models;
using System.Security.Cryptography;
using System.Text;
using RFMiscLib.RandomNumber;
namespace BussinessLogicLayer
{
	public class UserHandler
	{
		static GameDbContext ctx = new GameDbContext();
		public static User Login(string username, string password)
		{
			User? user = ctx.Users.Where(u => u.Name == username).FirstOrDefault();
			if (HashPassword(password, user.Salt) == user.Password && user != null)
			{
				return user;
			}
			else
			{
				throw new ArgumentException("Username or password was incorrect");
			}
			

		}

		public static User Register(User user)
		{

			string userpass = user.Password;
			user.Salt = $"{RAND.getRandInt(0, 9999):0000}";
			user.Password = HashPassword(userpass,user.Salt);
			try
			{
				ctx.Users.Add(user);
				ctx.SaveChanges();
				return user;
			}
			catch (Exception e)
			{

				throw e.InnerException;
			}
			
		}
		public static string HashPassword(string password, string salt)
		{
			SHA256 sha256 = SHA256.Create();
			byte[] encrypted = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));


			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < encrypted.Length; i++)
			{
				builder.Append(encrypted[i].ToString("x2"));
			}
			return builder.ToString();
		}
	}
}