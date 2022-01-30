using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb3_LudwigOleby.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblElever",
                columns: table => new
                {
                    ElevId = table.Column<int>(nullable: false),
                    FörNamn = table.Column<string>(maxLength: 50, nullable: false),
                    EfterNamn = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<int>(nullable: false),
                    Klass = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblEleve__4AE80D6339D69BD2", x => x.ElevId);
                });

            migrationBuilder.CreateTable(
                name: "tblPersonal",
                columns: table => new
                {
                    PersonalId = table.Column<int>(nullable: false),
                    FörNamn = table.Column<string>(maxLength: 50, nullable: false),
                    EfterNamn = table.Column<string>(maxLength: 50, nullable: false),
                    Telefon = table.Column<int>(nullable: false),
                    Roll = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__tblPerso__283437F3E05594B8", x => x.PersonalId);
                });

            migrationBuilder.CreateTable(
                name: "tblBetyg",
                columns: table => new
                {
                    BetygId = table.Column<int>(nullable: false),
                    LärarId = table.Column<int>(nullable: false),
                    Kurs = table.Column<string>(maxLength: 50, nullable: false),
                    BetygsDatum = table.Column<DateTime>(type: "date", nullable: false),
                    Slutbetyg = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_tblBetyg_tblElever",
                        column: x => x.BetygId,
                        principalTable: "tblElever",
                        principalColumn: "ElevId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tblBetyg_tblPersonal",
                        column: x => x.LärarId,
                        principalTable: "tblPersonal",
                        principalColumn: "PersonalId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblBetyg_BetygId",
                table: "tblBetyg",
                column: "BetygId");

            migrationBuilder.CreateIndex(
                name: "IX_tblBetyg_LärarId",
                table: "tblBetyg",
                column: "LärarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblBetyg");

            migrationBuilder.DropTable(
                name: "tblElever");

            migrationBuilder.DropTable(
                name: "tblPersonal");
        }
    }
}
