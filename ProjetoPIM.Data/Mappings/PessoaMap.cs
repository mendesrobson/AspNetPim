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
                new Telefone { Id = 1, Ddd = 1, Numero = 1, Tipo = 1 },
                new Telefone { Id = 2, Ddd = 2, Numero = 2, Tipo = 2 },
                new Telefone { Id = 3, Ddd = 3, Numero = 3, Tipo = 3 },
                new Telefone { Id = 4, Ddd = 4, Numero = 4, Tipo = 3 }
            );
        }
    }
}
