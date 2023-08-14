using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false),
                    Disputas = table.Column<int>(type: "int", nullable: false),
                    Vitorias = table.Column<int>(type: "int", nullable: false),
                    Derrotas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Derrotas", "Disputas", "Nome", "Vitorias" },
                values: new object[,]
                {
                    { 1, 39, 0, 0, "Adormecer", 0 },
                    { 2, 41, 0, 0, "Congelar", 0 },
                    { 3, 37, 0, 0, "Hipnotizar", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 164, 22, 196, 6, 249, 102, 249, 175, 157, 47, 229, 76, 108, 194, 33, 5, 186, 59, 92, 225, 194, 91, 43, 27, 192, 172, 83, 118, 44, 228, 104, 163, 181, 9, 118, 0, 91, 236, 125, 175, 72, 116, 31, 63, 92, 24, 28, 199, 33, 133, 42, 245, 156, 189, 132, 51, 181, 212, 117, 117, 244, 161, 198, 111 }, new byte[] { 163, 27, 246, 2, 155, 130, 173, 4, 122, 155, 63, 176, 27, 6, 11, 194, 218, 121, 101, 42, 186, 226, 229, 61, 98, 42, 153, 3, 109, 182, 80, 218, 94, 83, 105, 15, 45, 241, 75, 70, 146, 21, 224, 89, 104, 205, 11, 191, 173, 68, 75, 250, 50, 193, 84, 165, 78, 47, 13, 175, 169, 79, 238, 74, 188, 142, 233, 153, 175, 202, 164, 181, 175, 130, 196, 196, 194, 248, 192, 22, 156, 128, 68, 109, 49, 184, 34, 237, 237, 197, 125, 176, 228, 138, 63, 157, 13, 36, 226, 146, 187, 138, 230, 238, 120, 39, 45, 247, 133, 156, 163, 84, 67, 109, 18, 14, 190, 87, 126, 44, 163, 49, 4, 211, 39, 114, 55, 127 } });

            migrationBuilder.InsertData(
                table: "PersonagemHabilidades",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 167, 10, 99, 210, 67, 82, 169, 17, 187, 47, 204, 69, 116, 61, 150, 20, 122, 2, 239, 184, 39, 120, 81, 177, 29, 43, 104, 40, 227, 68, 192, 219, 233, 160, 209, 84, 150, 138, 219, 50, 143, 247, 113, 215, 228, 10, 62, 214, 238, 57, 247, 178, 208, 80, 41, 66, 242, 107, 0, 133, 235, 51, 148 }, new byte[] { 25, 185, 182, 158, 105, 78, 190, 121, 123, 184, 84, 236, 214, 74, 168, 10, 9, 93, 206, 91, 33, 172, 119, 206, 186, 186, 110, 249, 65, 27, 191, 56, 206, 178, 6, 136, 68, 154, 186, 84, 136, 179, 173, 195, 49, 251, 7, 193, 20, 40, 178, 74, 44, 94, 166, 60, 19, 82, 141, 189, 103, 108, 125, 109, 179, 201, 53, 112, 19, 154, 171, 32, 53, 172, 198, 12, 206, 97, 176, 10, 123, 59, 79, 98, 134, 110, 170, 178, 87, 154, 132, 183, 108, 105, 90, 16, 53, 74, 221, 167, 6, 228, 9, 248, 167, 15, 230, 200, 119, 215, 247, 92, 219, 32, 112, 167, 209, 37, 90, 213, 32, 99, 10, 83, 157, 121, 38, 190 } });
        }
    }
}
