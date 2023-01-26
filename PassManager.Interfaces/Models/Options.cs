namespace PassManager.Domain.Models
{
    public class Options
    {
        public int ID { get; set; }
        public bool RememberMe { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
