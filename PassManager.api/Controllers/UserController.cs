using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using PassManager.api.Models;
using PassManager.Domain.Models;
using System.Text;
using System.Text.RegularExpressions;

namespace PassManager.api.Controllers
{
    [ApiController]
    [Route("user")]
    public class JobController : ControllerBase
    {
        //private readonly IJobService _jobService;
        //private readonly UserManager<User> _userManager;
        private User _user;

        //public JobController(IJobService jobService, UserManager<User> userManager)
        //{
        //    _jobService = jobService;
        //    _userManager = userManager;
        //}

        //[HttpGet("all")]
        //public async Task<IActionResult> GetAllJobs()
        //{
        //    IEnumerable<Job> jobs = await GetJobsFromClaims();
        //    return Ok(jobs.Select(Transform).ToList());
        //}

        [HttpPost("RegisterUser")]
        public async Task<ActionResult> NewUser(UserDTO userDTO)
        {
            // Before doing the encryption, let's first check if the password actually follows our guidelines
            // guidelines = 8 long at least, 1 upper and lowercase letter, one number and one special character
            string pattern = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
            Regex regex = new Regex(pattern);

            byte[] encrypted = KeyDerivation.Pbkdf2(
                password: userDTO.Password,
                salt: Encoding.UTF8.GetBytes("add your own token here"),
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100,
                numBytesRequested: 64);

            string encryptedString = Encoding.UTF8.GetString(encrypted);

            User user = new()
            {
                Username = userDTO.Username,
                Password = encryptedString,
                ProfilePicture = userDTO.ProfilePicture,
            };

            Console.WriteLine($"username: {user.Username}  password: {user.Password} profile picture: {user.ProfilePicture}");
            return Ok();
        }
    }
}
