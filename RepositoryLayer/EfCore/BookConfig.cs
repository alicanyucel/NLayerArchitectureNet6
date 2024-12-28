using Entity.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.EfCore
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(new Book { Id = 1, Name = "Ali Can Yücel", Price = 50 },
             new Book { Id = 2, Name = "Hakan Can Yücel", Price = 250 },
             new Book { Id = 3, Name = "Metin Yücel", Price = 150 }
             );
        }

    }
}
