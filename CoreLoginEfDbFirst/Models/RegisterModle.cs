using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestingEyes.Models
{
    public class RegisterModle
    {
        /// <summary>
        /// Gets or sets to username address.
        /// </summary>
        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets to password address.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [Display(Name = "Confrim Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
