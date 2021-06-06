using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPIM.Migrations
{
    public partial class InitialDBCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ENDERECO",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LOGRADOURO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NUMERO = table.Column<int>(type: "int", nullable: false),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    BAIRRO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CIDADE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ESTADO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ENDERECO", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_TELEFONE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TIPO = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TIPO_TELEFONE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<double>(type: "float", nullable: false),
                    ENDERECO = table.Column<int>(type: "int", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PESSOA_ENDERECO_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "ENDERECO",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TELEFONE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NUMERO = table.Column<int>(type: "int", nullable: false),
                    DDD = table.Column<int>(type: "int", nullable: false),
                    TIPO = table.Column<int>(type: "int", nullable: false),
                    TipoTelefoneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TELEFONE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TELEFONE_TIPO_TELEFONE_TipoTelefoneId",
                        column: x => x.TipoTelefoneId,
                        principalTable: "TIPO_TELEFONE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PESSOA_TELEFONE",
                columns: table => new
                {
                    ID_PESSOA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TELEFONE = table.Column<int>(type: "int", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: true),
                    TelefoneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PESSOA_TELEFONE", x => x.ID_PESSOA);
                    table.ForeignKey(
                        name: "FK_PESSOA_TELEFONE_PESSOA_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "PESSOA",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PESSOA_TELEFONE_TELEFONE_TelefoneId",
                        column: x => x.TelefoneId,
                        principalTable: "TELEFONE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_EnderecoId",
                table: "PESSOA",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_TELEFONE_PessoaId",
                table: "PESSOA_TELEFONE",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_TELEFONE_TelefoneId",
                table: "PESSOA_TELEFONE",
                column: "TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_TELEFONE_TipoTelefoneId",
                table: "TELEFONE",
                column: "TipoTelefoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PESSOA_TELEFONE");

            migrationBuilder.DropTable(
                name: "PESSOA");

            migrationBuilder.DropTable(
                name: "TELEFONE");

            migrationBuilder.DropTable(
                name: "ENDERECO");

            migrationBuilder.DropTable(
                name: "TIPO_TELEFONE");
        }
    }
}
