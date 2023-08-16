using H3WebshopBackend.Repository.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3WebshopBackend.Repository;

public class DatabaseContext : DbContext
{
    // this can be used in several ways
    // 1) connection directly from here
    // 2) connection in configuration file
    public DatabaseContext(DbContextOptions<DatabaseContext> option)
        : base(option)
    {
        // I think we can make the con_string here if wanted...
    }

    // tables in DB
    public DbSet<Supplier> Supplier { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order> Order { get; set; }
}