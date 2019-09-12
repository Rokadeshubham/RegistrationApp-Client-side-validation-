using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RegistrationApp.Models;
using RegistrationApp.ValidationAttributes;

namespace RegistrationApp.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required] 
        [StringLength(100,ErrorMessage ="Please enter proper username",MinimumLength = 2)]   
        public string UserName { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Please enter proper FullName", MinimumLength = 6)]

        public string FullName { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Enter proper email address")]
        public string EmailId { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="Enter correct phone no",MinimumLength = 10)]
        public string ContactNo { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Enter correct address & address at least 10 character in length", MinimumLength = 10)]


        public string Address { get; set; }
        [Required]
        
        public string Gender { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        [ValidBirthDate(ErrorMessage = "Birth Date can not be greater than current date")]
        public DateTime DataOfBirth { get; set; }


    }
}