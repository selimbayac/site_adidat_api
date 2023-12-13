using LMS.Data.Entities;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories.User
{
    public interface IUserRepository : IGenericRepository<Entities.User>
    {

        // Task<Entities.User> AuthenticateAsync(string email, string password);
        //    Task<Entities.User> GetByEmailAndPasswordAsync(string email, string password);
      
    }
}
