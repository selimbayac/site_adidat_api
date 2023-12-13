using LMS.Data.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories.User
{
    public class UserRepository : IUserRepository
    {
       
        private readonly IGenericRepository<Entities.User> _genericRepository;
        private readonly IConfiguration _configuration;

        public UserRepository(IGenericRepository<Entities.User> genericRepository, IConfiguration configuration)
        {
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

       

        public Task<Entities.User> DeleteAsync(int id)
        {
          return _genericRepository.DeleteAsync(id);
        }

        public Task<Entities.User> DeleteAsync(Guid id)
        {
            return _genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Entities.User>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

   

        public async Task<Entities.User> GetByIdAsync(int id)
        {
           return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.User> GetByIdAsync(Guid id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.User> InsertAsync(Entities.User entity)
        {
           return await _genericRepository.InsertAsync(entity);
        }

        public Task<Entities.User> LoadAsync(string username, string password)
        {
            return _genericRepository.LoadAsync(username, password);
        }

        public async Task<Entities.User> UpdateAsync(Entities.User entity)
        {
          return await _genericRepository.UpdateAsync(entity);  
        }

     


    }
}
