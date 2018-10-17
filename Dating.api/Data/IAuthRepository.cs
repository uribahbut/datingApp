using System.Threading.Tasks;
using Dating.api.Models;

namespace Dating.api.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user,string password);

         Task<User> Login(string userName , string password);

         Task<bool> UserExists(string userName);

    }
}