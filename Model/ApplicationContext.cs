using Libriary.Entity;
using Microsoft.EntityFrameworkCore;

namespace Librirary;

public class ApplicationContext : DbContext
{
	#region Entity

	public DbSet<Client> Clients { get; set; }
	public DbSet<Payment> Payments { get; set; }
	public DbSet<Rent> Rents { get; set; }
	public DbSet<Scooter> Scooters { get; set; }
	public DbSet<Staff> Staffers { get; set; }
	public DbSet<Parking> Parkings { get; set; }
	public DbSet<Libriary.Entity.Path> Paths { get; set; }
	public DbSet<Service> Services { get; set; }
	public DbSet<Address> Addresses { get; set; }
	public DbSet<Penalty> Penalties { get; set; }

	#endregion

	public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
	{
		Database.Migrate();
		Context.AddDb(this);
	}

	public static DbContextOptions<ApplicationContext> GetDb()
	{
		var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
		return optionBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RideFox;Username=postgres;Password=12").Options;
	}

	protected override void OnModelCreating(ModelBuilder builder)
	{
		builder.Entity<Client>().HasIndex(c => c.Email).IsUnique();
		builder.Entity<Client>().HasIndex(c => c.Login).IsUnique();
		builder.Entity<Client>().HasIndex(c => c.PhoneNumber).IsUnique();

		builder.Entity<Payment>().HasIndex(p => p.PaymentLink).IsUnique();

		builder.Entity<Scooter>().HasIndex(s => s.ScooterName).IsUnique();

		base.OnModelCreating(builder);
	}
}
