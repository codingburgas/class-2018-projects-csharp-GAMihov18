using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
	
namespace DataAccessLayer.Models
{
	public class ArmorData
	{
		[Key]
		public int Id { get; set; }
		public int ArmorCommonDataId { get; set; }
		public Item ArmorCommonData { get; set; }
		public double AssemblyArmor { get; set; }
		[Range(0,6)]
		public int ArmorRarity { get; set; }
		[Range(0,2)]
		public int ArmorType { get; set; }
		[Range(0,7)]
		public int ArmorEquipSlot { get; set; }

		public int FirstProtectionArea { get; set; }
		public int SecondProtectionArea { get; set; }
		public int ThirdProtectionArea { get; set; }


		public double SlashingResistance { get; set; }
		public double PiercingResistance { get; set; }
		public double BluntResistance { get; set; }
		public double FireResistance { get; set; }
		public double WaterResistance { get; set; }
		public double EarthResistance { get; set; }
		public double AirResistance { get; set; }
		public double LuxResistance { get; set; }
		public double VoidResistance { get; set; }
	}
}
