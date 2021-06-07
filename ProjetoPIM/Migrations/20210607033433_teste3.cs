using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPIM.Migrations
{
    public partial class teste3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PESSOA_ENDERECO_EnderecoId",
                table: "PESSOA");

            migrationBuilder.DropForeignKey(
                name: "FK_PESSOA_TELEFONE_PESSOA_PessoaId",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_PESSOA_TELEFONE_TELEFONE_TelefoneId",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropForeignKey(
                name: "FK_TELEFONE_TIPO_TELEFONE_TipoTelefoneId",
                table: "TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_TELEFONE_TipoTelefoneId",
                table: "TELEFONE");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PESSOA_TELEFONE",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_PESSOA_TELEFONE_PessoaId",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_PESSOA_TELEFONE_TelefoneId",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropIndex(
                name: "IX_PESSOA_EnderecoId",
                table: "PESSOA");

            migrationBuilder.DropColumn(
                name: "TipoTelefoneId",
                table: "TELEFONE");

            migrationBuilder.DropColumn(
                name: "PessoaId",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropColumn(
                name: "TelefoneId",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropColumn(
                name: "ENDERECO",
                table: "PESSOA");

            migrationBuilder.AlterColumn<int>(
                name: "ID_PESSOA",
                table: "PESSOA_TELEFONE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<float>(
                name: "CPF",
                table: "PESSOA",
                type: "real",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoTelefoneId",
                table: "TELEFONE",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ID_PESSOA",
                table: "PESSOA_TELEFONE",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PessoaId",
                table: "PESSOA_TELEFONE",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TelefoneId",
                table: "PESSOA_TELEFONE",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CPF",
                table: "PESSOA",
                type: "float",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "ENDERECO",
                table: "PESSOA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PESSOA_TELEFONE",
                table: "PESSOA_TELEFONE",
                column: "ID_PESSOA");

            migrationBuilder.CreateIndex(
                name: "IX_TELEFONE_TipoTelefoneId",
                table: "TELEFONE",
                column: "TipoTelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_TELEFONE_PessoaId",
                table: "PESSOA_TELEFONE",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_TELEFONE_TelefoneId",
                table: "PESSOA_TELEFONE",
                column: "TelefoneId");

            migrationBuilder.CreateIndex(
                name: "IX_PESSOA_EnderecoId",
                table: "PESSOA",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_PESSOA_ENDERECO_EnderecoId",
                table: "PESSOA",
                column: "EnderecoId",
                principalTable: "ENDERECO",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PESSOA_TELEFONE_PESSOA_PessoaId",
                table: "PESSOA_TELEFONE",
                column: "PessoaId",
                principalTable: "PESSOA",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PESSOA_TELEFONE_TELEFONE_TelefoneId",
                table: "PESSOA_TELEFONE",
                column: "TelefoneId",
                principalTable: "TELEFONE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TELEFONE_TIPO_TELEFONE_TipoTelefoneId",
                table: "TELEFONE",
                column: "TipoTelefoneId",
                principalTable: "TIPO_TELEFONE",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
