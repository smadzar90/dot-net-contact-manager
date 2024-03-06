using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactManager.Migrations
{
    public partial class setupContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Organisation = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                    table.ForeignKey(
                        name: "FK_Contacts_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[,]
                {
                    { 1, "Family" },
                    { 2, "Friend" },
                    { 3, "Work" },
                    { 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "CategoryID", "DateAdded", "Email", "FirstName", "LastName", "Organisation", "Phone" },
                values: new object[] { 1, 1, new DateTime(2024, 3, 5, 19, 8, 52, 910, DateTimeKind.Local).AddTicks(5913), "johndoe@example.com", "John", "Doe", "exampleORG", "(919)-312-8232" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "CategoryID", "DateAdded", "Email", "FirstName", "LastName", "Organisation", "Phone" },
                values: new object[] { 3, 1, new DateTime(2024, 3, 5, 19, 8, 52, 912, DateTimeKind.Local).AddTicks(4571), "adamdoe@example.com", "Adam", "Doe", "ORG21", "(919)-352-8992" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactID", "CategoryID", "DateAdded", "Email", "FirstName", "LastName", "Organisation", "Phone" },
                values: new object[] { 2, 4, new DateTime(2024, 3, 5, 19, 8, 52, 912, DateTimeKind.Local).AddTicks(4529), "alexsmith@example.com", "Alex", "Smith", "ORG2", "(919)-354-2475" });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CategoryID",
                table: "Contacts",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
