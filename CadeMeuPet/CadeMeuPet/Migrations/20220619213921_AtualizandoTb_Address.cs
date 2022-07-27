using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class AtualizandoTb_Address : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_City",
                table: "Tb_Address");

            migrationBuilder.DropIndex(
                name: "IX_Tb_Address_CityId",
                table: "Tb_Address");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Cities",
                table: "Tb_City",
                column: "AddressId",
                principalTable: "Tb_Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_City",
                table: "Tb_City");

            migrationBuilder.DropIndex(
                name: "IX_Tb_City_AddressId",
                table: "Tb_City");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Tb_City");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Address_CityId",
                table: "Tb_Address",
                column: "CityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_City",
                table: "Tb_Address",
                column: "CityId",
                principalTable: "Tb_City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
