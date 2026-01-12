using JobManagement.Applicant.Data.Models;
using JobManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;
        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userService.GetAllUsers();
            return Ok(users);
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                var user = await _userService.GetUserById(id);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpGet("email/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            try
            {
                var user = await _userService.GetUserByEmail(email);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] user user)
        {
            await _userService.AddUser(user);
            return Ok(new
            {
                success = true,
                message = "User added successfully"
            });
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] user user)
        {
            await _userService.UpdateUser(user);
            return Ok(new
            {
                success = true,
                message = "User updated successfully"
            });
        }
    }
}

