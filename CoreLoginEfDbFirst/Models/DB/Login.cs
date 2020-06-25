using System;
using System.Collections.Generic;

namespace CoreLoginEfDbFirst.Models.DB
{
    public partial class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
