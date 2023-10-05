using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Penalty")]
public class Penalty
{
	[Key] public int Id { get; set; }
	[Required] public Client Client { get; set; }
	[Required] public string Link { get; set; }
	[Required] public DateTime Date { get; set; }
	[Required] public string State { get; set; }
	[Required] public Address Address { get; set; }
	[Required] public Address MVDAddress { get; set; }
	[Required] public string InspectorFIO { get; set; }
	[Required] public string Description { get; set; }
}
