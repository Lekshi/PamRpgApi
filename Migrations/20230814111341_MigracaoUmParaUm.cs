using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 167, 10, 99, 210, 67, 82, 169, 17, 187, 47, 204, 69, 116, 61, 150, 20, 122, 2, 239, 184, 39, 120, 81, 177, 29, 43, 104, 40, 227, 68, 192, 219, 233, 160, 209, 84, 150, 138, 219, 50, 143, 247, 113, 215, 228, 10, 62, 214, 238, 57, 247, 178, 208, 80, 41, 66, 242, 107, 0, 133, 235, 51, 148 }, new byte[] { 25, 185, 182, 158, 105, 78, 190, 121, 123, 184, 84, 236, 214, 74, 168, 10, 9, 93, 206, 91, 33, 172, 119, 206, 186, 186, 110, 249, 65, 27, 191, 56, 206, 178, 6, 136, 68, 154, 186, 84, 136, 179, 173, 195, 49, 251, 7, 193, 20, 40, 178, 74, 44, 94, 166, 60, 19, 82, 141, 189, 103, 108, 125, 109, 179, 201, 53, 112, 19, 154, 171, 32, 53, 172, 198, 12, 206, 97, 176, 10, 123, 59, 79, 98, 134, 110, 170, 178, 87, 154, 132, 183, 108, 105, 90, 16, 53, 74, 221, 167, 6, 228, 9, 248, 167, 15, 230, 200, 119, 215, 247, 92, 219, 32, 112, 167, 209, 37, 90, 213, 32, 99, 10, 83, 157, 121, 38, 190 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 107, 253, 83, 131, 181, 77, 110, 179, 175, 84, 125, 206, 129, 181, 125, 208, 31, 117, 82, 54, 12, 110, 72, 78, 131, 53, 20, 49, 18, 53, 122, 63, 171, 145, 231, 229, 38, 90, 32, 87, 230, 106, 117, 123, 90, 30, 121, 171, 177, 248, 50, 74, 200, 68, 151, 212, 220, 129, 0, 77, 76, 67, 219, 132 }, new byte[] { 237, 143, 192, 5, 53, 196, 205, 199, 228, 1, 0, 159, 197, 244, 201, 135, 153, 238, 235, 188, 192, 120, 115, 172, 240, 252, 227, 61, 33, 139, 110, 159, 185, 75, 22, 110, 199, 91, 10, 1, 70, 136, 42, 246, 153, 157, 224, 231, 109, 106, 143, 149, 37, 50, 166, 230, 102, 43, 109, 195, 99, 17, 255, 63, 164, 212, 2, 230, 93, 25, 148, 158, 179, 239, 169, 135, 167, 142, 69, 18, 110, 79, 212, 125, 132, 32, 243, 144, 195, 81, 236, 99, 125, 32, 126, 165, 143, 172, 18, 17, 31, 37, 103, 164, 26, 149, 140, 54, 170, 241, 116, 115, 61, 210, 197, 97, 41, 84, 245, 246, 187, 44, 118, 160, 250, 5, 161, 109 } });
        }
    }
}
