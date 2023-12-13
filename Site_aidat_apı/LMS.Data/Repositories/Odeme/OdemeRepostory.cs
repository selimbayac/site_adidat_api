using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories.Odeme
{
    public class OdemeRepostory : IOdemeRepostory
    {
        private readonly IGenericRepository<Entities.Odeme> _genericRepository;
        private readonly IConfiguration _configuration;

        public OdemeRepostory(IGenericRepository<Entities.Odeme> genericRepository, IConfiguration configuration)
        {
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public async Task<Entities.Odeme> DeleteAsync(int id)
        {
            return await _genericRepository.DeleteAsync(id);
        }

        public async Task<Entities.Odeme> DeleteAsync(Guid id)
        {
            return await _genericRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Entities.Odeme>> GetAllAsync()
        {
            return await _genericRepository.GetAllAsync();
        }

        public async Task<Entities.Odeme> GetByIdAsync(int id)
        {
           return await _genericRepository.GetByIdAsync(id);
        }

        public async Task<Entities.Odeme> GetByIdAsync(Guid id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public Task<Entities.Odeme> InsertAsync(Entities.Odeme entity)
        {
           return _genericRepository.InsertAsync(entity);
        }

        public Task<Entities.Odeme> LoadAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Odeme> UpdateAsync(Entities.Odeme entity)
        {
            return _genericRepository.UpdateAsync(entity);
        }
    }
}
