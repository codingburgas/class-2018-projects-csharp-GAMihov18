using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
	class UserCharacter
	{
		public Character Character { get; set; }
		public User User { get; set; }
		public int CharacterId { get; set; }
		public int UserId { get; set; }
	}
}
