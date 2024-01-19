using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_EVO.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentoId",
                table: "Funcionarios");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Funcionarios",
                newName: "Nome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Funcionarios",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentoId",
                table: "Funcionarios",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
