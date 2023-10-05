using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Parking")]
public class Parking
{
	#region Fields

	[Key] public int Id { get; set; }
	[Required] public Address Address { get; set; }
	[Required] public ICollection<Scooter> Scooters { get; set; }

	#endregion

	#region Constructors

	public Parking()
	{
	}

	public Parking(int id, Address address, ICollection<Scooter> scooters)
	{
		Id = id;
		Address = address;
		Scooters = scooters ?? new List<Scooter>();
	}

	#endregion
}
