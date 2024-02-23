using System;
using System.Collections.Generic;
using System.Linq;
using UserManagement.Data;
using UserManagement.Models;
using UserManagement.Services.Domain.Interfaces;

namespace UserManagement.Services.Domain.Implementations;

public class UserService : IUserService
{
    private readonly IDataContext _dataAccess;
    public UserService(IDataContext dataAccess) => _dataAccess = dataAccess;

    /// <summary>
    /// Return users by active state
    /// </summary>
    /// <param name="isActive"></param>
    /// <returns></returns>

    // defines FilterByActive types and logic
    public IEnumerable<User> FilterByActive(bool isActive)
    {
        /// Old line 
        /// throw new NotImplementedException();
        /// return the logic filter
        return _dataAccess.GetAll<User>().Where(eachUser => eachUser.IsActive == isActive);

    }
    // defines GetAll logic
    public IEnumerable<User> GetAll() => _dataAccess.GetAll<User>();
}
