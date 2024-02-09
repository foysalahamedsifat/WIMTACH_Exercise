using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCollegeV1.Migrations
{
    /// <inheritdoc />
    public partial class AddCollegeIdForeignKeyInStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollegeId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollegeId",
                table: "Students");
        }
    }
}
