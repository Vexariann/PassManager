namespace PassManager.Domain.Models
{
    public class User : EntityBase
    {
        //public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePicture { get; set; } = string.Empty;
    }
}
