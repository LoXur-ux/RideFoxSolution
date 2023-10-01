using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Libriary.Entity.Statuses;

namespace Libriary.Entity;

[Table("Rent")]
public class Rent
{
	#region Field

	[Key] public int Id { get; set; }
	[Required] public virtual Client Client { get; set; }
	[Required] public virtual Scooter Scooter { get; set; }
	[Required] public RentStatus Status { get; set; } = RentStatus.Active;
	[Required] public DateTime Start { get; set; } = DateTime.Now;
	public DateTime End { get; set; }

	#endregion

	#region Constructors
	public Rent() { }
	public Rent(int id, Client client, Scooter scooter, DateTime start, DateTime end, RentStatus status)
	{
		Id = id;
		Client = client;
		Scooter = scooter;
		Start = start;
		End = end;
		Status = status;
	}
	#endregion

	#region Methods
	#endregion
}
