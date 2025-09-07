using Microsoft.EntityFrameworkCore;
using MVCDay1.DAL.Entities;

namespace MVCDay1.DAL.Database
{
	public class ApplicationDbContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=.;Database=MVCDAY1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
		}
		public DbSet<Employee>Employees { get; set; }
	}
}