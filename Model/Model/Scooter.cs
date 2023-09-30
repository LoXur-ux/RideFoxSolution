using Librirary.Model.Statuses;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Librirary.Model
{
    [Table("Scooter")]
    public class Scooter
    {
        #region Fields
        public int Id { get; set; }
        [Required] public string ScooterName { get; set; } = string.Empty;
        [Required] public DateTime DateOfCommissioning { get; set; } = DateTime.Now;
        [Required] public ScooterStatus Status { get; set; } = ScooterStatus.Available;
        #endregion

        #region Constructors
        public Scooter(int id, string scooterName, DateTime dateOfCommissioning, ScooterStatus status)
        {
            Id = id;
            ScooterName = scooterName;
            DateOfCommissioning = dateOfCommissioning;
            Status = status;
        }
        #endregion
    }
}