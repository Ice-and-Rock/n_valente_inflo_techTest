namespace UserManagement.Web.Models.Users;

public class UserListViewModel
{
    public List<UserListItemViewModel> Items { get; set; } = new();
}

// recieves the list of items in an array from UsersController
public class UserListItemViewModel
{
    public long Id { get; set; }
    public string? Forename { get; set; }
    public string? Surname { get; set; }
    public string? Email { get; set; }
    public bool IsActive { get; set; }

    // add DateOfBirth to the user class
    // if there is no value the DoB resorts to 01/01/0001
    public System.DateTime DateOfBirth { get; set; }

}
