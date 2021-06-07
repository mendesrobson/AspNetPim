using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPIM.Models;

namespace ProjetoPIM.Mappings
{
    public class PessoaTelefoneMap : IEntityTypeConfiguration<PessoaTelefone>
    {
        public void Configure(EntityTypeBuilder<PessoaTelefone> builder)
        {
            builder.ToTable("PESSOA_TELEFONE");

            builder.HasNoKey();

            //builder.Property(p => p.IdPessoa)
            //  .HasColumnType("int")
            //  .IsRequired();

            //builder.Property(p => p.IdTelefone)
            //    .HasColumnType("int")
            //     .IsRequired();

            //builder.HasOne(p => p.Pessoa)
            //   .WithMany(p => p.pessoaTelefones)
            //   .HasForeignKey(p => p.IdPessoa);

            //builder.HasOne(p => p.Telefone)
            //  .WithMany(p => p.pessoaTelefones)
            //  .HasForeignKey(p => p.IdTelefone);

            builder.HasData(
                new PessoaTelefone { IdPessoa = 1, IdTelefone = 1 },
                new PessoaTelefone { IdPessoa = 2, IdTelefone = 2 },
                new PessoaTelefone { IdPessoa = 3, IdTelefone = 3 },
                new PessoaTelefone { IdPessoa = 4, IdTelefone = 4 }
            );
        }
    }
}
