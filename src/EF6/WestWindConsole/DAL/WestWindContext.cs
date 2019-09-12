using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestWindConsole.Entities;

namespace WestWindConsole.DAL
{
    //My DbContext class is a "virtual" representation of the database
    //WestWindContext inherits from the DbContext class
    public class WestWindContext : DbContext
    {
        //My peramaterless construtor will first call the contsructor of the base class that takes a string value
        //DbContext(string connectionStringOrName);
        public WestWindContext() : base("name=WWdb")
        {
            // TODO: Demonstrate null database initializer
            // We are telling EF to not generate the db or tables on the next line
            Database.SetInitializer<WestWindContext>(null);
            // We can prevent DB initialization in code, (like we are doing here), or we can prevent it through certain settings in the .config file
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeTerritory> EmployeeTerritories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
         //mine below

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ManifestItem> ManifestItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Territory> Territories { get; set; }

    // TODO: Practice - Add entities and DbSet<> properties for the remaining tables
}
}
