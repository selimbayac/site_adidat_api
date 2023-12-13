using AutoMapper;
using LMS.Data.Entities;
using LMS.Data.Repositories.Aidat;
using LMS.Services.Moldels.Aidat;
using LMS.Services.Moldels.Daire;
using LMS.Services.Service.AidatService;
using LMS.Services.Service.DaireService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Site_aidat_apı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AidatController : ControllerBase
    {
        private readonly IAidatService _aidatService;
        private readonly IMapper _mapper;

        public AidatController(IAidatService aidatService, IMapper mapper)
        {
            _aidatService = aidatService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Aidat>> AidatGetir()
        {
            return await _aidatService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<Aidat> Get(int id)
        {
            return await _aidatService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<Aidat> AidatAdd([FromBody] AidatRequestModels aidat)
        {
            var veri = _mapper.Map<Aidat>(aidat);
            return await _aidatService.InsertAsync(veri);
        }
        [HttpPut("{id}")]
        public async Task<Aidat> Update([FromBody] AidatUpdateRequest aidat)
        {
            var veri = _mapper.Map<Aidat>(aidat);
            return await _aidatService.UpdateAsync(veri);
        }
        [HttpDelete("{id}")]
        public async Task<Aidat> Delete([FromBody] int id)
        {
            return await _aidatService.DeleteAsync(id);
        }
    }
}
