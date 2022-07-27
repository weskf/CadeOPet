using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class IncluindoUsuarioTb_Pet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Tb_Pet",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pet_AccountId",
                table: "Tb_Pet",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Account",
                table: "Tb_Pet",
                column: "AccountId",
                principalTable: "Tb_Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Account",
                table: "Tb_Pet");

            migrationBuilder.DropIndex(
                name: "IX_Tb_Pet_AccountId",
                table: "Tb_Pet");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Tb_Pet");
        }
    }
}
