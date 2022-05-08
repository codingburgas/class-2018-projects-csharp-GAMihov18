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
		public static string ToString(TYPE type)
		{
			switch (type)
			{
				case TYPE.HEAVY:
					return "Heavy";
					break;
				case TYPE.MEDIUM:
					return "Medium";
					break;
				case TYPE.LIGHT:
					return "Light";
					break;
				default:
					return "";
					break;
			}
		}
		public static string ToString(EQUIP_SLOT qs)
		{
			switch (qs)
			{
				case EQUIP_SLOT.HELMET:
					return "Helmet";
					break;
				case EQUIP_SLOT.SHOULDERPLATES:
					return "Shoulderplates";
					break;
				case EQUIP_SLOT.CHESTPLATE:
					return "Chestplate";
					break;
				case EQUIP_SLOT.SLEEVES:
					return "Sleeves";
					break;
				case EQUIP_SLOT.GLOVES:
					return "Gloves";
					break;
				case EQUIP_SLOT.BELT:
					return "Belt";
					break;
				case EQUIP_SLOT.LEGGINGS:
					return "Leggings";
					break;
				case EQUIP_SLOT.SHOES:
					return "Shoes";
					break;
				default:
					return "";
					break;
			}
		}
	}
}
