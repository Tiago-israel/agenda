using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.Mappings
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(p => p.Numero).HasColumnName("numero");
            builder.HasOne(p => p.Contato).WithMany(p => p.Telefones).HasForeignKey(p => p.IdContato).HasConstraintName("idContato");
            builder.ToTable("telefone");
        }
    }
}
