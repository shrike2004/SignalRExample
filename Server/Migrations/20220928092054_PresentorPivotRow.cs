using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SignalRExample.Migrations
{
    public partial class PresentorPivotRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PresentorPivotRows",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DocSid = table.Column<long>(type: "bigint", nullable: false),
                    RzPrz = table.Column<string>(type: "text", nullable: true),
                    Csr = table.Column<string>(type: "text", nullable: true),
                    Vr = table.Column<string>(type: "text", nullable: true),
                    Kosgu = table.Column<string>(type: "text", nullable: true),
                    PbsCode = table.Column<string>(type: "text", nullable: true),
                    PbsName = table.Column<string>(type: "text", nullable: true),
                    PbsSort = table.Column<string>(type: "text", nullable: true),
                    SumPartType = table.Column<string>(type: "text", nullable: true),
                    SumMesureName = table.Column<string>(type: "text", nullable: true),
                    SumMesureSort = table.Column<string>(type: "text", nullable: true),
                    YearNum = table.Column<int>(type: "integer", nullable: false),
                    SumDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Ou = table.Column<string>(type: "text", nullable: true),
                    OuCaption = table.Column<string>(type: "text", nullable: true),
                    Nr = table.Column<string>(type: "text", nullable: true),
                    NrCaption = table.Column<string>(type: "text", nullable: true),
                    FaipCode = table.Column<string>(type: "text", nullable: true),
                    UnderNr = table.Column<string>(type: "text", nullable: true),
                    NrTo = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PresentorPivotRows", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PresentorPivotRows");
        }
    }
}
