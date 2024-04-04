using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FIAP_MVC.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MVC_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UserEmail = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UserPassword = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UserPhone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MVC_Users", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MVC_Users");
        }
    }
}
