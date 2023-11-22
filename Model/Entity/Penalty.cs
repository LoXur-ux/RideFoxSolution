﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Penalty")]
public class Penalty
{
	#region Fields

	[Key] public int Id { get; set; }
	[Required] public Client Client { get; set; }
	[Required] public string Link { get; set; }
	[Required] public DateTime Date { get; set; }
	[Required] public string State { get; set; }
	[Required] public Address Address { get; set; }
	[Required] public Address MVDAddress { get; set; }
	[Required] public string InspectorFIO { get; set; }
	[Required] public string Description { get; set; }

	#endregion

	#region Constructors
	
	public Penalty() { }

	public Penalty(int id, Client client, string link, DateTime date, string state, 
		Address address, Address mVDAddress, string inspectorFIO, string description)
	{
		Id = id;
		Client = client;
		Link = link;
		Date = date;
		State = state;
		Address = address;
		MVDAddress = mVDAddress;
		InspectorFIO = inspectorFIO;
		Description = description;
	}

	#endregion
}
