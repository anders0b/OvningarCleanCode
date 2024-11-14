using OvningarCleanCode.entities;
using OvningarCleanCode.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods
{
    public interface IUserService
    {
        void CreateUser(User user);
        User FindUserById(int id);
        void DeleteUser(int id);
    }
}
public class UserService
{
    private readonly IUserService _userService;
    public UserService(IUserService userService)
    {
        _userService = userService;
    }
    public void AddUser(User user)
    {
        _userService.CreateUser(user);
    }
    public User FindUser(int id)
    {
       var user = _userService.FindUserById(id);
        return user;
    }
    public void RemoveUser(int id)
    {
        _userService.DeleteUser(id);
    }
}
