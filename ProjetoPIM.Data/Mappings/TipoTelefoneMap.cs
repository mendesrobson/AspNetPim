using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPIM.Domain.Models;

namespace ProjetoPIM.Data.Mappings
{
    public class TipoTelefoneMap : IEntityTypeConfiguration<TipoTelefone>
    {
        public void Configure(EntityTypeBuilder<TipoTelefone> builder)
        {
            builder.ToTable("TIPO_TELEFONE");

            builder.HasKey(_ => _.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedNever();

            builder.Property(p => p.Tipo)
                .HasColumnType("varchar(100)")
                .IsRequired();

            //builder.HasOne(p => p.Telefones)
            //   .WithMany(p => p.)
            //   .HasForeignKey(p => p.Id);

            builder.HasData(
                new TipoTelefone { Id = 1, Tipo = "Celular" },
                new TipoTelefone { Id = 2, Tipo = "Telefone Fixo" },
                new TipoTelefone { Id = 3, Tipo = "Telefone Fax" },
                new TipoTelefone { Id = 4, Tipo = "Telefone Residencial" }
            );
        }
    }
}
