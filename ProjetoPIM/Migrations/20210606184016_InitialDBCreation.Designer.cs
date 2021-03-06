// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoPIM.Context;

namespace ProjetoPIM.Migrations
{
    [DbContext(typeof(SqlContext))]
    [Migration("20210606184016_InitialDBCreation")]
    partial class InitialDBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoPIM.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("BAIRRO");

                    b.Property<int>("Cep")
                        .HasColumnType("int")
                        .HasColumnName("CEP");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("CIDADE");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ESTADO");

                    b.Property<string>("Logradouro")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOGRADOURO");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO");

                    b.HasKey("Id");

                    b.ToTable("ENDERECO");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cpf")
                        .HasColumnType("float")
                        .HasColumnName("CPF");

                    b.Property<int>("Endereco")
                        .HasColumnType("int")
                        .HasColumnName("ENDERECO");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOME");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("PESSOA");
                });

            modelBuilder.Entity("ProjetoPIM.Models.PessoaTelefone", b =>
                {
                    b.Property<int>("IdPessoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_PESSOA")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdTelefone")
                        .HasColumnType("int")
                        .HasColumnName("ID_TELEFONE");

                    b.Property<int?>("PessoaId")
                        .HasColumnType("int");

                    b.Property<int?>("TelefoneId")
                        .HasColumnType("int");

                    b.HasKey("IdPessoa");

                    b.HasIndex("PessoaId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("PESSOA_TELEFONE");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Telefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ddd")
                        .HasColumnType("int")
                        .HasColumnName("DDD");

                    b.Property<int>("Numero")
                        .HasColumnType("int")
                        .HasColumnName("NUMERO");

                    b.Property<int>("Tipo")
                        .HasColumnType("int")
                        .HasColumnName("TIPO");

                    b.Property<int?>("TipoTelefoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TipoTelefoneId");

                    b.ToTable("TELEFONE");
                });

            modelBuilder.Entity("ProjetoPIM.Models.TipoTelefone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("TIPO");

                    b.HasKey("Id");

                    b.ToTable("TIPO_TELEFONE");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Pessoa", b =>
                {
                    b.HasOne("ProjetoPIM.Models.Endereco", null)
                        .WithMany("Pessoas")
                        .HasForeignKey("EnderecoId");
                });

            modelBuilder.Entity("ProjetoPIM.Models.PessoaTelefone", b =>
                {
                    b.HasOne("ProjetoPIM.Models.Pessoa", null)
                        .WithMany("pessoaTelefones")
                        .HasForeignKey("PessoaId");

                    b.HasOne("ProjetoPIM.Models.Telefone", null)
                        .WithMany("pessoaTelefones")
                        .HasForeignKey("TelefoneId");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Telefone", b =>
                {
                    b.HasOne("ProjetoPIM.Models.TipoTelefone", null)
                        .WithMany("Telefones")
                        .HasForeignKey("TipoTelefoneId");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Endereco", b =>
                {
                    b.Navigation("Pessoas");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Pessoa", b =>
                {
                    b.Navigation("pessoaTelefones");
                });

            modelBuilder.Entity("ProjetoPIM.Models.Telefone", b =>
                {
                    b.Navigation("pessoaTelefones");
                });

            modelBuilder.Entity("ProjetoPIM.Models.TipoTelefone", b =>
                {
                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
