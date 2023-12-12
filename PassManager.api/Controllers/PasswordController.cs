using Microsoft.AspNetCore.Mvc;
using PassManager.Domain.Interfaces;

namespace PassManager.api.Controllers
{
    [ApiController]
    [Route("password")]
    public class PasswordController : ControllerBase
    {

        private IPasswordService _passwordService;

        public PasswordController(IPasswordService passwordService)
        {
            _passwordService = passwordService;
        }

        [HttpGet("GetProfilePictureByUsername")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> GetPasswordsByUserId(int id)
        {
            var password = await _passwordService.GetPasswordByuserId(id);
            return Ok(password);
        }
    }
}
