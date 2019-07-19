using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Burberry.Models
{
    public class ClientViewModels
    {

        
        public class RegisterViewModel
        {
            [Key]
            public int ClientId { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
            [Display(Name = "Username")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "You must provide a phone number")]
            [Display(Name = "Phone")]
            [DataType(DataType.PhoneNumber)]
            [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
            public string PhoneNumber { get; set; }


            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name = "City")]
            public string City { get; set; }

            [Required]
            [StringLength(100)]
            [Display(Name = "Surname")]
            public string SurName { get; set; }

            [StringLength(100)]
            [Display(Name = "Other Name")]
            public string OtherName { get; set; }

            [Required]
            [Display(Name = "Account no")]
            public int AccountNo { get; set; }

            [Display(Name = "Status Id")]
            public int StatusId { get; set; }


        }
    }
}