using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class IncluindoTamanhos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Tb_Size VALUES
('Pequeno'),
('Médio'),
('Grande')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
