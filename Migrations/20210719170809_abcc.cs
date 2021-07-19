using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employeeprj.Migrations
{
    public partial class abcc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    REASON = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYEmployee", x => x.EMPId);
                });

            migrationBuilder.CreateTable(
                name: "NATIONALITY",
                columns: table => new
                {
                    NATId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAT_CODE = table.Column<double>(type: "float", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NATIONALITY", x => x.NATId);
                    table.ForeignKey(
                        name: "FK_NATIONALITY_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
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
                    STOP_ID = table.Column<int>(type: "int", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYALWs", x => x.ALWId);
                    table.ForeignKey(
                        name: "FK_PYALWs_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rank",
                columns: table => new
                {
                    RANKId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RNK_CODE = table.Column<double>(type: "float", nullable: true),
                    RNK_DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rank", x => x.RANKId);
                    table.ForeignKey(
                        name: "FK_Rank_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
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
                    TRN_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SALARY_CHANGE", x => x.SALCHANGEId);
                    table.ForeignKey(
                        name: "FK_SALARY_CHANGE_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SCH_CODE",
                columns: table => new
                {
                    SCHId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SECH_CODE = table.Column<double>(type: "float", nullable: false),
                    STEP_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BASIC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCH_CODE", x => x.SCHId);
                    table.ForeignKey(
                        name: "FK_SCH_CODE_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SECTION",
                columns: table => new
                {
                    SECId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEC_CODE = table.Column<double>(type: "float", nullable: true),
                    DESC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECTION", x => x.SECId);
                    table.ForeignKey(
                        name: "FK_SECTION_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
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
                    SCH_CODESCHId = table.Column<int>(type: "int", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYSCM", x => x.SCMId);
                    table.ForeignKey(
                        name: "FK_PYSCM_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
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
                    SECTIONSECId = table.Column<int>(type: "int", nullable: true),
                    EMPId = table.Column<int>(type: "int", nullable: false),
                    PYEmployeeEMPId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYDEPT", x => x.DEPId);
                    table.ForeignKey(
                        name: "FK_PYDEPT_PYEmployee_PYEmployeeEMPId",
                        column: x => x.PYEmployeeEMPId,
                        principalTable: "PYEmployee",
                        principalColumn: "EMPId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PYDEPT_SECTION_SECTIONSECId",
                        column: x => x.SECTIONSECId,
                        principalTable: "SECTION",
                        principalColumn: "SECId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NATIONALITY_PYEmployeeEMPId",
                table: "NATIONALITY",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_PYALWs_PYEmployeeEMPId",
                table: "PYALWs",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_PYDEPT_PYEmployeeEMPId",
                table: "PYDEPT",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_PYDEPT_SECTIONSECId",
                table: "PYDEPT",
                column: "SECTIONSECId");

            migrationBuilder.CreateIndex(
                name: "IX_PYSCM_PYEmployeeEMPId",
                table: "PYSCM",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_PYSCM_SCH_CODESCHId",
                table: "PYSCM",
                column: "SCH_CODESCHId");

            migrationBuilder.CreateIndex(
                name: "IX_Rank_PYEmployeeEMPId",
                table: "Rank",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_SALARY_CHANGE_PYEmployeeEMPId",
                table: "SALARY_CHANGE",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_SCH_CODE_PYEmployeeEMPId",
                table: "SCH_CODE",
                column: "PYEmployeeEMPId");

            migrationBuilder.CreateIndex(
                name: "IX_SECTION_PYEmployeeEMPId",
                table: "SECTION",
                column: "PYEmployeeEMPId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropTable(
                name: "PYEmployee");
        }
    }
}
