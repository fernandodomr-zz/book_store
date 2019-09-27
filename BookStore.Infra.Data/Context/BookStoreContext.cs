using BookStore.Domain.Entities;
using BookStore.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;

namespace BookStore.Infra.Data.Context
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext() : base("BookStoreDefaultConnection")
        {
            var ensureDLLIsCopied = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connectionString);
        //}

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().ToTable("Book");

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new BookConfiguration());

            //modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
        }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("Data") != null))
        //    {
        //        // Add value for create
        //        if (entry.State == EntityState.Added)
        //        {
        //            entry.Property("Data").CurrentValue = DateTime.Now;
        //        }

        //        // Ignore on update
        //        if (entry.State == EntityState.Modified)
        //        {
        //            entry.Property("Data").IsModified = false;
        //        }
        //    }

        //    return base.SaveChanges();
        //}
    }
}
