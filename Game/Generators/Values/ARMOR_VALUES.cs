using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib.Values
{
	public struct ARMOR_VALUES
	{
		public enum	TYPE
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

		public static string ToString(PROTECTING_AREA pa)
		{
			switch (pa)
			{
				case PROTECTING_AREA.HEAD:
					return "Head";
				case PROTECTING_AREA.SHOULDERS:
					return "Shoulders";
				case PROTECTING_AREA.ARMS:
					return "Arms";
				case PROTECTING_AREA.HANDS:
					return "Hands";
				case PROTECTING_AREA.WAIST:
					return "Waist";
				case PROTECTING_AREA.CHEST:
					return "Chest";
				case PROTECTING_AREA.LEGS:
					return "Legs";
				case PROTECTING_AREA.FEET:
					return "Feet";
				default:
					return "";
			}
		}


		public static string ToString(TYPE type)
		{
			switch (type)
			{
				case TYPE.HEAVY:
					return "Heavy";
				case TYPE.MEDIUM:
					return "Medium";
				case TYPE.LIGHT:
					return "Light";
				default:
					return "";
			}
		}
		public static string ToString(EQUIP_SLOT qs)
		{
			switch (qs)
			{
				case EQUIP_SLOT.HELMET:
					return "Helmet";
				case EQUIP_SLOT.SHOULDERPLATES:
					return "Shoulderplates";
				case EQUIP_SLOT.CHESTPLATE:
					return "Chestplate";
				case EQUIP_SLOT.SLEEVES:
					return "Sleeves";
				case EQUIP_SLOT.GLOVES:
					return "Gloves";
				case EQUIP_SLOT.BELT:
					return "Belt";
				case EQUIP_SLOT.LEGGINGS:
					return "Leggings";
				case EQUIP_SLOT.SHOES:
					return "Shoes";
				default:
					return "";
			}
		}
	}
}
