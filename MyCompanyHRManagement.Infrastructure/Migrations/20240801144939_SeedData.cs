using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyCompanyHRManagement.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "CreatedAt", "Email", "Name", "Phone", "SubscriptionEndDate", "TenantId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Karaağaç Caddesi No:2-6 Sütlüce 34445 Beyoğlu Istanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@arcelik.com", "Arçelik A.Ş.", "+90 212 314 34 34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d89135b-9af7-42c0-b393-14b26a04f8fd"), null },
                    { 2, "Aydınevler Mahallesi İnönü Caddesi No:20 Küçükyalı Ofispark 34854 Maltepe Istanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@turkcell.com.tr", "Turkcell İletişim Hizmetleri A.Ş.", "+90 212 313 10 00", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("32fdbf3b-d8ed-417f-a5c7-70a62da29691"), null },
                    { 3, "Kısıklı Mahallesi Ferah Caddesi No:1 34692 Büyük Çamlıca Üsküdar Istanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@ulker.com.tr", "Ülker Bisküvi Sanayi A.Ş.", "+90 216 524 25 00", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("fc890933-267d-438d-a482-178a09220beb"), null },
                    { 4, "AEROPARK Yenişehir Mahallesi Osmanlı Bulvarı No: 11/A Kurtköy 34912 Pendik Istanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@flypgs.com", "Pegasus Hava Taşımacılığı A.Ş.", "+90 216 560 70 00", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f65dfcef-1c84-4f76-b5bd-25c2d003c90b"), null },
                    { 5, "Nakkaştepe Azizbey Sokak No:1 34674 Kuzguncuk Üsküdar Istanbul", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "info@koc.com.tr", "Koç Holding A.Ş.", "+90 216 531 00 00", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3ccd0bcb-448e-49e4-97e4-28f0369ddedc"), null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "DateOfBirth", "Email", "FirstName", "HireDate", "LastName", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmet.yilmaz@arcelik.com", "Ahmet", new DateTime(2010, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yılmaz", 1, null },
                    { 2, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ayse.kaya@arcelik.com", "Ayşe", new DateTime(2015, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kaya", 0, null },
                    { 3, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1978, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "mehmet.demir@turkcell.com.tr", "Mehmet", new DateTime(2008, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Demir", 1, null },
                    { 4, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "fatma.sahin@turkcell.com.tr", "Fatma", new DateTime(2018, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şahin", 0, null },
                    { 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1982, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "ali.ozturk@ulker.com.tr", "Ali", new DateTime(2012, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Öztürk", 1, null },
                    { 6, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "zeynep.aksoy@flypgs.com", "Zeynep", new DateTime(2016, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksoy", 0, null },
                    { 7, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1975, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "mustafa.celik@koc.com.tr", "Mustafa", new DateTime(2005, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çelik", 1, null }
                });

            migrationBuilder.InsertData(
                table: "LeaveRequests",
                columns: new[] { "Id", "CreatedAt", "EmployeeId", "EndDate", "LeaveType", "Reason", "StartDate", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Yıllık izin", new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Sağlık sorunu", new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Aile tatili", new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "LeaveRequests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
