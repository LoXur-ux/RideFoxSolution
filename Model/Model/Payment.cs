using System.ComponentModel.DataAnnotations.Schema;

namespace Librirary.Model
{
    [Table("Payment")]
    public class Payment
    {
        #region Fields
        public int Id { get; set; }
        public string PaymentLink { get; set; }
        public virtual Client Client { get; set; }
        public virtual Rent Rent { get; set; }
        public decimal Price { get; set; }
        public DateTime TimePayment { get; set; }
        #endregion

        #region Constructors
        public Payment()
        {
        }

        public Payment(int id, string paymentLink, Client client, Rent rent, decimal price, DateTime timePayment)
        {
            Id = id;
            PaymentLink = paymentLink;
            Client = client;
            Rent = rent;
            Price = price;
            TimePayment = timePayment;
        }
        #endregion

        #region Methods
        #endregion
    }
}
