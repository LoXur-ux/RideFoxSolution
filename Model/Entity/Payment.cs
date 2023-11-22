﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Payment")]
public class Payment
{
	#region Fields

	[Key] public int Id { get; set; }
	[Required] public string PaymentLink { get; set; }
	[Required] public decimal Price { get; set; }
	[Required] public DateTime TimePayment { get; set; }

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
