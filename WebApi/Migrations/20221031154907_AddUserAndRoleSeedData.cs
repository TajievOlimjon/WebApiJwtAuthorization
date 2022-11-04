using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddUserAndRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08e7e341-61bb-41ec-a419-e2fd8d42c380", "48973703-e57a-4e8b-afc0-f68bceb95981", "Business", "BUSINESS" },
                    { "5582d545-f8ac-48c2-8c69-927a1124961b", "860fb0d8-567a-43c8-b9b8-7a634c3c53c6", "Editor", "EDITOR" },
                    { "773e723b-225f-413d-b534-6b159f718875", "a37462ee-ac2f-48a8-8f5d-57df85a73630", "Seller", "SELLER" },
                    { "7f2ac4c5-734f-4490-84a8-9971c21a9132", "f1707968-0ada-488b-a448-f1e0bfebc3b7", "Owner", "OWNER" },
                    { "8de6be3a-dc7a-497a-ae23-4c8acb39adb4", "a9a89905-102c-4dd8-aa42-f27cc1e19372", "Subscriber", "SUBSCRIBER" },
                    { "c78fb03b-d522-49f9-b80e-45dda9a8fefe", "9c161432-2ee7-4e2f-83e0-d3e306d6ad8d", "Manager", "MANAGER" },
                    { "e336c35c-f87c-4f77-a7e0-f4117851e295", "85363095-ece7-4bcf-88bd-0c18ef41a18f", "Buyer", "BUYER" },
                    { "fa1774c4-5abd-48e9-a18c-0ffa7a83a765", "31e8948e-b966-4d4a-911c-377975f3de23", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07a97ae7-a329-4534-9795-455aaeda7b74", 0, "6084c81a-53fa-492b-9bfb-20fb694cb9d9", "tajiev0711@gmail.com", true, "Olimjon", "Tajiev", false, null, "Turamurodovich", null, "TAJIEVOLIMJON", "$2a$11$xAv19CuueSXGJURHLu6msuLcmDt/SoLtIFqMIkrb5mLzRKdcg1J96", "+992911288822", true, "a8d3acfa-46be-4d19-9d67-bc5b903bc3de", false, "TajievOlimjon" },
                    { "3add81f0-3a56-45ff-adbe-7930786080ef", 0, "0b719655-c441-43c6-a89b-86188e41dec8", "azam@gmail.com", true, "Azamjon", "Azamov", false, null, "Azamovich", null, "AZAMJON", "$2a$11$CQDryHBK9ukHegZboeQ/s.ggfh93Ut1Mie70EG8cG3sGjp7ft0gra", "+992988058310", true, "07b3c64a-1173-49f2-a549-727057c80239", false, "Azamjon" },
                    { "4502a71c-0341-4d70-a84d-3ba2eee49287", 0, "96136d23-793e-4951-9848-6be32951528c", "donior@gmail.com", true, "Donior", "Tajiev", false, null, "Ashpulatovich", null, "DONIOR", "$2a$11$EJEjybEXphECa6fCirWGQe4QpYSjF1RLBXelSO0XY4p/XU/Z79bUa", "+992988058317", true, "4240e8bf-fbc2-44b8-aeec-0535026abaf7", false, "Donior" },
                    { "591963f3-4778-49c2-a565-32ebe9e4bbe7", 0, "63438768-dfb1-4e50-88d7-215de2b4659f", "Aziz@gmail.com", true, "Azizbek", "Azizov", false, null, "Azizovich", null, "AZIZBEK", "$2a$11$iQk4Y8wUlDQrVnZ1CaQ5ge1kbbnPyvEP3yBA74p7S7.dRncKpB3Xe", "+992988058314", true, "6b7a7804-3baa-4a37-97b9-bb2aadc660e1", false, "Azizbek" },
                    { "849e3092-76eb-4ad3-a41c-1a6236543ba2", 0, "ab8e6648-fceb-46fe-a96a-f0e3c355c0b6", "akbar@gmail.com", true, "Akbar", "Alimirzoev", false, null, "Alievich", null, "AKBAR", "$2a$11$npZ3hjY/WUZ9mOukrnU4He6cLxScxH2ifT32Souq0T9N5ZWNgDgqu", "+992988058318", true, "a51e0052-a892-45de-bea0-34b6c6332fed", false, "Akbar" },
                    { "c2478fca-a65d-4e83-b377-7f5a06a89f19", 0, "05818863-b08f-42af-abc4-49cd12535012", "muhriddin@gmail.com", true, "Muhriddin", "Kalkanov", false, null, "Olimjonovich", null, "MUHRIDDIN", "$2a$11$2ZT2ysMnY9LjXZLNK6VcL.Ah5YJvq5McC9m16Z.chn500ovvwm4Fe", "+992988058313", true, "16e04046-af32-467a-a925-e9a524342bc3", false, "Muhriddin" },
                    { "cc7e0bf4-b58a-4352-93c9-aca3efbcbd32", 0, "6bdad6eb-8d22-45c2-ad2f-17b9f6b679db", "akram@gmail.com", true, "Akram", "Albekov", false, null, "Salimjonivich", null, "AKRAM ", "$2a$11$KllBVTaKnZWTFv2CdWK3tOn1xEx4hILR/TuljkIasEZOmvSHA2tge", "+992988058312", true, "72b2fecc-9308-42a3-af52-f2f18c5e3701", false, "Akram" },
                    { "e5776d2b-d5c6-4afd-968c-280d74a797c0", 0, "e19bcb3a-6b14-4eca-9914-0021244964be", "Akmal@gmail.com", true, "Akmal", "Agamberdiev", false, null, "Akmalovich", null, "AKMAL", "$2a$11$gFMR0YYKJEfjFxk9BRBRKuHY/P7d9jprUq1JWPAmmjKVXRKG1PASC", "+992988058315", true, "732031fa-f9a9-4328-9103-5c8f3f929db2", false, "Akmal" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c78fb03b-d522-49f9-b80e-45dda9a8fefe", "07a97ae7-a329-4534-9795-455aaeda7b74" },
                    { "7f2ac4c5-734f-4490-84a8-9971c21a9132", "3add81f0-3a56-45ff-adbe-7930786080ef" },
                    { "773e723b-225f-413d-b534-6b159f718875", "4502a71c-0341-4d70-a84d-3ba2eee49287" },
                    { "fa1774c4-5abd-48e9-a18c-0ffa7a83a765", "591963f3-4778-49c2-a565-32ebe9e4bbe7" },
                    { "8de6be3a-dc7a-497a-ae23-4c8acb39adb4", "849e3092-76eb-4ad3-a41c-1a6236543ba2" },
                    { "e336c35c-f87c-4f77-a7e0-f4117851e295", "c2478fca-a65d-4e83-b377-7f5a06a89f19" },
                    { "5582d545-f8ac-48c2-8c69-927a1124961b", "cc7e0bf4-b58a-4352-93c9-aca3efbcbd32" },
                    { "08e7e341-61bb-41ec-a419-e2fd8d42c380", "e5776d2b-d5c6-4afd-968c-280d74a797c0" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c78fb03b-d522-49f9-b80e-45dda9a8fefe", "07a97ae7-a329-4534-9795-455aaeda7b74" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7f2ac4c5-734f-4490-84a8-9971c21a9132", "3add81f0-3a56-45ff-adbe-7930786080ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "773e723b-225f-413d-b534-6b159f718875", "4502a71c-0341-4d70-a84d-3ba2eee49287" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa1774c4-5abd-48e9-a18c-0ffa7a83a765", "591963f3-4778-49c2-a565-32ebe9e4bbe7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8de6be3a-dc7a-497a-ae23-4c8acb39adb4", "849e3092-76eb-4ad3-a41c-1a6236543ba2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e336c35c-f87c-4f77-a7e0-f4117851e295", "c2478fca-a65d-4e83-b377-7f5a06a89f19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5582d545-f8ac-48c2-8c69-927a1124961b", "cc7e0bf4-b58a-4352-93c9-aca3efbcbd32" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08e7e341-61bb-41ec-a419-e2fd8d42c380", "e5776d2b-d5c6-4afd-968c-280d74a797c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08e7e341-61bb-41ec-a419-e2fd8d42c380");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5582d545-f8ac-48c2-8c69-927a1124961b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "773e723b-225f-413d-b534-6b159f718875");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f2ac4c5-734f-4490-84a8-9971c21a9132");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8de6be3a-dc7a-497a-ae23-4c8acb39adb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78fb03b-d522-49f9-b80e-45dda9a8fefe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e336c35c-f87c-4f77-a7e0-f4117851e295");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa1774c4-5abd-48e9-a18c-0ffa7a83a765");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07a97ae7-a329-4534-9795-455aaeda7b74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3add81f0-3a56-45ff-adbe-7930786080ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4502a71c-0341-4d70-a84d-3ba2eee49287");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "591963f3-4778-49c2-a565-32ebe9e4bbe7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "849e3092-76eb-4ad3-a41c-1a6236543ba2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2478fca-a65d-4e83-b377-7f5a06a89f19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc7e0bf4-b58a-4352-93c9-aca3efbcbd32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5776d2b-d5c6-4afd-968c-280d74a797c0");
        }
    }
}
