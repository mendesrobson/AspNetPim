using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoPIM.Models;

namespace ProjetoPIM.Mappings
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("TELEFONE");

            builder.HasKey(_ => _.Id);

            //builder.Property(p => p.Id)
            //    .ValueGeneratedNever();

            //builder.Property(p => p.Numero)
            //  .HasColumnType("int")
            //  .IsRequired();

            //builder.Property(p => p.Ddd)
            //    .HasColumnType("int")
            //     .IsRequired();

            //builder.Property(p => p.Ddd)
            //    .HasColumnType("int")
            //    .IsRequired();

            //builder.Property(p => p.Tipo)
            //    .HasColumnType("int")
            //    .IsRequired();

            //builder.HasOne(p => p.TipoTelefone)
            //   .WithMany(p => p.Telefones)
            //   .HasForeignKey(p => p.Id);

            builder.HasData(
                new Telefone { Id = 1, Ddd = 1, Numero = 1, Tipo = 1 },
                new Telefone { Id = 2, Ddd = 2 , Numero = 2, Tipo = 2 },
                new Telefone { Id = 3, Ddd = 3 , Numero = 3, Tipo = 3 },
                new Telefone { Id = 4, Ddd = 4 , Numero = 4, Tipo = 3 }
            );
        }
    }
}
