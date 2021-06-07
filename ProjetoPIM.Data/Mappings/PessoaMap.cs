using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPIM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoPIM.Data.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOA");

            builder.HasKey(_ => _.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever();

            builder.Property(p => p.Nome)
              .HasColumnType("varchar(100)")
              .IsRequired();

            builder.Property(p => p.Cpf)
                .HasColumnType("int")
                 .IsRequired();

            builder.Property(p => p.Endereco)
                .HasColumnType("int")
                .IsRequired();

            //builder.HasOne(p => p.pessoaTelefones)
            //   .WithMany(p => p)
            //   .HasForeignKey(p => p.Id);

            builder.HasData(
                new Pessoa { Id = 1, Nome = "Eric Evans", Cpf = 1222, Endereco = 1  },
                new Pessoa { Id = 2, Nome = "Robert C. Martin", Cpf = 2344, Endereco = 2 },
                new Pessoa { Id = 3, Nome = "Vaughn Vernon", Cpf = 3777, Endereco = 3 },
                new Pessoa { Id = 4, Nome = "Martin Fowler", Cpf = 43432, Endereco = 3 }
            );
        }
    }
}
