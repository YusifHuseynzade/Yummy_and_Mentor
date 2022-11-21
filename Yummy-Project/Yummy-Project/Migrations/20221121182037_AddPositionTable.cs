using Microsoft.EntityFrameworkCore.Migrations;

namespace Yummy_Project.Migrations
{
    public partial class AddPositionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals");

            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Categories_CategoryId",
                table: "Testimonials");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_CategoryId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Testimonials");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Testimonials",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Meals",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_PositionId",
                table: "Testimonials",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Positions_PositionId",
                table: "Testimonials",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals");

            migrationBuilder.DropForeignKey(
                name: "FK_Testimonials_Positions_PositionId",
                table: "Testimonials");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropIndex(
                name: "IX_Testimonials_PositionId",
                table: "Testimonials");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Testimonials");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Testimonials",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Meals",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_CategoryId",
                table: "Testimonials",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meals_Categories_CategoryId",
                table: "Meals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Testimonials_Categories_CategoryId",
                table: "Testimonials",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
