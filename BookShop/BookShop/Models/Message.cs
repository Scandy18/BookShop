using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Sender { get; set; }

        [Required]
        public int Receiver { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Time { get; set; }

    }
}