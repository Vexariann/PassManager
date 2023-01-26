namespace PassManager.Domain.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; }
        public Options Options { get; set; }
        public int OptionsID { get; set; }
    }
}
