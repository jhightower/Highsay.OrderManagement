using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Highsay.OrderManagement.Dal
{
    public class OrderMgmtContext : DbContext
    {

        public OrderMgmtContext() : base("OrderMgmtContext")
        {
        }

        public DbSet<Order> Order { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}