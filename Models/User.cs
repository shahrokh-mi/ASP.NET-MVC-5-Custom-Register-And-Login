namespace ProjectName.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
