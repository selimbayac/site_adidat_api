using LMS.Data.Entities;
using LMS.Data.Repositories.User;
using LMS.Service.Helpers;
using LMS.Services.Moldels.User;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Service.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userService)
        {
            _userRepository = userService;
        }

        public async Task<User> DeleteAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);// gereksiz
        }

        public async Task<User> DeleteAsync(Guid id)
        {
            return await _userRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);// buda sileriz 
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public Task<User> InsertAsync(User entity)
        {
            return _userRepository.InsertAsync(entity);
        }

        public async Task<User> LoginAsync(string username, string password)
        {
            return await _userRepository.LoadAsync(username, password);
        }

        public Task<User> UpdateAsync(User entity)
        {
            return _userRepository.UpdateAsync(entity);
        }
    }
}
