using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class WeaponData
	{
		[Key]
		public int Id { get; set; }
		public int WeaponCommonDataId { get; set; }
		public Item WeaponCommonData { get; set; }
		public double AssemblyDamage { get; set; }
		public double CritRate { get; set; }
		public double CritMult { get; set; }
		public int WeaponType { get; set; }
		public int WeaponRarity { get; set; }
		public int PhysicalDamageType { get; set; }
		public int MagicalDamageType { get; set; }
		public int MainDamageType { get; set; }
	}
}
