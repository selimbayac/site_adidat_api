using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Data.Repositories.Daire
{
    public class DaireRepositories : IDaireRepositories
    {
        private readonly IGenericRepository<Entities.Daire>_genericRepository;
        
        private readonly IConfiguration _configuration;

        public DaireRepositories(IGenericRepository<Entities.Daire> genericRepository, IConfiguration configuration)
        {
            _genericRepository = genericRepository;
            _configuration = configuration;
        }

        public Task<Entities.Daire> DeleteAsync(int id)
        {
            return _genericRepository.DeleteAsync(id);
        }

        public Task<Entities.Daire> DeleteAsync(Guid id)
        {
            return _genericRepository.DeleteAsync(id);
        }

        public Task<IEnumerable<Entities.Daire>> GetAllAsync()
        {
            return _genericRepository.GetAllAsync();
        }

        public Task<Entities.Daire> GetByIdAsync(int id)
        {
           return _genericRepository.GetByIdAsync(id);
        }

        public Task<Entities.Daire> GetByIdAsync(Guid id)
        {
            return _genericRepository.GetByIdAsync(id);
        }

        public Task<Entities.Daire> InsertAsync(Entities.Daire entity)
        {
            return _genericRepository.InsertAsync(entity);
        }

         public Task<Entities.Daire> LoadAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Daire> UpdateAsync(Entities.Daire entity)
        {
           return _genericRepository.UpdateAsync(entity);
        }
    }
}
