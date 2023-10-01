﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Libriary.Entity.Units;

namespace Libriary.Entity;

[Table("Path")]
public class Path
{
	#region Fields

	[Key] public int Id { get; set; }
	[Required] public Address AddressFrom { get; set; }
	[Required] public Address AddressTo { get; set; }
	public decimal PathLenght {  get; set; }

	#endregion

	#region Constructors
	public Path()
	{
	}

	public Path(int id, Address addressFrom, Address addressTo)
	{
		Id = id;
		AddressFrom = addressFrom;
		AddressTo = addressTo;
	}
	#endregion
}
