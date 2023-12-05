using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Mvc;
using PassManager.api.Models;
using PassManager.Domain.Interfaces;
using PassManager.Domain.Models;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace PassManager.api.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        //private readonly IJobService _jobService;
        //private readonly UserManager<User> _userManager;
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

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
            Match match = regex.Match(userDTO.Password);
            if (!match.Success)
            {
                return BadRequest(new
                {
                    Message = "Passwords must be at least 8 characters long and contain 1 lowercase letter, 1 uppercase letter, 1 number and 1 special character."
                });
            }

            byte[] encrypted = KeyDerivation.Pbkdf2(
                password: userDTO.Password,
                salt: Encoding.UTF8.GetBytes("s5melyFWJG(7EX7d-0Xi"),
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

            bool createSucces = await _userService.Create(user);

            if (createSucces == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest(new
                {
                    Message = $"Account with username {user.Username} already exists."
                });
            }
        }

        [HttpPost("LoginUser")]
        public async Task<IActionResult> LoginUser(UserLoginDTO userLoginDTO)
        {

            byte[] encrypted = KeyDerivation.Pbkdf2(
            password: userLoginDTO.Password,
            salt: Encoding.UTF8.GetBytes("s5melyFWJG(7EX7d-0Xi"),
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100,
            numBytesRequested: 64);

            string encryptedString = Encoding.UTF8.GetString(encrypted);

            User user = new()
            {
                Username = userLoginDTO.Username,
                Password = encryptedString,
            };

            //find the user by username
            User foundUser = await _userService.GetUserByName(user.Username);

            if (foundUser == null)
            {
                return BadRequest(new
                {
                    Message = "Username or password do not match."
                });
            }

            if (foundUser.Password == user.Password)
            {
                return Ok(new { User = foundUser });
            }
            else
            {
                return BadRequest(new
                {
                    Message = $"Username or password do not match."
                });
            }
        }

        public record UploadImageDTO(string Data, string Username, string FileName);
        [HttpPost("UploadImage")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UploadImage(UploadImageDTO uploadImage/*, int mode, [FromForm] IFormFile file*/)
        {
            try
            {
                //var file = Request.Form.Files[0];
                var file = System.Convert.FromBase64String(uploadImage.Data);
                var memoryStream = new MemoryStream(file);
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                if (file.Length > 0)
                {
                    // 0 is users
                    //if (mode == 0)
                    //{
                    folderName = Path.Combine(folderName, "users", uploadImage.Username);
                    Directory.CreateDirectory(folderName);
                    //var fileName = System.Net.Http.Headers.ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fileExtension = new FileInfo(uploadImage.FileName).Extension;
                    string randomFileName = RandomString(20);
                    string fileName = randomFileName + fileExtension;
                    var fullPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        memoryStream.CopyTo(stream);
                    }

                    await _userService.Update(uploadImage.Username, fileName);

                    return Ok();
                    //}
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
            return Ok();
        }

        private static string RandomString(int length)
        {
            Random random = new();
            string pool = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            var chars = Enumerable.Range(0, length)
                .Select(x => pool[random.Next(0, pool.Length)]);
            return new string(chars.ToArray());
        }

        public record RequestProfilePictureDTO(string Username);
        [HttpGet("GetProfilePictureByUsername")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> GetProfilePictureByUsername([FromQuery] RequestProfilePictureDTO requestProfilePicture)
        {
            User user = await _userService.GetUserByName(requestProfilePicture.Username);
            string profilePictureName = user.ProfilePicture;
            Debug.WriteLine(profilePictureName);

            var fullpath = Path.Combine(Directory.GetCurrentDirectory(), "Resources", "Images", "users", requestProfilePicture.Username, profilePictureName);
            Byte[] bytes = System.IO.File.ReadAllBytes(fullpath);
            Debug.WriteLine(bytes);
            string file = Convert.ToBase64String(bytes);
            return Ok(new RequestProfilePictureDTO(file));


            //Directory.GetFiles(fullpath);

            //foreach (FileInfo foundFile in filesInDir)
            //{
            //    string fullName = foundFile.FullName;
            //    if (fullName == profilePictureName)
            //    {

            //    }
            //}

            //string username = (requestProfilePicture.Username);
            //return Ok(new RequestProfilePictureDTO(username));
        }
    }
}
