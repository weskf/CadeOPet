using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class alterTable_tb_City : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_States",
                table: "Tb_City");

            migrationBuilder.DropIndex(
                name: "IX_Tb_City_StateId",
                table: "Tb_City");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Tb_State",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Tb_State_CityId",
            //    table: "Tb_State",
            //    column: "CityId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_City_States",
            //    table: "Tb_State",
            //    column: "CityId",
            //    principalTable: "Tb_City",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_States",
                table: "Tb_State");

            migrationBuilder.DropIndex(
                name: "IX_Tb_State_CityId",
                table: "Tb_State");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Tb_State");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_City_StateId",
                table: "Tb_City",
                column: "StateId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_City_States",
                table: "Tb_City",
                column: "StateId",
                principalTable: "Tb_State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
