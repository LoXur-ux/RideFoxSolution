using System.ComponentModel.DataAnnotations;

namespace Libriary.Entity;
public class Service
{
	#region Fields

	[Key] public int Id { get; set; }
	[Required] public virtual Scooter Scooter { get; set; }
	[Required] public virtual Staff Staff { get; set; }
	[Required] public string Description { get; set; }
	[Required] public DateTime Start { get; set; } = DateTime.Now;
	public DateTime End { get; set; }

	#endregion

	#region Constructors

	public Service()
	{
	}

	public Service(int id, Scooter scooter, Staff staff, string description, DateTime start, DateTime end)
	{
		Id = id;
		Scooter = scooter;
		Staff = staff;
		Description = description;
		Start = start;
		End = end;
	}

	#endregion
}
