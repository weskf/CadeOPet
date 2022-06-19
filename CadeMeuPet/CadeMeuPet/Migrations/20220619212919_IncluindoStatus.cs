using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class IncluindoStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Tb_Status VALUES
('Encontrei'),
('Perdi')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
