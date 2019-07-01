using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Email")]
        //[Required(ErrorMessage = "Please enter the Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter the correct format")]
        public string Email { get; set; }

        [DisplayName("NickName")]
        //[Required(ErrorMessage = "Please enter the NickName")]
        [MaxLength(20, ErrorMessage = "MaxLength 20 words")]
        [MinLength(6, ErrorMessage = "MinLength 6 words")]
        public string NickName { get; set; }

        [DisplayName("Password")]
        //[Required(ErrorMessage = "Please enter the Password")]
        [MaxLength(10, ErrorMessage = "MaxLength 10 words")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public string QQ { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter the correct format")]
        public string Phone { get; set; }

        public string Address { get; set; }

        


    }
}