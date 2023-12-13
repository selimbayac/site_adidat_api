using LMS.Data.Entities;
using LMS.Data.Repositories.Aidat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Service.AidatService
{
    public class AidatService : IAidatService
    {
        readonly public IAidatRepositories _repository;

        public AidatService(IAidatRepositories repository)
        {
            _repository = repository;
        }

        public async Task<Aidat> DeleteAsync(int id)
        {
           return await _repository.DeleteAsync(id);
        }

        public async Task<Aidat> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Aidat>> GetAllAsync()
        {
           return  await _repository.GetAllAsync();
        }

        public async Task<Aidat> GetByIdAsync(int id)
        {
          return await _repository.GetByIdAsync(id);
        }

        public async Task<Aidat> GetByIdAsync(Guid id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Aidat> InsertAsync(Aidat entity)
        {
            return await _repository.InsertAsync(entity);
        }

        public async Task<Aidat> UpdateAsync(Aidat entity)
        {
            return await _repository.UpdateAsync(entity);
        }
    }
}
