using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class Usersadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AddressBooks_AddressBookId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AddressBooks");

            migrationBuilder.RenameColumn(
                name: "SystemId",
                table: "AddressBooks",
                newName: "Name");

            migrationBuilder.AlterColumn<int>(
                name: "AddressBookId",
                table: "Contacts",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "AddressBooks",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SystemId = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressBooks_UserId",
                table: "AddressBooks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AddressBooks_Users_UserId",
                table: "AddressBooks",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AddressBooks_AddressBookId",
                table: "Contacts",
                column: "AddressBookId",
                principalTable: "AddressBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AddressBooks_Users_UserId",
                table: "AddressBooks");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AddressBooks_AddressBookId",
                table: "Contacts");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_AddressBooks_UserId",
                table: "AddressBooks");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AddressBooks");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AddressBooks",
                newName: "SystemId");

            migrationBuilder.AlterColumn<int>(
                name: "AddressBookId",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AddressBooks",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AddressBooks_AddressBookId",
                table: "Contacts",
                column: "AddressBookId",
                principalTable: "AddressBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
