using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace client.Data
{
    public class User
    {
        [Key]
        [Required]
        [StringLength(100)]
        [DisplayName("Email Address")]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        [DisplayName("Password")]
        public string Password { get; set; }
    }
}
