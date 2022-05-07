using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib.Values
{
	public struct ARMOR_VALUES
	{
		public enum TYPE
		{ 
			HEAVY, MEDIUM, LIGHT
		}
		public enum PROTECTING_AREA
		{
			HEAD, SHOULDERS, ARMS, HANDS, WAIST, CHEST, LEGS, FEET
		}
		public enum EQUIP_SLOT
		{
			HELMET, SHOULDERPLATES, CHESTPLATE, SLEEVES, GLOVES, BELT, LEGGINGS, SHOES
		}
	}
}
