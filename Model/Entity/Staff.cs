using Libriary.Entity.Bases;
using Libriary.Entity.Statuses;
using System.ComponentModel.DataAnnotations.Schema;

namespace Libriary.Entity;

[Table("Staff")]
public class Staff : Human
{
    #region Fields
    public StaffRole Role { get; set; }
    #endregion

    #region Constructors
    public Staff() { }
    public Staff(StaffRole role, Human human)
                : base(human.Login, human.Password, human.Email, human.PhoneNumber, human.DateOfRegister,
                      human.FirstName, human.LastName, human.MiddleName, human.Birthday)
    {
        Role = role;
    }
    #endregion

    #region Methods
    #endregion
}
