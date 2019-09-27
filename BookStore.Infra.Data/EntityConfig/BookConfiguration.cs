using BookStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Infra.Data.EntityConfig
{
    public class BookConfiguration : EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
        {
            HasKey(b => b.Id);

            Property(b => b.Title).IsRequired();

            Property(b => b.Author).IsRequired();

            Property(b => b.ISBN).HasMaxLength(50);
        }
    }
}
