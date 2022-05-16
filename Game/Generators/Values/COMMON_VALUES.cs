using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib.Types
{
	public struct COMMON_VALUES
	{
		public enum ITEM_TYPE
		{
			WEAPON, ARMOR
		}
		public enum RARITY
		{
			COMMON, UNCOMMON, RARE, EPIC, LEGENDARY, MYTHIC, SPECIAL
		}
		public static string ToString(RARITY rarity)
		{
			switch (rarity)
			{
				case RARITY.COMMON:
					return "Common";
				case RARITY.UNCOMMON:
					return "Uncommon";
				case RARITY.RARE:
					return "Rare";
				case RARITY.EPIC:
					return "Ultra Rare";
				case RARITY.LEGENDARY:
					return "Legendary";
				case RARITY.MYTHIC:
					return "Mythic";
				case RARITY.SPECIAL:
					return "Special";
				default:
					return "Error";
			}
		}
	}
}
