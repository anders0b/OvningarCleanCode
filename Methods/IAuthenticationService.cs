using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OvningarCleanCode.Methods;

public interface IAuthenticationService
{
    bool Authenticate(string username, string password);
}

public class LoginService
{
    private readonly IAuthenticationService _authenticationService;
    public LoginService(IAuthenticationService authentication)
    {
        _authenticationService = authentication;
    }
    public bool VerifyLogin(string username, string password)
    {
        var result = _authenticationService.Authenticate(username, password);
        return result;
    }
}
