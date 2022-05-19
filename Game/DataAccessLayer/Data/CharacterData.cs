using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	class CharacterData
	{
		[Key]
		public int Id { get; set; }
		public Item? MainHand { get; }
		public Item? OffHand { get; }
		public Item? Head { get; }
		public Item? Shoulders { get; }
		public Item? Arms { get; }
		public Item? Hands { get; }
		public Item? Waist { get; }
		public Item? Chest { get; }
		public Item? Legs { get; }
		public Item? Feet { get; }

		public double Health { get; }
		public double Stamina { get; }
		public double StaminaRegenerationRate { get; }
		public double Mana { get; }
		public double ManaRegenerationRate { get; }
	}
}
