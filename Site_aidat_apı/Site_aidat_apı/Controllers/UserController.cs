using AutoMapper;
using LMS.Data.Entities;
using LMS.Data.Repositories;
using LMS.Data.Repositories.User;
using LMS.Service.Helpers;
using LMS.Services.Moldels.User;
using LMS.Services.Service.UserService;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Site_aidat_apı.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        readonly Microsoft.AspNetCore.Identity.UserManager<User> _userManager;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]    
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.GetAllAsync();
        }

        [HttpGet("{id}")]
     
        public async Task<User> Get(Guid id)
        {
            return await _userService.GetByIdAsync(id);
        }
        [HttpPost]
        public async Task<User> Post([FromBody] UserRequestModel userRequestModel)
        {
            var user = _mapper.Map<User>(userRequestModel);
            return await _userService.InsertAsync(user);
        }
        [HttpPut("{id}")]
        public async Task<User> Update([FromBody] UpdateUser deney)
        {
            var user = _mapper.Map<User>(deney);
            return await _userService.UpdateAsync(user);
        }
        [HttpDelete("{id}")]
        public async Task<User> Delete([FromBody] Guid user)
        {
            return   await _userService.DeleteAsync(user);
            
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginEntity loginRequestModel)
        {
           // var user = _mapper.Map<User>(loginRequestModel);
            var result = await _userService.LoginAsync(loginRequestModel.Email, loginRequestModel.Password);

            if (result == null)
            {
                return NotFound(); // Kullanıcı bulunamadığında NotFound sonucu döndürüyoruz
            }

            if (result.RoleId == 1)
            {
                return Ok("god");
            }

            return Ok(result);
        }

    }

}

