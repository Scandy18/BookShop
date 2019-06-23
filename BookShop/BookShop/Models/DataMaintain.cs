using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookShop.Models
{
    public class DataMaintain : DbContext
    {
        public DataMaintain() : base ("name=DefaultConnection")
        {
            //Database.SetInitializer<DataMaintain>(null);
        }

        public DbSet<User> User { get; set; }
    }
}