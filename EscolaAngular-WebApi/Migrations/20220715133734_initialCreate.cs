using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaAngular_WebApi.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    DtNascimento = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Professores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    CPF = table.Column<string>(type: "TEXT", nullable: true),
                    Endereco = table.Column<string>(type: "TEXT", nullable: true),
                    Telefone = table.Column<string>(type: "TEXT", nullable: true),
                    DtNascimento = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ProfessorId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disciplinas_Professores_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AlunosDisciplinas",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplinaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlunosDisciplinas", x => new { x.AlunoId, x.DisciplinaId });
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlunosDisciplinas_Disciplinas_DisciplinaId",
                        column: x => x.DisciplinaId,
                        principalTable: "Disciplinas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 1, null, new DateTime(1990, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "033322523-13", "Wendell Silva", "61999581206" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 2, null, new DateTime(1970, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "033322523-11", "Vanessa Silva Sobrado", "61999581223" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 3, null, new DateTime(1988, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "032322523-14", "Jeferson de Oliveira", "61999581220" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 4, null, new DateTime(1990, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "033322523-20", "Jessica Andrade", "61999581215" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 5, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "033322523-21", "Jhonatan Botafogo", "61999581110" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 6, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "033322522-15", "Ronaldo Gibraltar", "61999581209" });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Name", "Telefone" },
                values: new object[] { 7, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "033322522-00", "Gilberto Pereira", "61999581201" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[] { 1, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua 24 Brasília", "Gregorio de Matos", "61929581206" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[] { 2, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua 02 Brasília", "Fabiola Cavalcante", "61999500223" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[] { 3, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua 12 Brasília", "Ronaldo Machado", "61999581000" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[] { 4, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua 20 Brasília", "Fernanda Silva", "61999581215" });

            migrationBuilder.InsertData(
                table: "Professores",
                columns: new[] { "Id", "CPF", "DtNascimento", "Endereco", "Nome", "Telefone" },
                values: new object[] { 5, null, new DateTime(2000, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rua 27 Brasília", "Janice Pereira", "61999581139" });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Name", "ProfessorId" },
                values: new object[] { 1, "Português", 1 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Name", "ProfessorId" },
                values: new object[] { 2, "Matemática", 2 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Name", "ProfessorId" },
                values: new object[] { 3, "Historia", 3 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Name", "ProfessorId" },
                values: new object[] { 4, "Inglês", 4 });

            migrationBuilder.InsertData(
                table: "Disciplinas",
                columns: new[] { "Id", "Name", "ProfessorId" },
                values: new object[] { 5, "Fisica", 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 3, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 5, 5 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 6, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 1 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 2 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 3 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 4 });

            migrationBuilder.InsertData(
                table: "AlunosDisciplinas",
                columns: new[] { "AlunoId", "DisciplinaId" },
                values: new object[] { 7, 5 });

            migrationBuilder.CreateIndex(
                name: "IX_AlunosDisciplinas_DisciplinaId",
                table: "AlunosDisciplinas",
                column: "DisciplinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplinas_ProfessorId",
                table: "Disciplinas",
                column: "ProfessorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlunosDisciplinas");

            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "Disciplinas");

            migrationBuilder.DropTable(
                name: "Professores");
        }
    }
}
