using Microsoft.EntityFrameworkCore;
using ProjetoPIM.Data.Mappings;
using ProjetoPIM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPIM.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) =>
            Database.EnsureCreated();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnderecoMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new PessoaTelefoneMap());
            modelBuilder.ApplyConfiguration(new TelefoneMap());
            modelBuilder.ApplyConfiguration(new TipoTelefoneMap());

            //modelBuilder.Entity<Endereco>().HasKey(_ => _.Id);
            //modelBuilder.Entity<Pessoa>().HasKey(_ => _.Id);
            //modelBuilder.Entity<PessoaTelefone>().HasNoKey();
            //modelBuilder.Entity<Telefone>().HasKey(_ => _.Id);
            //modelBuilder.Entity<TipoTelefone>().HasKey(_ => _.Id);


            //modelBuilder.Entity<Endereco>().ToTable("ENDERECO");
            //modelBuilder.Entity<Pessoa>().ToTable("PESSOA");
            //modelBuilder.Entity<PessoaTelefone>().ToTable("PESSOA_TELEFONE");
            //modelBuilder.Entity<Telefone>().ToTable("TELEFONE");
            //modelBuilder.Entity<TipoTelefone>().ToTable("TIPO_TELEFONE");

        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pessoa>  Pessoas { get; set; }
        public DbSet<PessoaTelefone> PessoaTelefones { get; set; }
        public DbSet<Telefone>  Telefones { get; set; }
        public DbSet<TipoTelefone>  TipoTelefones { get; set; }
    }
}
