using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AuthLogin.Models;
using AuthLogin.Models.Domain;
using AuthLogin.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace AuthLogin.Repositories
{
    public class AuthenticateLogin : ILogin 
    {
        private readonly DatabaseContext _context;
        public AuthenticateLogin(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<LoginModel> AuthenticateUser( string username, string password)
        {
            var succeeded = await _context.LoginModel.FirstOrDefaultAsync( authUser => authUser.username == username && authUser.password == password); //authUser => authUser.userId == userId &&
            return succeeded;
        }

        //public Task<LoginModel> AuthenticateUser(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<LoginModel>> getuser()
        {
            return await _context.LoginModel.ToListAsync();
        }
    }
}
