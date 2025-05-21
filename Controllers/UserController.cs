using LifeTrackr.API.Application;
using LifeTrackr.API.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LifeTrackr.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        public UserController()
        {
            _userRepository = new UserRepository();
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _userRepository.GetAllUsers();
            return Ok(users.Select(u => new FetchUserDto
            {
                Id = u.Id,
                Email = u.Email,
                FullName = u.FullName
            }));
        }
    }
}
