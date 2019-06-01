using Microsoft.EntityFrameworkCore;
using ODataCoreExample.Db.Entities;

namespace NorthwindEFCore
{
	public class NorthwindDbContext : DbContext
	{
		public NorthwindDbContext()
		{
		}

		public NorthwindDbContext(DbContextOptions<NorthwindDbContext> options)
				: base(options)
		{ }

		public DbSet<Category> Categories { get; set; }
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Employee> Employees { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Shipper> Shippers { get; set; }
		public DbSet<Supplier> Suppliers { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);

			base.OnModelCreating(modelBuilder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=NorthwindDB.sqlite");
			base.OnConfiguring(optionsBuilder);
		}
	}
}