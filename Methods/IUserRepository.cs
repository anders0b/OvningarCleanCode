using OvningarCleanCode.entities;
namespace OvningarCleanCode.Methods;

public interface IUserRepository
{
    void AddUser(User user);
    void UpdateUser(User user);
    User GetUserById(int id);
    void DeleteUser(int id);
}
public class UserRepoService
{
    private readonly IUserRepository _userRepository;
    public UserRepoService(IUserRepository userRepository)
    {
        _userRepository = userRepository;

    }
    public void AddUser(User user)
    {
        _userRepository.AddUser(user);
    }
    public void RemoveUser(int id)
    {
        _userRepository.DeleteUser(id);
    }
    public User GetUserById(int id)
    {
        return _userRepository.GetUserById(id);
    }
    public void UpdateUser(User user)
    {
        _userRepository.UpdateUser(user);
    }

}
