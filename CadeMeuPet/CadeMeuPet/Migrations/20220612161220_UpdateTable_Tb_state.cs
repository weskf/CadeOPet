using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class UpdateTable_Tb_state : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Tb_State",
                type: "NVARCHAR(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UF",
                table: "Tb_State");
        }
    }
}
