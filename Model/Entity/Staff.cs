using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Libriary.Entity.Bases;
using Libriary.Entity.Statuses;

namespace Libriary.Entity;

[Table("Staff")]
public class Staff : Human
{
	#region Fields

	[Required] public StaffRole Role { get; set; }
	public ICollection<Service> Services { get; set; }

	#endregion

	#region Constructors

	public Staff() { }
	public Staff(StaffRole role, ICollection<Service> services, Human human)
				: base(human.Login, human.Password, human.Email, human.PhoneNumber, human.DateOfRegister,
					  human.FirstName, human.LastName, human.MiddleName, human.Birthday)
	{
		Role = role;
		Services = services;
	}

	#endregion

	#region Methods
	#endregion
}
