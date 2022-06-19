using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class IncluindoCores : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Tb_Color VALUES
('Branco'),
('Cinza'),
('Amarelo'),
('Caramelo'),
('Preto'),
('Vermelho'),
('Marrom')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
