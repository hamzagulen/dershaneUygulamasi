using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace efcoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsToKullanici : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ad",
                table: "Kullanicilar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Kullanicilar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Soyad",
                table: "Kullanicilar",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Telefon",
                table: "Kullanicilar",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ad",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Soyad",
                table: "Kullanicilar");

            migrationBuilder.DropColumn(
                name: "Telefon",
                table: "Kullanicilar");
        }
    }
}
