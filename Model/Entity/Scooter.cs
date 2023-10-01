using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Libriary.Entity.Statuses;

namespace Libriary.Entity;

[Table("Scooter")]
public class Scooter
{
	#region Fields
	public int Id { get; set; }
	[Required] public string ScooterName { get; set; }
	[Required] public DateTime DateOfCommissioning { get; set; } = DateTime.Now;
	[Required] public ScooterStatus Status { get; set; } = ScooterStatus.Available;
	[Required] public virtual ICollection<Rent> Rents { get; set; }
	[Required] public virtual ICollection<Service> Services { get; set; }
	#endregion

	#region Constructors
	public Scooter() { }
	public Scooter(int id, string scooterName, DateTime dateOfCommissioning, ScooterStatus status, ICollection<Rent> rents, ICollection<Service> services)
	{
		Id = id;
		ScooterName = scooterName;
		DateOfCommissioning = dateOfCommissioning;
		Status = status;
		Rents = rents ?? new List<Rent>();
		Services = services;
	}
	#endregion
}