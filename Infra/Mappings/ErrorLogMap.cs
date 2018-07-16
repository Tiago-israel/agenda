using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class ErrorLogMap : IEntityTypeConfiguration<ErrorLog>
    {
        public void Configure(EntityTypeBuilder<ErrorLog> builder)
        {
            builder.Property(p => p.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(p => p.Erro);
            builder.Property(p => p.DataCadastro);
            builder.ToTable("error_log");
        }
    }
}
