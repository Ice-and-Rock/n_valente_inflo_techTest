using System.Linq;
using UserManagement.Services.Domain.Interfaces;
using UserManagement.Web.Models.Users;

namespace UserManagement.WebMS.Controllers;

[Route("users")]
public class UsersController : Controller
{
    private readonly IUserService _userService;
    public UsersController(IUserService userService) => _userService = userService;


    [HttpGet]
    public ViewResult List()
    {
        var items = _userService.GetAll().Select(p => new UserListItemViewModel
        {
            Id = p.Id,
            Forename = p.Forename,
            Surname = p.Surname,
            Email = p.Email,
            IsActive = p.IsActive,
            DateOfBirth = p.DateOfBirth
        });

        var model = new UserListViewModel
        {
            Items = items.ToList()
        };

        return View(model);
    }


    // Active List of users
    [HttpGet("active")]
    // Define the action for asp-action="" 
    public ViewResult ListActive()
    {
        // capture the active users using FilterByActive()
        var activeItems = _userService.FilterByActive(true).Select(p => new UserListItemViewModel
        {
            Id = p.Id,
            Forename = p.Forename,
            Surname = p.Surname,
            Email = p.Email,
            IsActive = p.IsActive,
            DateOfBirth = p.DateOfBirth
        });

        // create a new userList model and assign the ${ActiveItems} to it using ToList()
        var model = new UserListViewModel
        {
            // update the Items
            Items = activeItems.ToList()
        };

        // return the model and ActiveList
        return View(model);
    }

    // NonActive List of users
    [HttpGet("nonactive")]
    // Define the action for asp-action="" 
    public ViewResult ListNonActive()
    {
        // capture the active users using FilterByActive()
        var nonActiveItems = _userService.FilterByActive(false).Select(p => new UserListItemViewModel
        {
            Id = p.Id,
            Forename = p.Forename,
            Surname = p.Surname,
            Email = p.Email,
            IsActive = p.IsActive,
            DateOfBirth = p.DateOfBirth
        });

        // create a new userList model and assign the £{nonActiveItems} to it using ToList()
        var model = new UserListViewModel
        {
            // update the Items
            Items = nonActiveItems.ToList()
        };

        // return the model and ActiveList
        return View(model);
    }
}
