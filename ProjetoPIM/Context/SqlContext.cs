using Microsoft.EntityFrameworkCore;
using ProjetoPIM.Mappings;
using ProjetoPIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPIM.Context
{
    /// como foi implementado referencia MIcrosoft
    /// https://docs.microsoft.com/pt-br/ef/core/dbcontext-configuration/
    /// 
    public sealed class SqlContext: DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) 
            : base(options)
        {
        }

        public DbSet<Endereco>  Enderecos { get; set; }
        public DbSet<Pessoa>  Pessoas { get; set; }
        public DbSet<PessoaTelefone>  PessoaTelefones { get; set; }
        public DbSet<Telefone>  Telefones { get; set; }
        public DbSet<TipoTelefone>  TipoTelefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Endereco>().HasKey(_ => _.Id);
            modelBuilder.Entity<Pessoa>().HasKey(_ => _.Id);
            modelBuilder.Entity<PessoaTelefone>().HasKey(_ => _.Id);
            modelBuilder.Entity<Telefone>().HasKey(_ => _.Id);
            modelBuilder.Entity<TipoTelefone>().HasKey(_ => _.Id);


            modelBuilder.Entity<Endereco>().ToTable("ENDERECO");
            modelBuilder.Entity<Pessoa>().ToTable("PESSOA");
            modelBuilder.Entity<PessoaTelefone>().ToTable("PESSOA_TELEFONE");
            modelBuilder.Entity<Telefone>().ToTable("TELEFONE");
            modelBuilder.Entity<TipoTelefone>().ToTable("TIPO_TELEFONE");
        }
    }
}
