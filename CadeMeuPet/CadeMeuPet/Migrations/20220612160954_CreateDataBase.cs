using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadeMeuPet.Migrations
{
    public partial class CreateDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tb_Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    FullName = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    CPF = table.Column<string>(type: "NVARCHAR(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Telefone = table.Column<string>(type: "NVARCHAR(15)", maxLength: 15, nullable: false),
                    User = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Breed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Breed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_State", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Status", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tb_City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_States",
                        column: x => x.StateId,
                        principalTable: "Tb_State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "NVARCHAR(120)", maxLength: 120, nullable: false),
                    Number = table.Column<string>(type: "NVARCHAR(10)", maxLength: 10, nullable: false),
                    Cep = table.Column<string>(type: "NVARCHAR(10)", maxLength: 10, nullable: false),
                    District = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: false),
                    Complement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_City",
                        column: x => x.CityId,
                        principalTable: "Tb_City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "NVARCHAR(80)", maxLength: 80, nullable: false),
                    BreedId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Pet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Breed",
                        column: x => x.BreedId,
                        principalTable: "Tb_Breed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Color",
                        column: x => x.ColorId,
                        principalTable: "Tb_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Size",
                        column: x => x.SizeId,
                        principalTable: "Tb_Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pet_Status",
                        column: x => x.StatusId,
                        principalTable: "Tb_Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tb_Pet_Tb_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Tb_Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tb_Image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "NVARCHAR(3000)", maxLength: 3000, nullable: false),
                    PetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tb_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pet_Images",
                        column: x => x.PetId,
                        principalTable: "Tb_Pet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Address_CityId",
                table: "Tb_Address",
                column: "CityId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_City_StateId",
                table: "Tb_City",
                column: "StateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Image_PetId",
                table: "Tb_Image",
                column: "PetId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pet_AddressId",
                table: "Tb_Pet",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pet_BreedId",
                table: "Tb_Pet",
                column: "BreedId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pet_ColorId",
                table: "Tb_Pet",
                column: "ColorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pet_SizeId",
                table: "Tb_Pet",
                column: "SizeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tb_Pet_StatusId",
                table: "Tb_Pet",
                column: "StatusId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tb_Account");

            migrationBuilder.DropTable(
                name: "Tb_Image");

            migrationBuilder.DropTable(
                name: "Tb_Pet");

            migrationBuilder.DropTable(
                name: "Tb_Breed");

            migrationBuilder.DropTable(
                name: "Tb_Color");

            migrationBuilder.DropTable(
                name: "Tb_Size");

            migrationBuilder.DropTable(
                name: "Tb_Status");

            migrationBuilder.DropTable(
                name: "Tb_Address");

            migrationBuilder.DropTable(
                name: "Tb_City");

            migrationBuilder.DropTable(
                name: "Tb_State");
        }
    }
}
