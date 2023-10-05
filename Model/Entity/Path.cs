using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Path")]
public class Path
{
	#region Fields

	[Key] public int Id { get; set; }
	[Required] public Parking From { get; set; }
	[Required] public Parking To{ get; set; }
	public decimal PathLenght { get; set; }

	#endregion

	#region Constructors
	public Path()
	{
	}

	public Path(int id, Parking addressFrom, Parking addressTo)
	{
		Id = id;
		From = addressFrom;
		To = addressTo;
	}
	#endregion
}
