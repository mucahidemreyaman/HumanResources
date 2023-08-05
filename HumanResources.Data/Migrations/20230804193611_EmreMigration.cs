using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HumanResources.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmreMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountInfos",
                columns: table => new
                {
                    USER_NAME = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(16)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountInfos", x => x.USER_NAME);
                });

            migrationBuilder.CreateTable(
                name: "BasePersonels",
                columns: table => new
                {
                    ID_PERSONEL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDENTITY_ID = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    LOGIN_DATE = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GENDER = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    BIRTHDAY = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    PERMISSION_DAYS = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    SALARY = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasePersonels", x => x.ID_PERSONEL);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountInfos");

            migrationBuilder.DropTable(
                name: "BasePersonels");
        }
    }
}
