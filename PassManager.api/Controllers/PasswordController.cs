using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using PassManager.api.Models;
using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;
using System.Text;

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

        [HttpGet("GetPasswordByUserId")]
        [DisableRequestSizeLimit]
        public async Task<ActionResult> GetPasswordsByUserId(int userId)
        {
            var password = await _passwordService.GetPasswordByuserId(userId);
            return Ok(password);
        }

        [HttpPost("PostNewPassword")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> PostNewPassword(StoredPasswordDTO storedPasswordDTO)
        {
            // encrypt the password
            byte[] encrypted = KeyDerivation.Pbkdf2(
                password: storedPasswordDTO.Password,
                salt: Encoding.UTF8.GetBytes("s5melyFWJG(7EX7d-0Xi"),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100,
                numBytesRequested: 64);

            string encryptedString = Encoding.UTF8.GetString(encrypted);

            StoredPassword storedPassword = new()
            {
                Website = storedPasswordDTO.Website,
                Password = encryptedString,
                Thumbnail = storedPasswordDTO.Thumbnail,
                UserID = storedPasswordDTO.UserID,
                Tag = storedPasswordDTO.Tag,
            };

            bool createSucces = await _passwordService.Create(storedPassword);

            if (createSucces == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest(new
                {
                    Message = $"A critical error has occurred and the password has not been saved."
                });
            }
        }
    }
}
