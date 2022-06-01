using DataAccessLayer.Models;
using GeneratorLib.Types;
using GeneratorLib.Values;
using RFMiscLib.RandomNumber;
using System.Security.Cryptography;
using System.Text;
namespace BussinessLogicLayer
{
	public class UserHandler
	{
		static GameDbContext ctx = new GameDbContext();
		public static User currentlyLoggedInUser = null;
		public static User Login(string username, string password)
		{
			User? user = ctx.Users.Where(u => u.Name == username).FirstOrDefault();
			
			if (HashPassword(password, user.Salt) == user.Password && user != null)
			{
				currentlyLoggedInUser = user;
				return user;
			}
			else
			{
				throw new ArgumentException("Username or password was incorrect");
			}
		}
		public static bool Logout()
		{
			currentlyLoggedInUser = null;
			return true;
		}
		public static User Register(User user)
		{

			string userpass = user.Password;
			user.Salt = $"{RAND.getRandInt(0, 9999):0000}";
			user.Password = HashPassword(userpass,user.Salt);
			try
			{
				ctx.Users.Add(user);
				ctx.SaveChanges();
				return user;
			}
			catch (Exception e)
			{

				throw e.InnerException;
			}
			
		}
		public static string HashPassword(string password, string salt)
		{
			SHA256 sha256 = SHA256.Create();
			byte[] encrypted = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));


