using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APISystemSekolah.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(name: "Place_Of_Birth", type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(name: "Date_Of_Birth", type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoTelp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NIP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gurus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kelass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kelass", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roless",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roless", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Siswas",
                columns: table => new
                {
                    NIS = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceOfBirth = table.Column<string>(name: "Place_Of_Birth", type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<string>(name: "Date_Of_Birth", type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoTelp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherName = table.Column<string>(name: "Mother_Name", type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siswas", x => x.NIS);
                });

            migrationBuilder.CreateTable(
                name: "Matpels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKelas = table.Column<int>(name: "Id_Kelas", type: "int", nullable: false),
                    IdGuru = table.Column<int>(name: "Id_Guru", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matpels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matpels_Gurus_Id_Guru",
                        column: x => x.IdGuru,
                        principalTable: "Gurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Matpels_Kelass_Id_Kelas",
                        column: x => x.IdKelas,
                        principalTable: "Kelass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuruRoless",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdRoles = table.Column<int>(name: "Id_Roles", type: "int", nullable: false),
                    IdGuru = table.Column<int>(name: "Id_Guru", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuruRoless", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuruRoless_Gurus_Id_Guru",
                        column: x => x.IdGuru,
                        principalTable: "Gurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GuruRoless_Roless_Id_Roles",
                        column: x => x.IdRoles,
                        principalTable: "Roless",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JadwalMatpels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMatpel = table.Column<int>(name: "Id_Matpel", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JadwalMatpels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JadwalMatpels_Matpels_Id_Matpel",
                        column: x => x.IdMatpel,
                        principalTable: "Matpels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nilais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NilaiHarian = table.Column<int>(name: "Nilai_Harian", type: "int", nullable: false),
                    NilaiUTS = table.Column<int>(name: "Nilai_UTS", type: "int", nullable: false),
                    NilaiUAS = table.Column<int>(name: "Nilai_UAS", type: "int", nullable: false),
                    Nilairatarata = table.Column<int>(name: "Nilai_rata_rata", type: "int", nullable: false),
                    IdMatpel = table.Column<int>(name: "Id_Matpel", type: "int", nullable: false),
                    NISSiswa = table.Column<int>(name: "NIS_Siswa", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nilais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nilais_Matpels_Id_Matpel",
                        column: x => x.IdMatpel,
                        principalTable: "Matpels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Nilais_Siswas_NIS_Siswa",
                        column: x => x.NISSiswa,
                        principalTable: "Siswas",
                        principalColumn: "NIS",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GuruRoless_Id_Guru",
                table: "GuruRoless",
                column: "Id_Guru");

            migrationBuilder.CreateIndex(
                name: "IX_GuruRoless_Id_Roles",
                table: "GuruRoless",
                column: "Id_Roles");

            migrationBuilder.CreateIndex(
                name: "IX_JadwalMatpels_Id_Matpel",
                table: "JadwalMatpels",
                column: "Id_Matpel");

            migrationBuilder.CreateIndex(
                name: "IX_Matpels_Id_Guru",
                table: "Matpels",
                column: "Id_Guru");

            migrationBuilder.CreateIndex(
                name: "IX_Matpels_Id_Kelas",
                table: "Matpels",
                column: "Id_Kelas");

            migrationBuilder.CreateIndex(
                name: "IX_Nilais_Id_Matpel",
                table: "Nilais",
                column: "Id_Matpel");

            migrationBuilder.CreateIndex(
                name: "IX_Nilais_NIS_Siswa",
                table: "Nilais",
                column: "NIS_Siswa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuruRoless");

            migrationBuilder.DropTable(
                name: "JadwalMatpels");

            migrationBuilder.DropTable(
                name: "Nilais");

            migrationBuilder.DropTable(
                name: "Roless");

            migrationBuilder.DropTable(
                name: "Matpels");

            migrationBuilder.DropTable(
                name: "Siswas");

            migrationBuilder.DropTable(
                name: "Gurus");

            migrationBuilder.DropTable(
                name: "Kelass");
        }
    }
}
