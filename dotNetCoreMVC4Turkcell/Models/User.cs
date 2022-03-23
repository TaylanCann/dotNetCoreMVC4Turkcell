using System;
using System.ComponentModel.DataAnnotations;

namespace dotNetCoreMVC4Turkcell.Models
{
    public class User
    {
        //public int Id { get; set;
        
        [Required(ErrorMessage ="User Name must not be blank")]
        [MinLength(2,ErrorMessage ="Must be min 2 char")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "E-Mail must not be blank")]
        [MinLength(2, ErrorMessage = "Must fit to E-Mail form")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Birthday must not be blank")]
        public DateTime? Birthdate { get; set; }
    }
}
