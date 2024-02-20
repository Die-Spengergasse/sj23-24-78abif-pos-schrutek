using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Spg.CifBazar.DomainModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.CifBazar.Infrastructure
{
    public class CifBazarContext : DbContext
    {
        // 1. OR-Mapper installieren

        // 2. Mapping konfigurieren
        public DbSet<Shop> Shops => Set<Shop>();
        //public DbSet<Shop> Shops
        //{
        //    get 
        //    {
        //        return Set<Shop>();
        //    }
        //}

        public DbSet<Product> Products => Set<Product>();
        // Category ist kein Aggregate Root
        public DbSet<Customer> Customers => Set<Customer>();

        //...

        public CifBazarContext() 
            : base()
        { }

        public CifBazarContext(DbContextOptions options)
            : base(options)
        { }

        // 3. Datenbank konfigurieren (Wo ist die DB, Welche DB)
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //if (!optionsBuilder.IsConfigured)
            //{
            //    //optionsBuilder.UseSqlServer("Data Source=IP Datenbank UserName Password"); // Microsoft SQL-Server Vorsicht!!!!!!!
            //    optionsBuilder.UseSqlite("Data Source=CifBaza.db"); // unser kleines SQLite
            //}
        }

        // 4. Model konfiguriern
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Shop>().ToTable("Geschaefte");

            // speziellen Primary Keys
            modelBuilder.Entity<Product>().HasKey(p => p.Name); // Configuration

            // Value Objects
            modelBuilder.Entity<Shop>().OwnsOne(s => s.Address);
            modelBuilder.Entity<Shop>().OwnsOne(s => s.EMail);
            modelBuilder.Entity<Shop>().OwnsOne(s => s.PhoneNumber);

            modelBuilder.Entity<Customer>().OwnsOne(s => s.Address);
            modelBuilder.Entity<Customer>().OwnsOne(s => s.PhoneNumber);
            modelBuilder.Entity<Customer>().OwnsOne(s => s.EMail);

            //modelBuilder.Entity<Shop>()
            //    .Property(p => p.Name)
            //    .HasMaxLength(20)
            //    .HasColumnName("S_Name")
            //    .IsRequired();

            //modelBuilder.Entity<Shop>()
            //    .HasMany(s => s.Categories)
            //    .WithOne(c => c.ShopNavigation);
        }
    }
}
