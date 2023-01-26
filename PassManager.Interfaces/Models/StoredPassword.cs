﻿namespace PassManager.Domain.Models
{
    public class StoredPassword
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string Website { get; set; }
        public string Thumbnail { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
    }
}
