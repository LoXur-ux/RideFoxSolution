namespace Libriary.Entity.Units;

public class Address
{
	#region Fields
	public string Town { get; set; }
	public string Street { get; set; }
	public string Number { get; set; }
	public string Build { get; set; }
	#endregion

	#region Constructors
	public Address()
	{
	}

	public Address(string town, string street, string number, string build)
	{
		Town = town;
		Street = street;
		Number = number;
		Build = build;
	}
	#endregion
}
