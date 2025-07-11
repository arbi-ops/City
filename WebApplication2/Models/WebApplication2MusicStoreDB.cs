using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WebApplication2MusicStoreDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebApplication2MusicStoreDB() : base("name=WebApplication2MusicStoreDB")
        {
        }

        public System.Data.Entity.DbSet<WebApplication2.Models.Album> Albums { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Artist> Artists { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Models.PurchaseOrder> Orders { get; set; }
    }
}
