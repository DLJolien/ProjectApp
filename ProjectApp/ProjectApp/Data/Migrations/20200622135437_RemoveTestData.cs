using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectApp.Data.Migrations
{
    public partial class RemoveTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProjectTags",
                keyColumns: new[] { "TagId", "ProjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectTags",
                keyColumns: new[] { "TagId", "ProjectId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProjectTags",
                keyColumns: new[] { "TagId", "ProjectId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProjectTags",
                keyColumns: new[] { "TagId", "ProjectId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CompletionDate", "Description", "PhotoUrl", "StatusId", "Title" },
                values: new object[] { 1, new DateTime(2020, 6, 22, 13, 15, 26, 558, DateTimeKind.Local).AddTicks(5077), "Fun winforms project", null, 1, "Calculator" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CompletionDate", "Description", "PhotoUrl", "StatusId", "Title" },
                values: new object[] { 2, new DateTime(2020, 6, 22, 13, 15, 26, 564, DateTimeKind.Local).AddTicks(5157), "Difficult project", null, 2, "Portfolio website" });

            migrationBuilder.InsertData(
                table: "ProjectTags",
                columns: new[] { "TagId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 5, 2 },
                    { 7, 2 }
                });
        }
    }
}
