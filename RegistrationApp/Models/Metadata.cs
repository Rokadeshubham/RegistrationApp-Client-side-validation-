using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistrationApp.Models
{
    public class UserMetadata
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Please enter proper username", MinimumLength = 2)]
        public string UserName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Please enter proper FullName", MinimumLength = 10)]

        public string FullName { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter proper email address")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Enter correct phone no", MinimumLength = 10)]
        public string ContactNo { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Enter correct address", MinimumLength = 10)]
        public string Address { get; set; }
        [Required]

        public string Gender { get; set; }
        [Required]
        public DateTime DataOfBirth { get; set; }

    }
}