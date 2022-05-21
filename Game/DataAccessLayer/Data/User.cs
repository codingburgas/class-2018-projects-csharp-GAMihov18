

using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{

	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[MaxLength(24)]
		public string Name { get; set; }

		[Required]
		[MaxLength(256)]

		public string Password { get; set; }
		[Required]
		[MaxLength(4)]
		public string Salt { get; set; }

		[Required]
		[MaxLength(128)]
		public string Email { get; set; }

		public int Age { get; set; }
	}
}