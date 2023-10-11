using System.Collections.Generic;
using System.Threading.Tasks;
using AuthLogin.Models;
using AuthLogin.Models.Domain;

namespace AuthLogin.Repositories
{
    public interface ILogin
    {
        Task<IEnumerable<LoginModel>> getuser();
        Task<LoginModel> AuthenticateUser( string username, string password);
    }
}
