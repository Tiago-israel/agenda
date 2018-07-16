using Infra.Mappings;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infra.DataContext
{
    public class AgendaContext :DbContext
    {
        public virtual DbSet<Contato> Contatos { get; set; }
        public virtual DbSet<Telefone> Telefones { get; set; }
        public virtual DbSet<ErrorLog> ErroLog { get; set; }

        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            modelBuilder.ApplyConfiguration(new ErrorLogMap());
        }
    }
}
