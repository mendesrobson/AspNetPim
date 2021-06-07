using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPIM.Migrations
{
    public partial class teste4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TIPO_TELEFONE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "TELEFONE",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "PESSOA",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ENDERECO",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PESSOA_TELEFONE",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PESSOA_TELEFONE",
                table: "PESSOA_TELEFONE",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PESSOA_TELEFONE",
                table: "PESSOA_TELEFONE");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PESSOA_TELEFONE");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TIPO_TELEFONE",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TELEFONE",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PESSOA",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ENDERECO",
                newName: "ID");
        }
    }
}
