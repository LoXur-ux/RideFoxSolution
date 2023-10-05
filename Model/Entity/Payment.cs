using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Payment")]
public class Payment
{
	#region Fields
	public int Id { get; set; }
	public string PaymentLink { get; set; }
	public decimal Price { get; set; }
	public DateTime TimePayment { get; set; }
	#endregion

	#region Constructors
	public Payment() { }

	public Payment(int id, string paymentLink, decimal price, DateTime timePayment)
	{
		Id = id;
		PaymentLink = paymentLink;
		Price = price;
		TimePayment = timePayment;
	}
	#endregion

	#region Methods
	#endregion
}
