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
		}
    }
}
