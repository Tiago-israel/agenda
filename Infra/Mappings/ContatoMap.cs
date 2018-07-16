using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class ContatoMap : IEntityTypeConfiguration<Contato>
    {
        public void Configure(EntityTypeBuilder<Contato> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(p => p.Nome).HasColumnName("nome");
            builder.Property(p => p.Email).HasColumnName("email");
            builder.HasMany(p => p.Telefones).WithOne(p => p.Contato).HasForeignKey(p => p.IdContato);
            builder.ToTable("contato");
        }
    }
}
