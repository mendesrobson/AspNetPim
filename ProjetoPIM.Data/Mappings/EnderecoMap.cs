using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPIM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPIM.Data.Mappings
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("ENDERECO");

            builder.HasKey(_ => _.Id);

            builder.Property(p => p.Id)
              .HasColumnType("int")
              .IsRequired();

            builder.Property(p => p.Logradouro)
              .HasColumnType("varchar(100)");


            builder.Property(p => p.Numero)
            .HasColumnType("int");


            builder.Property(p => p.Cep)
            .HasColumnType("int");


            builder.Property(p => p.Bairro)
                  .HasColumnType("varchar(100)");

            builder.Property(p => p.Cidade)
                  .HasColumnType("varchar(100)");


            builder.Property(p => p.Estado)
                  .HasColumnType("varchar(100)");

            builder.HasData(
               new Endereco { Id = 1, Logradouro = "teste1", Numero = 1, Cep = 13333, Cidade = "teste1", Estado = "SP" },
               new Endereco { Id = 2, Logradouro = "teste2", Numero = 2, Cep = 2444, Cidade = "teste2", Estado = "RJ" },
               new Endereco { Id = 3, Logradouro = "teste3", Numero = 3, Cep = 3234324, Cidade = "teste3", Estado = "MG" },
               new Endereco { Id = 4, Logradouro = "teste4", Numero = 4, Cep = 4443243, Cidade = "teste4", Estado = "BA" }
           );
        }
    }
}