using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Models
{
	public class GameDbContext : DbContext
	{
        public DbSet<User> Users { get; set; }
        public DbSet<CharacterData> CharacterDatas { get; set; }
        public DbSet<UserCharacter> UserCharacters { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ArmorData> ArmorDatas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=GameDatabase;Integrated Security=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<User>()
                 .HasCheckConstraint("CK_Users_Email", "Email like '%@%'")
                 .HasCheckConstraint("CK_Users_Age", "Age > 13");
            modelBuilder.Entity<User>()
                .HasIndex(s => s.Name).IsUnique();
            modelBuilder.Entity<User>()
                .HasIndex(s => s.Email).IsUnique();
            modelBuilder.Entity<UserCharacter>()
                .HasKey(nameof(UserCharacter.UserId), nameof(UserCharacter.CharacterId));

        }
    }
}
