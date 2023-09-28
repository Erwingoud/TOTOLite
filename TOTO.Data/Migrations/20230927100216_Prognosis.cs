using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TOTO.Data.Migrations
{
    /// <inheritdoc />
    public partial class Prognosis : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prognosis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomersExpected = table.Column<int>(type: "int", nullable: false),
                    ColliExpected = table.Column<int>(type: "int", nullable: false),
                    PrognosisDate = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prognosis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Prognosis",
                columns: new[] { "Id", "ColliExpected", "CustomersExpected", "PrognosisDate" },
                values: new object[,]
                {
                    { -100, 32, 411, new DateTime(2023, 10, 16, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -99, 58, 479, new DateTime(2023, 10, 15, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -98, 34, 279, new DateTime(2023, 10, 14, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -97, 44, 382, new DateTime(2023, 10, 13, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -96, 47, 425, new DateTime(2023, 10, 12, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -95, 51, 466, new DateTime(2023, 10, 11, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -94, 47, 452, new DateTime(2023, 10, 10, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -93, 59, 397, new DateTime(2023, 10, 9, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -92, 35, 478, new DateTime(2023, 10, 8, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -91, 30, 215, new DateTime(2023, 10, 7, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -90, 31, 264, new DateTime(2023, 10, 6, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -89, 53, 308, new DateTime(2023, 10, 5, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -88, 42, 230, new DateTime(2023, 10, 4, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -87, 37, 479, new DateTime(2023, 10, 3, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -86, 55, 222, new DateTime(2023, 10, 2, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -85, 39, 360, new DateTime(2023, 10, 1, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -84, 48, 248, new DateTime(2023, 9, 30, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -83, 48, 324, new DateTime(2023, 9, 29, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -82, 46, 487, new DateTime(2023, 9, 28, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -81, 58, 272, new DateTime(2023, 9, 27, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -80, 44, 212, new DateTime(2023, 9, 26, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -79, 52, 244, new DateTime(2023, 9, 25, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -78, 60, 331, new DateTime(2023, 9, 24, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -77, 39, 285, new DateTime(2023, 9, 23, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -76, 40, 221, new DateTime(2023, 9, 22, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -75, 57, 409, new DateTime(2023, 9, 21, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -74, 54, 398, new DateTime(2023, 9, 20, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -73, 48, 471, new DateTime(2023, 9, 19, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -72, 42, 382, new DateTime(2023, 9, 18, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -71, 40, 415, new DateTime(2023, 9, 17, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -70, 31, 348, new DateTime(2023, 9, 16, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -69, 43, 401, new DateTime(2023, 9, 15, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -68, 55, 307, new DateTime(2023, 9, 14, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -67, 30, 482, new DateTime(2023, 9, 13, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -66, 34, 344, new DateTime(2023, 9, 12, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -65, 39, 365, new DateTime(2023, 9, 11, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -64, 45, 488, new DateTime(2023, 9, 10, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -63, 53, 207, new DateTime(2023, 9, 9, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -62, 34, 361, new DateTime(2023, 9, 8, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -61, 33, 416, new DateTime(2023, 9, 7, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -60, 30, 361, new DateTime(2023, 9, 6, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -59, 30, 296, new DateTime(2023, 9, 5, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -58, 49, 331, new DateTime(2023, 9, 4, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -57, 54, 453, new DateTime(2023, 9, 3, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -56, 42, 353, new DateTime(2023, 9, 2, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -55, 39, 356, new DateTime(2023, 9, 1, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -54, 53, 332, new DateTime(2023, 8, 31, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -53, 30, 240, new DateTime(2023, 8, 30, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -52, 38, 385, new DateTime(2023, 8, 29, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -51, 51, 231, new DateTime(2023, 8, 28, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -50, 35, 362, new DateTime(2023, 8, 27, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -49, 58, 414, new DateTime(2023, 8, 26, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -48, 59, 219, new DateTime(2023, 8, 25, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -47, 56, 232, new DateTime(2023, 8, 24, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -46, 48, 222, new DateTime(2023, 8, 23, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -45, 53, 273, new DateTime(2023, 8, 22, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -44, 38, 452, new DateTime(2023, 8, 21, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -43, 57, 335, new DateTime(2023, 8, 20, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -42, 41, 490, new DateTime(2023, 8, 19, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -41, 57, 222, new DateTime(2023, 8, 18, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -40, 47, 325, new DateTime(2023, 8, 17, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -39, 35, 459, new DateTime(2023, 8, 16, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -38, 53, 461, new DateTime(2023, 8, 15, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -37, 47, 311, new DateTime(2023, 8, 14, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -36, 50, 418, new DateTime(2023, 8, 13, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -35, 51, 392, new DateTime(2023, 8, 12, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -34, 48, 364, new DateTime(2023, 8, 11, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -33, 35, 360, new DateTime(2023, 8, 10, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -32, 31, 241, new DateTime(2023, 8, 9, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -31, 39, 392, new DateTime(2023, 8, 8, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -30, 51, 266, new DateTime(2023, 8, 7, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -29, 50, 438, new DateTime(2023, 8, 6, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -28, 32, 354, new DateTime(2023, 8, 5, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -27, 33, 430, new DateTime(2023, 8, 4, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -26, 53, 275, new DateTime(2023, 8, 3, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -25, 36, 443, new DateTime(2023, 8, 2, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -24, 35, 456, new DateTime(2023, 8, 1, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -23, 31, 348, new DateTime(2023, 7, 31, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -22, 47, 465, new DateTime(2023, 7, 30, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -21, 37, 420, new DateTime(2023, 7, 29, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -20, 35, 369, new DateTime(2023, 7, 28, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -19, 43, 301, new DateTime(2023, 7, 27, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -18, 49, 447, new DateTime(2023, 7, 26, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -17, 55, 468, new DateTime(2023, 7, 25, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -16, 52, 349, new DateTime(2023, 7, 24, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -15, 34, 387, new DateTime(2023, 7, 23, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -14, 56, 306, new DateTime(2023, 7, 22, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -13, 36, 414, new DateTime(2023, 7, 21, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -12, 47, 376, new DateTime(2023, 7, 20, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -11, 43, 222, new DateTime(2023, 7, 19, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -10, 49, 393, new DateTime(2023, 7, 18, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -9, 36, 362, new DateTime(2023, 7, 17, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -8, 42, 450, new DateTime(2023, 7, 16, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -7, 60, 368, new DateTime(2023, 7, 15, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -6, 32, 315, new DateTime(2023, 7, 14, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -5, 36, 415, new DateTime(2023, 7, 13, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -4, 49, 244, new DateTime(2023, 7, 12, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -3, 37, 288, new DateTime(2023, 7, 11, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -2, 49, 279, new DateTime(2023, 7, 10, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) },
                    { -1, 50, 353, new DateTime(2023, 7, 9, 12, 2, 16, 740, DateTimeKind.Local).AddTicks(1864) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prognosis");
        }
    }
}
