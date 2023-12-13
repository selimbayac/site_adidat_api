using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories.Aidat
{
    public class AidatRepositories : IAidatRepositories
    {
        private readonly IGenericRepository<Entities.Aidat> _genericRepository;

        private readonly IConfiguration _configuration;

        public AidatRepositories(IGenericRepository<Entities.Aidat> genericRepository, IConfiguration configuration)
        {
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public async Task<Entities.Aidat> DeleteAsync(int id)
        {
           return await _genericRepository.DeleteAsync(id);
        }

        public async Task<Entities.Aidat> DeleteAsync(Guid id)
        {
            return await _genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Entities.Aidat>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<Entities.Aidat> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.Aidat> GetByIdAsync(Guid id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.Aidat> InsertAsync(Entities.Aidat entity)
        {
            return await _genericRepository.InsertAsync(entity);
        }

        public Task<Entities.Aidat> LoadAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Aidat> UpdateAsync(Entities.Aidat entity)
        {
            return _genericRepository.UpdateAsync(entity);  
        }
    }
}
