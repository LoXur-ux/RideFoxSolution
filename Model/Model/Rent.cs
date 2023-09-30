using Librirary.Model.Statuses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Librirary.Model
{
    [Table("Rent")]
    public class Rent
    {
        #region Field
        [Key]
        public int Id { get; set; }
        [Required]
        public virtual Client Client { get; set; }
        [Required]
        public virtual Scooter Scooter { get; set; }
        [Required]
        public DateTime Start { get; set; } = DateTime.Now;
        [AllowNull]
        public DateTime End { get; set; }
        public RentStatus Status { get; set; } = RentStatus.Active;
        #endregion

        #region Constructors]
        public Rent(int id, Client client, Scooter scooter, DateTime start, DateTime end, RentStatus status)
        {
            Id = id;
            Client = client;
            Scooter = scooter;
            Start = start;
            End = end;
            Status = status;
        }
        #endregion

        #region Methods
        #endregion
    }
}
