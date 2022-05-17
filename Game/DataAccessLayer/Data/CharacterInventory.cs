using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	class CharacterInventory
	{
		public CharacterData CharacterData { get; set; }
		public Item Item { get; set; }
		public int CharacterDataId { get; set; }
		public int ItemId { get; set; }
	}
}
