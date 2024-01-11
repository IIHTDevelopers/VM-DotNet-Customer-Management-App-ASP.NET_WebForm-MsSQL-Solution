using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CustomerManagementApp.Model;

namespace CustomerManagementApp.DAL
{
    public class CustomerDbContext : DbContext
    {
        public DbSet<Model.CustomerModel> CustomerModels { get; set; }

        public CustomerDbContext() : base("ConnStr")
        {
        }
    }
}