			StringBuilder builder = new StringBuilder();
			for (int i = 0; i < encrypted.Length; i++)
			{
				builder.Append(encrypted[i].ToString("x2"));
			}
			return builder.ToString();
		}

		public static bool ConvertWeapon(ref Weapon weapon, ref WeaponData weaponData)
		{
			if (weapon == null && weaponData != null)
			{
				weapon = new Weapon(
					assemblyDamage: weaponData.AssemblyDamage,
					critMult: weaponData.CritMult,
					critRate: weaponData.CritRate,
					weaponType: (WEAPON_VALUES.TYPE)weaponData.WeaponType,
					rarity: (COMMON_VALUES.RARITY)weaponData.WeaponRarity,
					magicalDamageType: (WEAPON_VALUES.DAMAGE_TYPE)weaponData.MagicalDamageType,
					physicalDamageType: (WEAPON_VALUES.DAMAGE_TYPE)weaponData.PhysicalDamageType,
					mainDamageType: (WEAPON_VALUES.DAMAGE_TYPE)weaponData.MainDamageType
					);
				return true;
			}
			else if (weapon != null && weaponData == null)
			{
				weaponData = new WeaponData()
				{
					AssemblyDamage = weapon.AssemblyDamage,
					CritMult = weapon.CritMult,
					CritRate = weapon.CritRate,
					WeaponType = (int)weapon.WeaponType,
					WeaponRarity = (int)weapon.Rarity,
					MainDamageType = (int)weapon.MainDamageType,
					PhysicalDamageType = (int)weapon.PhysicalDamageType,
					MagicalDamageType = (int)weapon.MagicalDamageType
				};
				
				return true;
			}
			else
			{
				return false;
			}
		}
		public static Weapon GetWeaponById(int id)
		{
			Weapon weapon = null;
			WeaponData data = null;
			try
			{
				data = ctx.WeaponDatas.Where(data => data.Id == id).First();
			}
			catch (Exception)
			{

			}

			ConvertWeapon(ref weapon, ref data);

			return weapon;
		}

		public static int UploadWeapon(Weapon weapon)
		{
			if (weapon == null)
				return -1;


			WeaponData data = null;
			if (ConvertWeapon(ref weapon,ref data))
			{
				Item weaponItem = new Item() { Name = weapon.Name, ItemType = COMMON_VALUES.ITEM_TYPE.WEAPON };
				ctx.Items.Add(weaponItem);
				var last = ctx.Items.OrderBy(i => i.Id).LastOrDefault();
				data.WeaponCommonData = weaponItem;
				if (last == null)
				{
					data.WeaponCommonDataId = 1;
				}
				else
					data.WeaponCommonDataId = last.Id + 1;
				ctx.WeaponDatas.Add(data);
				ctx.SaveChanges();
			}


			return data.Id;
		}

		//Summary:
		//	Converts from Armor to ArmorData class and vice versa.
		//	If armor parameter is null, it will convert from armorData to Armor.
		//	If armorData is null, it will convert from Armor to ArmorData class
		private static bool ConvertArmor(ref Armor armor, ref ArmorData armorData)
		{
			if (armor == null && armorData != null)
			{
				Dictionary<int, ARMOR_VALUES.PROTECTING_AREA> protectionAreas = new();
				Dictionary<WEAPON_VALUES.DAMAGE_TYPE, double> resistances = new();
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.BLUNT, armorData.BluntResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.PIERCING, armorData.PiercingResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.SLASHING, armorData.SlashingResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.FIRE, armorData.FireResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.WATER, armorData.WaterResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.AIR, armorData.AirResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.EARTH, armorData.EarthResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.LUX, armorData.LuxResistance);
				resistances.Add(WEAPON_VALUES.DAMAGE_TYPE.VOID, armorData.VoidResistance);
				protectionAreas.Add(0, (ARMOR_VALUES.PROTECTING_AREA)armorData.FirstProtectionArea);
				protectionAreas.Add(1, (ARMOR_VALUES.PROTECTING_AREA)armorData.SecondProtectionArea);
				protectionAreas.Add(2, (ARMOR_VALUES.PROTECTING_AREA)armorData.ThirdProtectionArea);
				armor = new Armor(
					assemblyProtection: armorData.AssemblyArmor,
					equipSlot: (ARMOR_VALUES.EQUIP_SLOT)armorData.ArmorEquipSlot,
					type: (ARMOR_VALUES.TYPE)armorData.ArmorType,
					rarity: (COMMON_VALUES.RARITY)armorData.ArmorRarity,
					resistances: resistances);
				return true;
			}
			else if(armor != null && armorData == null)
			{

				armorData = new ArmorData()
				{
					AssemblyArmor = armor.AssemblyProtection,
					ArmorRarity = (int)armor.Rarity,
					ArmorType = (int)armor.Type,
					ArmorEquipSlot = (int)armor.EquipSlot,
					FirstProtectionArea = (int)armor.ProtectionAreas[0],
					SecondProtectionArea = (int)armor.ProtectionAreas[1],
					ThirdProtectionArea = (int)armor.ProtectionAreas[2],
					SlashingResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.SLASHING],
					BluntResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.BLUNT],
					PiercingResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.PIERCING],
					FireResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.FIRE],
					WaterResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.WATER],
					EarthResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.EARTH],
					AirResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.AIR],
					LuxResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.LUX],
					VoidResistance = armor.Resistances[WEAPON_VALUES.DAMAGE_TYPE.VOID],
				};

				return true;
			}
			else
			{
				return false;
			}


			
		}
		public static Armor GetArmorById(int id)
		{
			Armor armor = null;
			ArmorData data = null;
			try
			{
				data = ctx.ArmorDatas.Where(data => data.Id == id).First();
			}
			catch (Exception)
			{

			}
			
			ConvertArmor(ref armor,ref data);

			return armor;
		}
		public static int UploadArmor(Armor armor)
		{
			if (armor == null)
				return -1;

			ArmorData data = null;
			if (ConvertArmor(ref armor, ref data))
			{
				Item armorItem = new Item() { Name = armor.Name,ItemType = COMMON_VALUES.ITEM_TYPE.ARMOR};
				ctx.Items.Add(armorItem);
				var last = ctx.Items.OrderBy(i => i.Id).LastOrDefault();
				if (last == null)
				{
					data.ArmorCommonData = armorItem;
					data.ArmorCommonDataId = 1;
				}
				else
				{
					data.ArmorCommonData = armorItem;
					data.ArmorCommonDataId = last.Id + 1;
				}
				ctx.ArmorDatas.Add(data);
				ctx.SaveChanges();
			}
			else
				return -1;

			return data.Id;
		}
		public static bool CreateCharacter(Character character, User user = null)
		{
			if (user == null && currentlyLoggedInUser != null)
			{
				user = currentlyLoggedInUser;
			}
			UserCharacter userCharacter = new UserCharacter()
			{
				User = user,
				Character = UploadCharacter(character)
			};
			userCharacter.CharacterId = userCharacter.Character.Id;
			userCharacter.UserId = user.Id;
			try
			{
				ctx.UserCharacters.Add(userCharacter);
				ctx.SaveChanges();
				return true;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
		public static CharacterData UploadCharacter(Character character)
		{
			CharacterData data = new CharacterData();
			CharacterInventory inventory = new CharacterInventory();
			data.HeadId = UploadArmor(character.Head as Armor);
			data.Head = character.Head as Item;
			data.ShouldersId = UploadArmor(character.Shoulders as Armor);
			data.Shoulders = character.Shoulders as Item;
			data.ArmsId = UploadArmor(character.Arms as Armor);
			data.Arms = character.Arms as Item;
			data.HandsId = UploadArmor(character.Hands as Armor);
			data.Hands = character.Hands as Item;
			data.WaistId = UploadArmor(character.Waist as Armor);
			data.Waist = character.Waist as Item;
			data.ChestId = UploadArmor(character.Chest as Armor);
			data.Chest = character.Chest as Item;
			data.LegsId = UploadArmor(character.Legs as Armor);
			data.Legs = character.Legs as Item;
			data.FeetId = UploadArmor(character.Feet as Armor);
			data.Feet = character.Feet as Item;
			data.MainHandId = UploadWeapon(character.MainHand as Weapon);
			data.MainHand = character.MainHand as Item;
			data.Health = character.Health;
			data.Mana = character.Mana;
			data.StaminaRegenerationRate = character.StaminaRegenerationRate;
			data.Stamina = character.Stamina;
			data.ManaRegenerationRate = character.ManaRegenerationRate;
			ctx.CharacterDatas.Add(data);
			ctx.SaveChanges();
			return data;
		}
	}
}