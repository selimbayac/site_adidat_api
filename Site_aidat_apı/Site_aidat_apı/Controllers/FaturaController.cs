using AutoMapper;
using LMS.Data.Entities;
using LMS.Services.Moldels.Fatura;
using LMS.Services.Moldels.User;
using LMS.Services.Service.FaturaService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Site_aidat_apı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FaturaController : ControllerBase
    {
        readonly private IFaturaSerive _faturaService;
        readonly private IMapper _mapper;

        public FaturaController(IFaturaSerive faturaService, IMapper mapper)
        {
            _faturaService = faturaService;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<Fatura> Faturagetid(int id)
        {
        
            return await _faturaService.GetByIdAsync(id);
        }
        [HttpGet]
        public async Task<IEnumerable<Fatura>> FaturaGet()
        {
            return await _faturaService.GetAllAsync();
        }
        [HttpPost]
        public async Task<Fatura> FaturaAdd([FromBody] FaturaRequestModel fatura)
        {
            var fatıraorg = _mapper.Map<Fatura>(fatura);
            return await _faturaService.InsertAsync(fatıraorg);
        }
        [HttpPut("{id}")]
        public async Task<Fatura> FaturaUpdate([FromBody] Fatura fatura)
        {
            return await _faturaService.UpdateAsync(fatura);
        }
        [HttpDelete("{id}")]
        public async Task<Fatura> FaturaDelete([FromBody] int id )
        {
            return await _faturaService.DeleteAsync(id);
        }
    }
}
