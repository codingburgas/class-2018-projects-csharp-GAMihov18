using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorLib.Values;
namespace DataAccessLayer.Models
{
	public class Item
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public COMMON_VALUES.ITEM_TYPE ItemType { get; set; }

	}
}