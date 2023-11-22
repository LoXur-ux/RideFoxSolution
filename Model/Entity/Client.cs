﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Libriary.Entity.Bases;

namespace Libriary.Entity;

[Table("Client")]
public class Client : Human
{
	#region Fields
	[Required] public int RentCount { get; set; } = 0;
	[Required] public ICollection<Rent> Rents { get; set; }
	public virtual ICollection<Penalty> Penalties { get; set; }
	#endregion

	#region Constructors

	public Client() { }
	public Client(Human human, ICollection<Rent> rents)
		: base(human.Login, human.Password, human.Email, human.PhoneNumber, human.DateOfRegister,
			  human.FirstName, human.LastName, human.MiddleName, human.Birthday)
	{
		RentCount = 0;
		Rents = rents ?? new List<Rent>();
	}

	#endregion

	#region Methods
	#endregion
}
