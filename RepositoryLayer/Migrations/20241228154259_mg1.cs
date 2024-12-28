using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 1, "Ali Can Yücel", 50m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Hakan Can Yücel", 250m });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 3, "Metin Yücel", 150m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
