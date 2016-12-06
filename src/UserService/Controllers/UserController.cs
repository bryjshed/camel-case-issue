using Microsoft.AspNetCore.Mvc;

namespace UserService
{
    [Route("[controller]")]
    [Produces("application/json")]
    public class UserController : Controller
    {
        /// <summary>
        /// Get a user 
        /// </summary>
        /// <param name="userDto">User to get</param>
        /// <response code="200">Ok</response>
        /// <response code="400">Bad Request</response>
        /// <returns>UserDto</returns>
        [HttpGet]
        public IActionResult CreateUser([FromQuery] UserDto userDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(userDto);
        }
    }
}