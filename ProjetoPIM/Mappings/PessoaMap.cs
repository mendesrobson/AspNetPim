using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPIM.Models;

namespace ProjetoPIM.Mappings
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("PESSOA");

            builder.HasKey(_ => _.Id);

            //builder.Property(p => p.Id)
            //    .ValueGeneratedNever();

            //builder.Property(p => p.Nome)
            //  .HasColumnType("varchar(100)")
            //  .IsRequired();

            //builder.Property(p => p.Cpf)
            //    .HasColumnType("float")
            //     .IsRequired();

            //builder.Property(p => p.EnderecoId)
            //    .HasColumnType("int");

            //builder.HasOne(p => p.pessoaTelefones)
            //   .WithMany(p => p)
            //   .HasForeignKey(p => p.Id);

            builder.HasData(
                new Pessoa { Id = 1, Nome = "Eric Evans", Cpf = 1222, EnderecoId = 1  },
                new Pessoa { Id = 2, Nome = "Robert C. Martin", Cpf = 2344, EnderecoId = 2 },
                new Pessoa { Id = 3, Nome = "Vaughn Vernon", Cpf = 3777, EnderecoId = 3 },
                new Pessoa { Id = 4, Nome = "Martin Fowler", Cpf = 43432, EnderecoId = 3 }
            );
        }
    }
}
