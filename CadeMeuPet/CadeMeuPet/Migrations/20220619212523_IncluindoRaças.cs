using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class IncluindoRaças : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO Tb_Breed VALUES
                                               ('Sem raça Denifida'),
                                               ('Splitz Alemão'),
                                               ('Bulldog Francês'),
                                               ('Shih Tzu'),
                                               ('Rottweiler'),
                                               ('Maltês'),
                                               ('Poodle'),
                                               ('Golden'),
                                               ('Yorkshire'),
                                               ('Pug'),
                                               ('Border Collie')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
