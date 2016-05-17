using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DataLayer.Models
{
    public class SalesContext : DbContext
    {
      public DbSet<DomainClasses.Customer> Customers { get; set; }
      public DbSet<DomainClasses.Address> Addresses { get; set; }
      
    }
}