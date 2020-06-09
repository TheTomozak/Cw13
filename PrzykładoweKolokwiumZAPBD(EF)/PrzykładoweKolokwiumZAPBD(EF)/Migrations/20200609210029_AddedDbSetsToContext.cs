using Microsoft.EntityFrameworkCore.Migrations;

namespace PrzykładoweKolokwiumZAPBD_EF_.Migrations
{
    public partial class AddedDbSetsToContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_Klient_IdKlient",
                table: "Zamowienie");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_Pracownik_IdPracownik",
                table: "Zamowienie");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienie_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobCukierniczy_IdwyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zamowienie",
                table: "Zamowienie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WyrobCukierniczy",
                table: "WyrobCukierniczy");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pracownik",
                table: "Pracownik");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klient",
                table: "Klient");

            migrationBuilder.RenameTable(
                name: "Zamowienie",
                newName: "Zamowienies");

            migrationBuilder.RenameTable(
                name: "WyrobCukierniczy",
                newName: "WyrobCukierniczies");

            migrationBuilder.RenameTable(
                name: "Pracownik",
                newName: "Pracowniks");

            migrationBuilder.RenameTable(
                name: "Klient",
                newName: "Klients");

            migrationBuilder.RenameIndex(
                name: "IX_Zamowienie_IdPracownik",
                table: "Zamowienies",
                newName: "IX_Zamowienies_IdPracownik");

            migrationBuilder.RenameIndex(
                name: "IX_Zamowienie_IdKlient",
                table: "Zamowienies",
                newName: "IX_Zamowienies_IdKlient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zamowienies",
                table: "Zamowienies",
                column: "IdZamowienie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WyrobCukierniczies",
                table: "WyrobCukierniczies",
                column: "IdWyrobCukierniczy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pracowniks",
                table: "Pracowniks",
                column: "IdPracownik");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klients",
                table: "Klients",
                column: "IdKlient");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienies_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdZamowienia",
                principalTable: "Zamowienies",
                principalColumn: "IdZamowienie",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobCukierniczies_IdwyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdwyrobuCukierniczego",
                principalTable: "WyrobCukierniczies",
                principalColumn: "IdWyrobCukierniczy",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienies_Klients_IdKlient",
                table: "Zamowienies",
                column: "IdKlient",
                principalTable: "Klients",
                principalColumn: "IdKlient",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienies_Pracowniks_IdPracownik",
                table: "Zamowienies",
                column: "IdPracownik",
                principalTable: "Pracowniks",
                principalColumn: "IdPracownik",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienies_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobCukierniczies_IdwyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienies_Klients_IdKlient",
                table: "Zamowienies");

            migrationBuilder.DropForeignKey(
                name: "FK_Zamowienies_Pracowniks_IdPracownik",
                table: "Zamowienies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Zamowienies",
                table: "Zamowienies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WyrobCukierniczies",
                table: "WyrobCukierniczies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pracowniks",
                table: "Pracowniks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Klients",
                table: "Klients");

            migrationBuilder.RenameTable(
                name: "Zamowienies",
                newName: "Zamowienie");

            migrationBuilder.RenameTable(
                name: "WyrobCukierniczies",
                newName: "WyrobCukierniczy");

            migrationBuilder.RenameTable(
                name: "Pracowniks",
                newName: "Pracownik");

            migrationBuilder.RenameTable(
                name: "Klients",
                newName: "Klient");

            migrationBuilder.RenameIndex(
                name: "IX_Zamowienies_IdPracownik",
                table: "Zamowienie",
                newName: "IX_Zamowienie_IdPracownik");

            migrationBuilder.RenameIndex(
                name: "IX_Zamowienies_IdKlient",
                table: "Zamowienie",
                newName: "IX_Zamowienie_IdKlient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Zamowienie",
                table: "Zamowienie",
                column: "IdZamowienie");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WyrobCukierniczy",
                table: "WyrobCukierniczy",
                column: "IdWyrobCukierniczy");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pracownik",
                table: "Pracownik",
                column: "IdPracownik");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Klient",
                table: "Klient",
                column: "IdKlient");

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_Klient_IdKlient",
                table: "Zamowienie",
                column: "IdKlient",
                principalTable: "Klient",
                principalColumn: "IdKlient",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_Pracownik_IdPracownik",
                table: "Zamowienie",
                column: "IdPracownik",
                principalTable: "Pracownik",
                principalColumn: "IdPracownik",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_Zamowienie_IdZamowienia",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdZamowienia",
                principalTable: "Zamowienie",
                principalColumn: "IdZamowienie",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zamowienie_WyrobCukierniczy_WyrobCukierniczy_IdwyrobuCukierniczego",
                table: "Zamowienie_WyrobCukierniczy",
                column: "IdwyrobuCukierniczego",
                principalTable: "WyrobCukierniczy",
                principalColumn: "IdWyrobCukierniczy",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
