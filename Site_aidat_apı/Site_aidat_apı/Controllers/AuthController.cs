using Microsoft.AspNetCore.Mvc;
using Site_aidat_apı.Models;

namespace Site_aidat_apı.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        [HttpPost()]
        public ResponseModel Logim(LoginModel loginModel)
        {
            if(loginModel.Email == "femi" && loginModel.Password == "123")
            {
                return new ResponseModel()
                {
                    Message = "Login işlemi başarılı",
                    Code = "200",
                    Data = null

                };
            }
            else
            {
                return new ResponseModel()
                {
                    Message = "Login işlemi yok",
                    Code = "401",
                    Data = null

                };
            }
           
        }
    }
}
