using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.Center.Platform.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueTutorialTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "i_x_tutorials_title",
                table: "tutorials",
                column: "title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "i_x_tutorials_title",
                table: "tutorials");
        }
    }
}
