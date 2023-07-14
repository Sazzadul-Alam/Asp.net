using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FormTask.Models
{
    public class SignUp
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string[] Profession{ get; set; }
        [Required]
        public DateTime Dob { get; set; }
        [Required]
        public string StudentId { get; set; }
        [Required]
        
        public string Email { get; set; }
    }
}