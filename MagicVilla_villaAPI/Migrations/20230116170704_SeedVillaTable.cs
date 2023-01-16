using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillavillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreateDate", "Details", "ImgUrl", "Name", "Ocupancy", "Rate", "Sqft", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As we all know, a paragraph is a", "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=McVf5uszvVk5SM", "White Villa", 550, 10.0, 50, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), " for better understanding, and to make a", "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=ShQnriFk8AK93M", "new to Villa", 500, 0.0, 500, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As we all know, a paragraph is a", "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=V-JSYbzQMO6IvM", "Master Villa", 550, 15.0, 55, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As we all know, a paragraph is a", "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=4_CKrxwlMJxE5M", "Gren Villa", 100, 70.0, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "As we all know, a paragraph is a", "https://www.google.com/search?q=jpg+image&rlz=1C1BNSD_en&oq=jpg+image&aqs=chrome..69i57j0i512l9.12808j0j7&sourceid=chrome&ie=UTF-8#imgrc=hTEa-1tbJvTjZM", "Diamond Villa", 100, 40.0, 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
