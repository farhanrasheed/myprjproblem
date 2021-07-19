using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employeeprj.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NATIONALITY",
                columns: table => new
                {
                    NATId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAT_CODE = table.Column<double>(type: "float", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NATIONALITY", x => x.NATId);
                });

            migrationBuilder.CreateTable(
                name: "PYALWs",
                columns: table => new
                {
                    ALWId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NO = table.Column<double>(type: "float", nullable: true),
                    ALW_CODE = table.Column<int>(type: "int", nullable: true),
                    ALW_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    STOP_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYALWs", x => x.ALWId);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    RANKId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNK_CODE = table.Column<double>(type: "float", nullable: true),
                    RNK_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.RANKId);
                });

            migrationBuilder.CreateTable(
                name: "SALARY_CHANGE",
                columns: table => new
                {
                    SALCHANGEId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NO = table.Column<double>(type: "float", nullable: true),
                    TRN_PERIOD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TRN_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OLD_BASIC = table.Column<double>(type: "float", nullable: true),
                    NEW_BASIC = table.Column<double>(type: "float", nullable: true),
                    TRN_DATE = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALARY_CHANGE", x => x.SALCHANGEId);
                });

            migrationBuilder.CreateTable(
                name: "SCH_CODE",
                columns: table => new
                {
                    SCHId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SECH_CODE = table.Column<double>(type: "float", nullable: false),
                    STEP_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCH_CODE", x => x.SCHId);
                });

            migrationBuilder.CreateTable(
                name: "SECTION",
                columns: table => new
                {
                    SECId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEC_CODE = table.Column<double>(type: "float", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECTION", x => x.SECId);
                });

            migrationBuilder.CreateTable(
                name: "PYSCM",
                columns: table => new
                {
                    SCMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SCM_CODE = table.Column<double>(type: "float", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SCHId = table.Column<int>(type: "int", nullable: false),
                    SCH_CODESCHId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYSCM", x => x.SCMId);
                    table.ForeignKey(
                        name: "FK_PYSCM_SCH_CODE_SCH_CODESCHId",
                        column: x => x.SCH_CODESCHId,
                        principalTable: "SCH_CODE",
                        principalColumn: "SCHId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PYDEPT",
                columns: table => new
                {
                    DEPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DEP_CODE = table.Column<double>(type: "float", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SECId = table.Column<int>(type: "int", nullable: false),
                    SECTIONSECId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYDEPT", x => x.DEPId);
                    table.ForeignKey(
                        name: "FK_PYDEPT_SECTION_SECTIONSECId",
                        column: x => x.SECTIONSECId,
                        principalTable: "SECTION",
                        principalColumn: "SECId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PYEmployee",
                columns: table => new
                {
                    EMPId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NO = table.Column<double>(type: "float", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SEX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MARITAL_ST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_OF_BRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STOP_ID = table.Column<int>(type: "int", nullable: true),
                    REASON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RANKId = table.Column<int>(type: "int", nullable: false),
                    DEPId = table.Column<int>(type: "int", nullable: false),
                    PYDEPTsDEPId = table.Column<int>(type: "int", nullable: true),
                    NATId = table.Column<int>(type: "int", nullable: false),
                    NATIONALITYsNATId = table.Column<int>(type: "int", nullable: true),
                    SECId = table.Column<int>(type: "int", nullable: false),
                    SECTIONsSECId = table.Column<int>(type: "int", nullable: true),
                    ALWId = table.Column<int>(type: "int", nullable: false),
                    PYALWsALWId = table.Column<int>(type: "int", nullable: true),
                    SCHId = table.Column<int>(type: "int", nullable: false),
                    SCH_CODEsSCHId = table.Column<int>(type: "int", nullable: true),
                    SCMId = table.Column<int>(type: "int", nullable: false),
                    PYSCMSCMId = table.Column<int>(type: "int", nullable: true),
                    SALCHANGEId = table.Column<int>(type: "int", nullable: false),
                    SALARY_CHANGESALCHANGEId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYEmployee", x => x.EMPId);
                    table.ForeignKey(
                        name: "FK_PYEmployee_NATIONALITY_NATIONALITYsNATId",
                        column: x => x.NATIONALITYsNATId,
                        principalTable: "NATIONALITY",
                        principalColumn: "NATId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYEmployee_PYALWs_PYALWsALWId",
                        column: x => x.PYALWsALWId,
                        principalTable: "PYALWs",
                        principalColumn: "ALWId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYEmployee_PYDEPT_PYDEPTsDEPId",
                        column: x => x.PYDEPTsDEPId,
                        principalTable: "PYDEPT",
                        principalColumn: "DEPId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYEmployee_PYSCM_PYSCMSCMId",
                        column: x => x.PYSCMSCMId,
                        principalTable: "PYSCM",
                        principalColumn: "SCMId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYEmployee_Rank_RANKId",
                        column: x => x.RANKId,
                        principalTable: "Rank",
                        principalColumn: "RANKId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PYEmployee_SALARY_CHANGE_SALARY_CHANGESALCHANGEId",
                        column: x => x.SALARY_CHANGESALCHANGEId,
                        principalTable: "SALARY_CHANGE",
                        principalColumn: "SALCHANGEId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYEmployee_SCH_CODE_SCH_CODEsSCHId",
                        column: x => x.SCH_CODEsSCHId,
                        principalTable: "SCH_CODE",
                        principalColumn: "SCHId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYEmployee_SECTION_SECTIONsSECId",
                        column: x => x.SECTIONsSECId,
                        principalTable: "SECTION",
                        principalColumn: "SECId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PYDEPT_SECTIONSECId",
                table: "PYDEPT",
                column: "SECTIONSECId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_NATIONALITYsNATId",
                table: "PYEmployee",
                column: "NATIONALITYsNATId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_PYALWsALWId",
                table: "PYEmployee",
                column: "PYALWsALWId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_PYDEPTsDEPId",
                table: "PYEmployee",
                column: "PYDEPTsDEPId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_PYSCMSCMId",
                table: "PYEmployee",
                column: "PYSCMSCMId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_RANKId",
                table: "PYEmployee",
                column: "RANKId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_SALARY_CHANGESALCHANGEId",
                table: "PYEmployee",
                column: "SALARY_CHANGESALCHANGEId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_SCH_CODEsSCHId",
                table: "PYEmployee",
                column: "SCH_CODEsSCHId");

            migrationBuilder.CreateIndex(
                name: "IX_PYEmployee_SECTIONsSECId",
                table: "PYEmployee",
                column: "SECTIONsSECId");

            migrationBuilder.CreateIndex(
                name: "IX_PYSCM_SCH_CODESCHId",
                table: "PYSCM",
                column: "SCH_CODESCHId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PYEmployee");

            migrationBuilder.DropTable(
                name: "NATIONALITY");

            migrationBuilder.DropTable(
                name: "PYALWs");

            migrationBuilder.DropTable(
                name: "PYDEPT");

            migrationBuilder.DropTable(
                name: "PYSCM");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "SALARY_CHANGE");

            migrationBuilder.DropTable(
                name: "SECTION");

            migrationBuilder.DropTable(
                name: "SCH_CODE");
        }
    }
}
