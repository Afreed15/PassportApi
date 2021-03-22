using Microsoft.EntityFrameworkCore.Migrations;

namespace PassportApi.Migrations
{
    public partial class passporttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passport",
                columns: table => new
                {
                    PPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PPHolderName = table.Column<string>(type: "varchar(100)", nullable: false),
                    PPNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    PPExpiry = table.Column<string>(type: "varchar(5)", nullable: false),
                    PPOcode = table.Column<string>(type: "varchar(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passport", x => x.PPId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passport");
        }
    }
}
