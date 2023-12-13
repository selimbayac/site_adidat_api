using AutoMapper;
using LMS.Data.Entities;
using LMS.Services.Moldels.Fatura;
using LMS.Services.Moldels.Odeme;
using LMS.Services.Service.FaturaService;
using LMS.Services.Service.OdemeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Site_aidat_apı.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OdemeController : ControllerBase
    {
        readonly private IOdemeService _odemeService;
        readonly private IMapper _mapper;
        public OdemeController(IOdemeService odemeService, IMapper mapper)
        {
            _odemeService = odemeService;
            _mapper = mapper;
        }
        [HttpGet("{id}")]
        public async Task<Odeme> Faturagetid(int id)
        {

            return await _odemeService.GetByIdAsync(id);
        }
        [HttpGet]
        public async Task<IEnumerable<Odeme>> FaturaGet()
        {
            return await _odemeService.GetAllAsync();
        }
        [HttpPost]
        public async Task<Odeme> FaturaAdd([FromBody] OdemeRequestModel model)
        {
            var odeme = _mapper.Map<Odeme>(model);
            return await _odemeService.InsertAsync(odeme);
        }
        [HttpPut("{id}")]
        public async Task<Odeme> FaturaUpdate([FromBody] OdemeUpdateRequest model)
        {
            var odeme = _mapper.Map<Odeme>(model);
            return await _odemeService.UpdateAsync(odeme);
        }
        [HttpDelete("{id}")]
        public async Task<Odeme> FaturaDelete([FromBody] int id)
        {
            return await _odemeService.DeleteAsync(id);
        }
    }
}
