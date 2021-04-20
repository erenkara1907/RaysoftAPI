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
    public class EconomistConfiguration : IEntityTypeConfiguration<Economist>
    {
        public void Configure(EntityTypeBuilder<Economist> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.FullName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.Age).IsRequired();
        }
    }
}
