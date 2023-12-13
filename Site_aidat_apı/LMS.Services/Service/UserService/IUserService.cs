using LMS.Data.Entities;
using LMS.Services.Moldels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Service.UserService
{
    public interface IUserService : IGenericService<User>
    {
        //  Task<User> GetByEmailAndPasswordAsync(string email, string password);
        // Task<bool> LoginAsync(UserRequestModel loginRequestModel);
        // Task<User> GetByEmailAndPasswordAsync(string email, string password);
        //  Task<User> GetByEmailAndPasswordAsync(string email, string password);
        Task<User> LoginAsync(string username, string password);
        Task<User> DeleteAsync(Guid id);
        //Task<User> AdminControl();
    }

}
