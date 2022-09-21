using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWiFT_GNC_Scorecard.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ORDNUM = table.Column<string>(type: "TEXT", nullable: false),
                    WALLNUM = table.Column<string>(type: "TEXT", nullable: false),
                    ROOMNUM = table.Column<string>(type: "TEXT", nullable: false),
                    LINNUM = table.Column<string>(type: "TEXT", nullable: false),
                    PARTQTY = table.Column<decimal>(type: "TEXT", nullable: false),
                    WIDTH = table.Column<decimal>(type: "TEXT", nullable: false),
                    WIDTHSTR = table.Column<string>(type: "TEXT", nullable: false),
                    LENGTH = table.Column<decimal>(type: "TEXT", nullable: false),
                    LENGTHSTR = table.Column<string>(type: "TEXT", nullable: false),
                    DEPTH = table.Column<decimal>(type: "TEXT", nullable: false),
                    DEPTHSTR = table.Column<string>(type: "TEXT", nullable: false),
                    PARTID = table.Column<int>(type: "INTEGER", nullable: false),
                    DeptID = table.Column<int>(type: "INTEGER", nullable: false),
                    PARTNAME = table.Column<string>(type: "TEXT", nullable: false),
                    MATERIALID = table.Column<string>(type: "TEXT", nullable: false),
                    MATERIALNAME = table.Column<string>(type: "TEXT", nullable: false),
                    MATLISTNUM = table.Column<string>(type: "TEXT", nullable: false),
                    MATGRAINDEF = table.Column<string>(type: "TEXT", nullable: false),
                    OPTIMIZE = table.Column<string>(type: "TEXT", nullable: false),
                    STOCKPART = table.Column<string>(type: "TEXT", nullable: false),
                    WASTEFACTOR = table.Column<string>(type: "TEXT", nullable: false),
                    MATCOST = table.Column<string>(type: "TEXT", nullable: false),
                    MATCOSTUNIT = table.Column<string>(type: "TEXT", nullable: false),
                    LABORMINUTES = table.Column<string>(type: "TEXT", nullable: false),
                    MATTYPE = table.Column<string>(type: "TEXT", nullable: false),
                    UDF2DEC = table.Column<string>(type: "TEXT", nullable: false),
                    UDF3DEC = table.Column<string>(type: "TEXT", nullable: false),
                    UDF4DEC = table.Column<string>(type: "TEXT", nullable: false),
                    CABNAME = table.Column<string>(type: "TEXT", nullable: false),
                    CABNAMETYPE = table.Column<string>(type: "TEXT", nullable: false),
                    PARTCOMMENT = table.Column<string>(type: "TEXT", nullable: false),
                    PARTBANDCODE = table.Column<string>(type: "TEXT", nullable: false),
                    ROOMNAME = table.Column<string>(type: "TEXT", nullable: false),
                    SECONDPRTPROG = table.Column<string>(type: "TEXT", nullable: false),
                    PRIMARYPRTPROGMIRR = table.Column<string>(type: "TEXT", nullable: false),
                    SECONDPRTPROGMIRR = table.Column<string>(type: "TEXT", nullable: false),
                    PPPBARCODE = table.Column<string>(type: "TEXT", nullable: false),
                    SPPBARCODE = table.Column<string>(type: "TEXT", nullable: false),
                    JOBDESCRIPTION = table.Column<string>(type: "TEXT", nullable: false),
                    INTBANDMAT = table.Column<string>(type: "TEXT", nullable: false),
                    INTBANDCOLOR = table.Column<string>(type: "TEXT", nullable: false),
                    isCNC = table.Column<bool>(type: "INTEGER", nullable: false),
                    isPanelSaw = table.Column<bool>(type: "INTEGER", nullable: false),
                    isShowing = table.Column<bool>(type: "INTEGER", nullable: false),
                    isNonShow = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TrackedTimes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PartID = table.Column<int>(type: "INTEGER", nullable: false),
                    DeptID = table.Column<int>(type: "INTEGER", nullable: false),
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    startTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    completedTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrackedTimes", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TrackedTimes_Parts_PartID",
                        column: x => x.PartID,
                        principalTable: "Parts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "ID", "CABNAME", "CABNAMETYPE", "DEPTH", "DEPTHSTR", "DeptID", "INTBANDCOLOR", "INTBANDMAT", "JOBDESCRIPTION", "LABORMINUTES", "LENGTH", "LENGTHSTR", "LINNUM", "MATCOST", "MATCOSTUNIT", "MATERIALID", "MATERIALNAME", "MATGRAINDEF", "MATLISTNUM", "MATTYPE", "OPTIMIZE", "ORDNUM", "PARTBANDCODE", "PARTCOMMENT", "PARTID", "PARTNAME", "PARTQTY", "PPPBARCODE", "PRIMARYPRTPROGMIRR", "ROOMNAME", "ROOMNUM", "SECONDPRTPROG", "SECONDPRTPROGMIRR", "SPPBARCODE", "STOCKPART", "UDF2DEC", "UDF3DEC", "UDF4DEC", "WALLNUM", "WASTEFACTOR", "WIDTH", "WIDTHSTR", "isCNC", "isNonShow", "isPanelSaw", "isShowing" },
                values: new object[] { 6821, "W-3636BD", "W", 0.7500m, "0.5", 0, "NULL", "NULL", "NULL", "NULL", 36.2500m, "36", "1", "NULL", "NULL", "1867", "0500 DL LAM / RAW PLY", "NULL", "1", "NULL", "NULL", "21009716", "NULL", "NULL", 8, "Unfinished End Left", 1m, "NULL", "NULL", "NULL", "1", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "0", "NULL", 11.5000m, "11 1/4", true, false, false, false });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "ID", "CABNAME", "CABNAMETYPE", "DEPTH", "DEPTHSTR", "DeptID", "INTBANDCOLOR", "INTBANDMAT", "JOBDESCRIPTION", "LABORMINUTES", "LENGTH", "LENGTHSTR", "LINNUM", "MATCOST", "MATCOSTUNIT", "MATERIALID", "MATERIALNAME", "MATGRAINDEF", "MATLISTNUM", "MATTYPE", "OPTIMIZE", "ORDNUM", "PARTBANDCODE", "PARTCOMMENT", "PARTID", "PARTNAME", "PARTQTY", "PPPBARCODE", "PRIMARYPRTPROGMIRR", "ROOMNAME", "ROOMNUM", "SECONDPRTPROG", "SECONDPRTPROGMIRR", "SPPBARCODE", "STOCKPART", "UDF2DEC", "UDF3DEC", "UDF4DEC", "WALLNUM", "WASTEFACTOR", "WIDTH", "WIDTHSTR", "isCNC", "isNonShow", "isPanelSaw", "isShowing" },
                values: new object[] { 6822, "W-3636BD", "W", 0.750m, "0.5", 0, "NULL", "NULL", "NULL", "NULL", 36.250m, "36", "1", "NULL", "NULL", "1867", "0500 DL LAM / RAW PLY", "NULL", "1", "NULL", "NULL", "21009716", "NULL", "NULL", 10, "Unfinished End Right", 1m, "NULL", "NULL", "NULL", "1", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "0", "NULL", 11.500m, "11 1/4", true, true, true, true });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "ID", "CABNAME", "CABNAMETYPE", "DEPTH", "DEPTHSTR", "DeptID", "INTBANDCOLOR", "INTBANDMAT", "JOBDESCRIPTION", "LABORMINUTES", "LENGTH", "LENGTHSTR", "LINNUM", "MATCOST", "MATCOSTUNIT", "MATERIALID", "MATERIALNAME", "MATGRAINDEF", "MATLISTNUM", "MATTYPE", "OPTIMIZE", "ORDNUM", "PARTBANDCODE", "PARTCOMMENT", "PARTID", "PARTNAME", "PARTQTY", "PPPBARCODE", "PRIMARYPRTPROGMIRR", "ROOMNAME", "ROOMNUM", "SECONDPRTPROG", "SECONDPRTPROGMIRR", "SPPBARCODE", "STOCKPART", "UDF2DEC", "UDF3DEC", "UDF4DEC", "WALLNUM", "WASTEFACTOR", "WIDTH", "WIDTHSTR", "isCNC", "isNonShow", "isPanelSaw", "isShowing" },
                values: new object[] { 6823, "W-3636BD", "W", 0.3750m, "0.125", 0, "NULL", "NULL", "NULL", "NULL", 34.7500m, "34 1/2", "1", "NULL", "NULL", "1839", "0500 CL BIRCH C3 F2S PLY", "NULL", "1", "NULL", "NULL", "21009716", "NULL", "NULL", 11, "Bottom", 1m, "NULL", "NULL", "NULL", "1", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "0", "NULL", 11.7500m, "11 1/2", true, true, true, true });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "ID", "CABNAME", "CABNAMETYPE", "DEPTH", "DEPTHSTR", "DeptID", "INTBANDCOLOR", "INTBANDMAT", "JOBDESCRIPTION", "LABORMINUTES", "LENGTH", "LENGTHSTR", "LINNUM", "MATCOST", "MATCOSTUNIT", "MATERIALID", "MATERIALNAME", "MATGRAINDEF", "MATLISTNUM", "MATTYPE", "OPTIMIZE", "ORDNUM", "PARTBANDCODE", "PARTCOMMENT", "PARTID", "PARTNAME", "PARTQTY", "PPPBARCODE", "PRIMARYPRTPROGMIRR", "ROOMNAME", "ROOMNUM", "SECONDPRTPROG", "SECONDPRTPROGMIRR", "SPPBARCODE", "STOCKPART", "UDF2DEC", "UDF3DEC", "UDF4DEC", "WALLNUM", "WASTEFACTOR", "WIDTH", "WIDTHSTR", "isCNC", "isNonShow", "isPanelSaw", "isShowing" },
                values: new object[] { 6824, "W-3636BD", "W", 0.7500m, "0.5", 0, "NULL", "NULL", "NULL", "NULL", 34.6250m, "34 3/8", "1", "NULL", "NULL", "1867", "0500 DL LAM / RAW PLY", "NULL", "1", "NULL", "NULL", "21009716", "NULL", "NULL", 13, "Unf Back", 1m, "NULL", "NULL", "NULL", "1", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "0", "NULL", 35.5000m, "35 1/4", true, true, false, false });

            migrationBuilder.InsertData(
                table: "Parts",
                columns: new[] { "ID", "CABNAME", "CABNAMETYPE", "DEPTH", "DEPTHSTR", "DeptID", "INTBANDCOLOR", "INTBANDMAT", "JOBDESCRIPTION", "LABORMINUTES", "LENGTH", "LENGTHSTR", "LINNUM", "MATCOST", "MATCOSTUNIT", "MATERIALID", "MATERIALNAME", "MATGRAINDEF", "MATLISTNUM", "MATTYPE", "OPTIMIZE", "ORDNUM", "PARTBANDCODE", "PARTCOMMENT", "PARTID", "PARTNAME", "PARTQTY", "PPPBARCODE", "PRIMARYPRTPROGMIRR", "ROOMNAME", "ROOMNUM", "SECONDPRTPROG", "SECONDPRTPROGMIRR", "SPPBARCODE", "STOCKPART", "UDF2DEC", "UDF3DEC", "UDF4DEC", "WALLNUM", "WASTEFACTOR", "WIDTH", "WIDTHSTR", "isCNC", "isNonShow", "isPanelSaw", "isShowing" },
                values: new object[] { 6825, "W-3636BD", "W", 1.0000m, "0.75", 0, "NULL", "NULL", "NULL", "NULL", 34.6250m, "34 3/8", "1", "NULL", "NULL", "1841", "0750 CL BIRCH ADJSH PB", "NULL", "1", "NULL", "NULL", "21009716", "NULL", "NULL", 15, "Adjustable Shelf", 2m, "NULL", "NULL", "NULL", "1", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "NULL", "0", "NULL", 10.8438m, "10 19/32", true, false, false, false });

            migrationBuilder.CreateIndex(
                name: "IX_TrackedTimes_PartID",
                table: "TrackedTimes",
                column: "PartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrackedTimes");

            migrationBuilder.DropTable(
                name: "Parts");
        }
    }
}
