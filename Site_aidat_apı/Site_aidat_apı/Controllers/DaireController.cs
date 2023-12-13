using AutoMapper;
using LMS.Data.Entities;
using LMS.Data.Repositories.Daire;
using LMS.Services.Moldels.Daire;
using LMS.Services.Service.DaireService;
using LMS.Services.Service.UserService;
using Microsoft.AspNetCore.Mvc;

namespace Site_aidat_apı.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class DaireController : Controller
    {
    
        private readonly IDaireService _daireService;
        private readonly IMapper _mapper;

        public DaireController(IDaireService daireService, IMapper mapper)
        {
            _daireService = daireService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<Daire>> DaireGet()
        {
            return await _daireService.GetAllAsync();
        }
        [HttpGet("{id}")]
        public async Task<Daire> Get(int id)
        {
            return await _daireService.GetByIdAsync(id);
        }
        [HttpPost("DaireEkle")]
        public async Task<Daire> DaireAdd([FromBody] DaireRequestModel daireRepositories)
        {
            var daire = _mapper.Map<Daire>(daireRepositories);
            return await _daireService.InsertAsync(daire);
        }
        [HttpPut("{id}")]
        public async Task<Daire> Update([FromBody] DaireRequestModel daireRepositories)
        {
            var daire = _mapper.Map<Daire>(daireRepositories);
            return await _daireService.UpdateAsync(daire);
        }
        [HttpDelete("{id}")]
        public async Task<Daire> Delete([FromBody] int  id)
        {
            return await _daireService.DeleteAsync(id);
        }
    }
}
