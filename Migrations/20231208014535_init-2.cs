using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyBanTruyen.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managa_Category_IdClassroom",
                table: "Managa");

            migrationBuilder.DropIndex(
                name: "IX_Managa_IdClassroom",
                table: "Managa");

            migrationBuilder.DropColumn(
                name: "IdClassroom",
                table: "Managa");

            migrationBuilder.CreateIndex(
                name: "IX_Managa_IdCategory",
                table: "Managa",
                column: "IdCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Managa_Category_IdCategory",
                table: "Managa",
                column: "IdCategory",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Managa_Category_IdCategory",
                table: "Managa");

            migrationBuilder.DropIndex(
                name: "IX_Managa_IdCategory",
                table: "Managa");

            migrationBuilder.AddColumn<int>(
                name: "IdClassroom",
                table: "Managa",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Managa_IdClassroom",
                table: "Managa",
                column: "IdClassroom");

            migrationBuilder.AddForeignKey(
                name: "FK_Managa_Category_IdClassroom",
                table: "Managa",
                column: "IdClassroom",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
