using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories.Fatura
{
    public class FaturaRepositories : IFatruraRepositories
    {
        private readonly IGenericRepository<Entities.Fatura> _genericRepository;
        private readonly IConfiguration _configuration;

        public FaturaRepositories(IGenericRepository<Entities.Fatura> genericRepository, IConfiguration configuration)
        {
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public Task<Entities.Fatura> DeleteAsync(int id)
        {
           return _genericRepository.DeleteAsync(id);
        }

        public Task<Entities.Fatura> DeleteAsync(Guid id)
        {
            return _genericRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Entities.Fatura>> GetAllAsync()
        {
           return _genericRepository.GetAllAsync();
        }

        public Task<Entities.Fatura> GetByIdAsync(int id)
        {
            return _genericRepository.GetByIdAsync(id);
        }

        public Task<Entities.Fatura> GetByIdAsync(Guid id)
        {
            return _genericRepository.GetByIdAsync(id);
        }

        public Task<Entities.Fatura> InsertAsync(Entities.Fatura entity)
        {
            return _genericRepository.InsertAsync(entity);
        }

        public Task<Entities.Fatura> LoadAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Fatura> UpdateAsync(Entities.Fatura entity)
        {
           return _genericRepository.UpdateAsync(entity);
        }
    }
}
