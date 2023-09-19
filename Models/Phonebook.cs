using System;
using System.ComponentModel.DataAnnotations;


namespace JellyPagesMasterDetailApp.Models {
    public class Phonebook {

        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter your first name.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter your last name.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "You must enter a 7-digit phone number")]
        public string Phone {  get; set; }
        [Required(ErrorMessage = "Please enter a valid email address.")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

    }
}
