using System.Threading.Tasks;
using Dating.api.Data;
using Dating.api.DTO;
using Dating.api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dating.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private readonly IAuthRepository _repo;
        public UserController(IAuthRepository repo)
        {
            _repo = repo;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserForRegistrationDTO userForRegistrationDTO)
        {
            var exists = await _repo.UserExists(userForRegistrationDTO.UserName);
            if(exists)
            {
                return BadRequest("we have that user in our repo !");
            }

            var user = await _repo.Register(new User(){UserName = userForRegistrationDTO.UserName},userForRegistrationDTO.Passwor);
            
            return StatusCode(201);
        } 

    }
}