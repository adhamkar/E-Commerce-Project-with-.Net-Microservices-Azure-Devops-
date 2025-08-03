using E_Commerce.Core.DTOs;
using E_Commerce.Core.ServiceContracts.Interfaces.UserSerice;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUserService _userservice;
        public AuthenticationController(IUserService userService)
        {
            _userservice = userService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin userLogin)
        {
            if(userLogin==null) return BadRequest("Invalide Registration Data");
            
            UserAuthentificationResponse? user = await _userservice.Login(userLogin);
            if (user == null || !user.Success) return Unauthorized(user);

            return Ok(user);
        }
        //[Route("Registration")]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest registerRequest)
        {
            if (registerRequest == null) return BadRequest("Invalide Registration Data");
            UserAuthentificationResponse? user =await _userservice.Register(registerRequest);

            if (user == null || !user.Success) return BadRequest(user);
            return Ok(user);

        }
    }
}
