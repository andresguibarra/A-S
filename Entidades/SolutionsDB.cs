using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCPagina.Models
{
    //public class SolutionsDB : DbContext   
    public class SolutionsDB : IdentityDbContext<ApplicationUser>
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public SolutionsDB()
            : base("name=SolutionsDB")
        {
        }

        public static SolutionsDB Create()
        {
            return new SolutionsDB();
        }

        public System.Data.Entity.DbSet<MVCPagina.Models.Servicio> Servicios { get; set; }

        public System.Data.Entity.DbSet<MVCPagina.Models.Feature> Features { get; set; }



    }
}
