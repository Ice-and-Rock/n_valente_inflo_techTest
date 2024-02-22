
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserManagement.Models;

public class User
{
    // entities define the structure of the data

    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }
    public string Forename { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public string Email { get; set; } = default!;
    public bool IsActive { get; set; }

    // add DateOfBirth to the user class
    // without the ? (which checks if there is a value) the DoB is set to 00/00/0000
    public System.DateTime DateOfBirth { get; set; }
}
