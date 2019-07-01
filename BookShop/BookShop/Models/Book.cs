using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShop.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        
        public int Seller { get; set; }
        
        public string BookName { get; set; }
        
        public float CurPrice { get; set; }

        public float OrgPrice { get; set; }

        public string Catogory { get; set; }
        
        public string ISBN { get; set; }

        public string Introduce { get; set; }
    }
}