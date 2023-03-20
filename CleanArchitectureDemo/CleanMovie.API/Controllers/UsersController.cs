using CleanMovie.Application.Security;
using CleanMovie.Domain.Security;
using CleanMovieDomain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Authorize]
    [Route("api/[Controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public UsersController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return Ok("Tested");
        }

        [Route("authenticate")]
       [AllowAnonymous]
        [HttpPost]
        public IActionResult Authenticate(User usersdata)
        {
            var token = _tokenService.Authenticate(usersdata);

            if (token == null)
            {
                return Unauthorized("User does not exist!!");
            }

            return Ok(token);
        }
    }
}
