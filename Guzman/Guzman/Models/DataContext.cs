using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Guzman.Models
{
    public class DataContext : DbContext 
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Guzman.Models.Clown> Clowns { get; set; }
    }
}