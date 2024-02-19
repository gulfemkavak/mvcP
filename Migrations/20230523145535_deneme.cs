using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mvcP.Migrations
{
    /// <inheritdoc />
    public partial class deneme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.CreateTable(
                name: "Birims",
                columns: table => new
                {
                    BirimID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Birims", x => x.BirimID);
                });

            migrationBuilder.CreateTable(
                name: "personels",
                columns: table => new
                {
                    perID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sehir = table.Column<string>(type: "nvarchar(max), oldClrType: typeof(int)", nullable: false),
                    BirimID = table.Column<int>(type: "int", nullable: false)
                },

                constraints: table =>
                {
                    table.PrimaryKey("PK_personels", x => x.perID);
                    table.ForeignKey(
                        name: "FK_personels_Birims_BirimID",
                        column: x => x.BirimID,
                        principalTable: "Birims",
                        principalColumn: "BirimID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personels_BirimID",
                table: "personels",
                column: "BirimID");
          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personels");

            migrationBuilder.DropTable(
                name: "Birims");
        }
    }
}
