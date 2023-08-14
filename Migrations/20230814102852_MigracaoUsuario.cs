using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Personagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_Disputas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Disputa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AtacanteId = table.Column<int>(type: "int", nullable: false),
                    OponenteId = table.Column<int>(type: "int", nullable: false),
                    Tx_Narracao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_Disputas", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 253, 83, 131, 181, 77, 110, 179, 175, 84, 125, 206, 129, 181, 125, 208, 31, 117, 82, 54, 12, 110, 72, 78, 131, 53, 20, 49, 18, 53, 122, 63, 171, 145, 231, 229, 38, 90, 32, 87, 230, 106, 117, 123, 90, 30, 121, 171, 177, 248, 50, 74, 200, 68, 151, 212, 220, 129, 0, 77, 76, 67, 219, 132 }, new byte[] { 237, 143, 192, 5, 53, 196, 205, 199, 228, 1, 0, 159, 197, 244, 201, 135, 153, 238, 235, 188, 192, 120, 115, 172, 240, 252, 227, 61, 33, 139, 110, 159, 185, 75, 22, 110, 199, 91, 10, 1, 70, 136, 42, 246, 153, 157, 224, 231, 109, 106, 143, 149, 37, 50, 166, 230, 102, 43, 109, 195, 99, 17, 255, 63, 164, 212, 2, 230, 93, 25, 148, 158, 179, 239, 169, 135, 167, 142, 69, 18, 110, 79, 212, 125, 132, 32, 243, 144, 195, 81, 236, 99, 125, 32, 126, 165, 143, 172, 18, 17, 31, 37, 103, 164, 26, 149, 140, 54, 170, 241, 116, 115, 61, 210, 197, 97, 41, 84, 245, 246, 187, 44, 118, 160, 250, 5, 161, 109 } });

            migrationBuilder.CreateIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personagens_Usuarios_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropTable(
                name: "TB_Disputas");

            migrationBuilder.DropIndex(
                name: "IX_Personagens_UsuarioId",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personagens");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { null, null });
        }
    }
}
