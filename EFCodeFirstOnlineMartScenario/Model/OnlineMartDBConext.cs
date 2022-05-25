using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstOnlineMartScenario.Model
{
    internal class OnlineMartDBConext:DbContext
    {

        public OnlineMartDBConext() : base("name=OnlineMartConnnectionString")
        {

        }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
    }
}
