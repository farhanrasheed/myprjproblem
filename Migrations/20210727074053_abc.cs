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
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NATIONALITY", x => x.NATId);
                });

            migrationBuilder.CreateTable(
                name: "PYEmployee",
                columns: table => new
                {
                    EmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NO = table.Column<double>(type: "float", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RNK_CODE = table.Column<double>(type: "float", nullable: true),
                    SEX = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MARITAL_ST = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DT_OF_BRTH = table.Column<DateTime>(type: "datetime2", nullable: false),
                    STOP_ID = table.Column<int>(type: "int", nullable: true),
                    NAT_CODE = table.Column<double>(type: "float", nullable: true),
                    DEP_CODE = table.Column<double>(type: "float", nullable: true),
                    SEC_CODE = table.Column<double>(type: "float", nullable: true),
                    REASON = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYEmployee", x => x.EmpId);
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
                    SECH_CODE = table.Column<double>(type: "float", nullable: true),
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
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SECTION", x => x.SECId);
                });

            migrationBuilder.CreateTable(
                name: "PYALW",
                columns: table => new
                {
                    ALWId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMP_NO = table.Column<double>(type: "float", nullable: true),
                    ALW_CODE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ALW_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    STOP_ID = table.Column<int>(type: "int", nullable: true),
                    EmpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYALW", x => x.ALWId);
                    table.ForeignKey(
                        name: "FK_PYALW_PYEmployee_EmpId",
                        column: x => x.EmpId,
                        principalTable: "PYEmployee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PYALLOW_SCALE",
                columns: table => new
                {
                    ALLOWSCHId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ALW_CODE = table.Column<double>(type: "float", nullable: true),
                    ALW_TYPE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    STOP_ID = table.Column<int>(type: "int", nullable: true),
                    RANKId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYALLOW_SCALE", x => x.ALLOWSCHId);
                    table.ForeignKey(
                        name: "FK_PYALLOW_SCALE_Rank_RANKId",
                        column: x => x.RANKId,
                        principalTable: "Rank",
                        principalColumn: "RANKId",
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
                    SCHId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYSCM", x => x.SCMId);
                    table.ForeignKey(
                        name: "FK_PYSCM_SCH_CODE_SCHId",
                        column: x => x.SCHId,
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
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SECId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PYDEPT", x => x.DEPId);
                    table.ForeignKey(
                        name: "FK_PYDEPT_SECTION_SECId",
                        column: x => x.SECId,
                        principalTable: "SECTION",
                        principalColumn: "SECId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PYALLOW_SCALE_RANKId",
                table: "PYALLOW_SCALE",
                column: "RANKId");

            migrationBuilder.CreateIndex(
                name: "IX_PYALW_EmpId",
                table: "PYALW",
                column: "EmpId");

            migrationBuilder.CreateIndex(
                name: "IX_PYDEPT_SECId",
                table: "PYDEPT",
                column: "SECId");

            migrationBuilder.CreateIndex(
                name: "IX_PYSCM_SCHId",
                table: "PYSCM",
                column: "SCHId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NATIONALITY");

            migrationBuilder.DropTable(
                name: "PYALLOW_SCALE");

            migrationBuilder.DropTable(
                name: "PYALW");

            migrationBuilder.DropTable(
                name: "PYDEPT");

            migrationBuilder.DropTable(
                name: "PYSCM");

            migrationBuilder.DropTable(
                name: "SALARY_CHANGE");

            migrationBuilder.DropTable(
                name: "Rank");

            migrationBuilder.DropTable(
                name: "PYEmployee");

            migrationBuilder.DropTable(
                name: "SECTION");

            migrationBuilder.DropTable(
                name: "SCH_CODE");
        }
    }
}
