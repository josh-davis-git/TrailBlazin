using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrailBlazinAPI.Models;
using TrailBlazinAPI.Repository.IRepository;

namespace TrailBlazinAPI.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        public User Register(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
