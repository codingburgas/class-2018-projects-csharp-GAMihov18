

using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Data
{
	public class User
	{
		[Key]
		int Id { get; set; }

		[Required(ErrorMessage = "Name has no value, please fill it in")]
		[MaxLength(24)]
		string Name { get; set; }

		[Required (ErrorMessage = "Password has no value, please fill it in")]
		[MaxLength(256)]
		string Password { get; set; }

		[Required (ErrorMessage = "Email has no value, please fill it in")]
		string Email { get; set; }

		int Age { get; set; }


	}
}