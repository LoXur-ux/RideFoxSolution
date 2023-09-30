using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Libriary.Entity.Bases;

namespace Libriary.Entity;

[Table("Client")]
public class Client : Human
{
    #region Fields
    [Required] public int RentCount { get; set; } = 0;
    #endregion

    #region Constructors
    public Client() { }
    public Client(Human human) 
        : base(human.Login, human.Password, human.Email, human.PhoneNumber, human.DateOfRegister, 
              human.FirstName, human.LastName, human.MiddleName, human.Birthday)
    {
        RentCount = 0;
    }
    #endregion

    #region Methods
    #endregion
}
