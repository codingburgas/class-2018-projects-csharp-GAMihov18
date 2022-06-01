using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class CharacterData
	{
		[Key]
		public int Id { get; set; }
		public int? MainHandId { get; set; }
		public Item? MainHand { get; set; }
	    public int? OffHandId { get; set; }
		public Item? OffHand { get; set; }
		public int? HeadId { get; set; }
		public Item? Head { get; set; }
		public int? ShouldersId { get; set; }
		public Item? Shoulders { get; set; }
		public int? ArmsId { get; set; }
		public Item? Arms { get; set; }
		public int? HandsId { get; set; }
		public Item? Hands { get; set; }
		public int? WaistId { get; set; }
		public Item? Waist { get; set; }
		public int? ChestId { get; set; }
		public Item? Chest { get; set; }
		public int? LegsId { get; set; }
		public Item? Legs { get; set; }
		public int? FeetId { get; set; }
		public Item? Feet { get; set; }

		[Required]
		public double Health { get; set; }
		[Required]
		public double Stamina { get; set; }
		[Required]
		public double StaminaRegenerationRate { get; set; }
		[Required]
		public double Mana { get; set; }
		[Required]
		public double ManaRegenerationRate { get; set; }
	}
}
