using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Raysoft.Core.Models;

namespace Raysoft.Data.Configuration
{
    public class CryptoNewConfiguration : IEntityTypeConfiguration<CryptoNew>
    {
        public void Configure(EntityTypeBuilder<CryptoNew> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Image).IsRequired();
        }
    }
}
