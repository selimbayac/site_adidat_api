using LMS.Data.Entities;
using LMS.Data.Repositories.Odeme;
using LMS.Data.Repositories.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Services.Service.OdemeService
{
    public class OdemeService : IOdemeService
    {
        private readonly IOdemeRepostory _odemeRepository;

        public OdemeService(IOdemeRepostory odemeRepository)
        {
            _odemeRepository = odemeRepository;
        }

        public async Task<Odeme> DeleteAsync(int id)
        {
            return await _odemeRepository.DeleteAsync(id);
        }

        public  async Task<Odeme> DeleteAsync(Guid id)
        {
            return await _odemeRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Odeme>> GetAllAsync()
        {
           return await _odemeRepository.GetAllAsync();
        }

        public async Task<Odeme> GetByIdAsync(int id)
        {
            return await _odemeRepository.GetByIdAsync(id);
        }

        public async Task<Odeme> GetByIdAsync(Guid id)
        {
            return await _odemeRepository.GetByIdAsync(id);
        }

        public async Task<Odeme> InsertAsync(Odeme entity)
        {
           return await _odemeRepository.InsertAsync(entity);
        }

        public async Task<Odeme> UpdateAsync(Odeme entity)
        {
           return await _odemeRepository.UpdateAsync(entity);
        }
    }
}
