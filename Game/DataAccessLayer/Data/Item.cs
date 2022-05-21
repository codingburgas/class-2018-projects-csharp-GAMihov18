using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ItemType { get; set; }
		public enum Type
		{ 
			Armor, Weapon, Item
		}

	}
}