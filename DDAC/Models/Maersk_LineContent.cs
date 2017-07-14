using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DDAC.Models
{
    public class Maersk_LineContent : DbContext
    {
      
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Maersk_LineContent() : base("name=Maersk_LineContext")
        {
        }

        public System.Data.Entity.DbSet<DDAC.Models.Booking> Bookings { get; set; }

        public System.Data.Entity.DbSet<DDAC.Models.Container> Containers { get; set; }

        //public System.Data.Entity.DbSet<DDAC.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<DDAC.Models.Charter> Charter { get; set; }

        public System.Data.Entity.DbSet<DDAC.Models.Shipyard> Shipyard { get; set; }

        public System.Data.Entity.DbSet<DDAC.Models.Warehouse> Warehouses { get; set; }
   
}
}