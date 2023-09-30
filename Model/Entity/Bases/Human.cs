using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Libriary.Entity.Bases;

/// <summary>
/// Базовый класс, описывающий структуру всех пользователей
/// </summary>
public class Human
{
    #region Fields
    [Key] public int Id { get; set; }
    [Required] public string Login { get; set; }
    [Required] public string Password { get; set; }
    [Required] public string Email { get; set; }
    [Required] public string PhoneNumber { get; set; }
    [Required] public DateTime DateOfRegister { get; set; } = DateTime.Now;
    [Required] public string FirstName { get; set; }
    [Required] public string LastName { get; set; }
    [AllowNull] public string MiddleName { get; set; }
    public DateOnly Birthday { get; set; }
    #endregion

    #region Constructors
    public Human() { }
    public Human(string login, string password, string email, string phoneNumber, DateTime dateOfRegister, string firstName, string lastName, string middleName, DateOnly birthday)
    {
        Login = login;
        Password = password;
        Email = email;
        PhoneNumber = phoneNumber;
        DateOfRegister = dateOfRegister;
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Birthday = birthday;
    }
    #endregion

    #region Methods

    #endregion
}
