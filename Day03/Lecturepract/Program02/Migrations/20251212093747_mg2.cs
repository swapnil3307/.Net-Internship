using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Program02.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course2_Student2_StudentId",
                table: "Course2");

            migrationBuilder.DropForeignKey(
                name: "FK_Student2_Student2_StudentId1",
                table: "Student2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student2",
                table: "Student2");

            migrationBuilder.DropIndex(
                name: "IX_Student2_StudentId1",
                table: "Student2");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course2",
                table: "Course2");

            migrationBuilder.DropColumn(
                name: "StudentId1",
                table: "Student2");

            migrationBuilder.RenameTable(
                name: "Student2",
                newName: "Student3");

            migrationBuilder.RenameTable(
                name: "Course2",
                newName: "Course3");

            migrationBuilder.RenameIndex(
                name: "IX_Course2_StudentId",
                table: "Course3",
                newName: "IX_Course3_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student3",
                table: "Student3",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course3",
                table: "Course3",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course3_Student3_StudentId",
                table: "Course3",
                column: "StudentId",
                principalTable: "Student3",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course3_Student3_StudentId",
                table: "Course3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student3",
                table: "Student3");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course3",
                table: "Course3");

            migrationBuilder.RenameTable(
                name: "Student3",
                newName: "Student2");

            migrationBuilder.RenameTable(
                name: "Course3",
                newName: "Course2");

            migrationBuilder.RenameIndex(
                name: "IX_Course3_StudentId",
                table: "Course2",
                newName: "IX_Course2_StudentId");

            migrationBuilder.AddColumn<int>(
                name: "StudentId1",
                table: "Student2",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student2",
                table: "Student2",
                column: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course2",
                table: "Course2",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Student2_StudentId1",
                table: "Student2",
                column: "StudentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Course2_Student2_StudentId",
                table: "Course2",
                column: "StudentId",
                principalTable: "Student2",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Student2_Student2_StudentId1",
                table: "Student2",
                column: "StudentId1",
                principalTable: "Student2",
                principalColumn: "StudentId");
        }
    }
}
