using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animalink.Data.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NftTemplates");

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("098eca0d-9284-4384-8633-59eb8c4169ac"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("38c185a7-fe3c-4de7-8409-4cf04d0463f7"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("5c237644-fff5-457d-b15f-f92f37fe855a"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("60da0227-dd8e-446a-b294-8a6de324c510"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("65e3ce19-4ceb-45bd-8cf1-2244ae50c6b4"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("93e801c5-2260-4440-8dbe-d4e3c041780b"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("ccfafa89-ed9c-4890-bce5-d61c4e393ea4"));

            migrationBuilder.DeleteData(
                table: "AdminStatistics",
                keyColumn: "Id",
                keyValue: new Guid("e2dd3214-a9e8-4be7-927c-a69e1907487f"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("27ec8ca0-d392-418a-958b-082205ad701e"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("41678cf9-bb3b-4a9f-976e-33b57a3af390"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("87759b7e-f2cc-44eb-a87d-98de9b5bd087"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("8ac63722-756c-4822-90a1-75c5a2fd2a30"));

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "Id",
                keyValue: new Guid("a76492d7-f83b-465f-bbd6-de0338a284ab"));

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: new Guid("5047731f-db7b-4af2-b423-1098380115a3"));

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: new Guid("57cddcaf-c4ee-4a6c-82ef-db5f0eb108ce"));

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "Id",
                keyValue: new Guid("b4c2b214-2f0b-4b75-ae48-32185dd6a215"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4c2f9a94-68bc-4f2f-a238-cb9a63c6a259"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5909d779-a81a-4041-8570-c02f4d43c285"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59ac08c7-e2ab-4804-ba0a-68cae6373490"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93ce26a3-6e6e-4349-988c-24eb83649e8f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fd225a0f-4d78-4e98-b24c-7e3a35d3c967"));

            migrationBuilder.DropColumn(
                name: "NftTemplateId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "AnimalName",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "NftName",
                table: "Sales",
                newName: "TemplateName");

            migrationBuilder.RenameColumn(
                name: "PartnerName",
                table: "Partners",
                newName: "Name");

            migrationBuilder.AddColumn<Guid>(
                name: "TemplateId",
                table: "Sales",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Taxonomy",
                table: "Animals",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Animals",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IUCNAcronym",
                table: "Animals",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IUCN",
                table: "Animals",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Habitat",
                table: "Animals",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Animals",
                type: "varchar(255)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Collections",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rarities",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rarities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schemas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true),
                    AtomicAssetsId = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    MaxSupply = table.Column<int>(nullable: false),
                    ImageReference = table.Column<string>(type: "varchar(1000)", nullable: true),
                    IsTransferable = table.Column<bool>(nullable: false),
                    IsBurnable = table.Column<bool>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: true),
                    PublishedAt = table.Column<DateTime>(nullable: true),
                    NumberAvailable = table.Column<int>(nullable: true),
                    AnimalId = table.Column<Guid>(nullable: true),
                    TemplateTypeId = table.Column<Guid>(nullable: false),
                    RarityId = table.Column<Guid>(nullable: false),
                    SchemaId = table.Column<Guid>(nullable: false),
                    CollectionId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Templates_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Templates_Collections_CollectionId",
                        column: x => x.CollectionId,
                        principalTable: "Collections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Templates_Rarities_RarityId",
                        column: x => x.RarityId,
                        principalTable: "Rarities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Templates_Schemas_SchemaId",
                        column: x => x.SchemaId,
                        principalTable: "Schemas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Templates_TemplateTypes_TemplateTypeId",
                        column: x => x.TemplateTypeId,
                        principalTable: "TemplateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 7, 2, 8, 4, 51, 417, DateTimeKind.Utc).AddTicks(3657), new DateTime(2021, 7, 2, 8, 4, 51, 417, DateTimeKind.Utc).AddTicks(2947) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "ImageReference", "IsDeleted", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("8968e2cb-fd82-4035-8ff1-9bd9abe691e7"), new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(4917), "image link", false, new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(4879), "User1" },
                    { new Guid("5cf1be60-cefd-49e5-9739-a6fa3d269117"), new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6071), "image link", false, new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6067), "User2" },
                    { new Guid("80b79f7b-2d74-4838-9475-301389533336"), new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6089), "image link", false, new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6088), "User3" },
                    { new Guid("0fbd6c03-1bd3-402d-8bd4-48425237d061"), new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6092), "image link", false, new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6091), "User4" },
                    { new Guid("687a2177-ba49-48e6-af1d-267544d6dfba"), new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6095), "image link", false, new DateTime(2021, 7, 2, 8, 4, 51, 419, DateTimeKind.Utc).AddTicks(6094), "User5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_AnimalId",
                table: "Templates",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_CollectionId",
                table: "Templates",
                column: "CollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_RarityId",
                table: "Templates",
                column: "RarityId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_SchemaId",
                table: "Templates",
                column: "SchemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_TemplateTypeId",
                table: "Templates",
                column: "TemplateTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Collections");

            migrationBuilder.DropTable(
                name: "Rarities");

            migrationBuilder.DropTable(
                name: "Schemas");

            migrationBuilder.DropTable(
                name: "TemplateTypes");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0fbd6c03-1bd3-402d-8bd4-48425237d061"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5cf1be60-cefd-49e5-9739-a6fa3d269117"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("687a2177-ba49-48e6-af1d-267544d6dfba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("80b79f7b-2d74-4838-9475-301389533336"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8968e2cb-fd82-4035-8ff1-9bd9abe691e7"));

            migrationBuilder.DropColumn(
                name: "TemplateId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Animals");

            migrationBuilder.RenameColumn(
                name: "TemplateName",
                table: "Sales",
                newName: "NftName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Partners",
                newName: "PartnerName");

            migrationBuilder.AddColumn<Guid>(
                name: "NftTemplateId",
                table: "Sales",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Taxonomy",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Species",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IUCNAcronym",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IUCN",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Habitat",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AnimalName",
                table: "Animals",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NftTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimalId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Collection = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true),
                    ImageReference = table.Column<string>(type: "varchar(1000)", nullable: true),
                    IsBurnable = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    IsTransferable = table.Column<bool>(type: "bit", nullable: false),
                    MaxSupply = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    NftType = table.Column<string>(type: "varchar(255)", nullable: true),
                    NumberAvailable = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    PublishedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rarity = table.Column<string>(type: "varchar(255)", nullable: true),
                    RarityLevel = table.Column<int>(type: "int", nullable: true),
                    Schema = table.Column<string>(type: "varchar(255)", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NftTemplates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NftTemplates_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AdminStatistics",
                columns: new[] { "Id", "AdminId", "CreatedAt", "IsDeleted", "Statistic", "StatisticType", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("38c185a7-fe3c-4de7-8409-4cf04d0463f7"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(5302), false, "", "Total Number of NFTs", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(5296) },
                    { new Guid("098eca0d-9284-4384-8633-59eb8c4169ac"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7402), false, "", "Total Number of NFTs Sold", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7397) },
                    { new Guid("ccfafa89-ed9c-4890-bce5-d61c4e393ea4"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7449), false, "", "Total Value Made", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7448) },
                    { new Guid("5c237644-fff5-457d-b15f-f92f37fe855a"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7455), false, "", "Total Number of Animals", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7454) },
                    { new Guid("e2dd3214-a9e8-4be7-927c-a69e1907487f"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7460), false, "", "Total Number of Species", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7459) },
                    { new Guid("93e801c5-2260-4440-8dbe-d4e3c041780b"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7464), false, "", "Total Value Donated", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7464) },
                    { new Guid("65e3ce19-4ceb-45bd-8cf1-2244ae50c6b4"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7469), false, "", "Value Donated by Partner", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7468) },
                    { new Guid("60da0227-dd8e-446a-b294-8a6de324c510"), new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7473), false, "", " Total Number of Users ", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(7472) }
                });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(3110), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Password", "UpdatedAt", "UserName" },
                values: new object[] { new Guid("27ec8ca0-d392-418a-958b-082205ad701e"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(4285), false, "1!_X+*´~ _", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(4280), "Admin2" });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalName", "CreatedAt", "Habitat", "IUCN", "IUCNAcronym", "IsDeleted", "Species", "Taxonomy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("87759b7e-f2cc-44eb-a87d-98de9b5bd087"), "Tropical Frog", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2829), "Bolivia", "Vulnerable", "VU", false, "Bolivian Tree Frog", "Animal, Amphibian, Frog", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2814) },
                    { new Guid("8ac63722-756c-4822-90a1-75c5a2fd2a30"), "Iberian Lynx", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2911), "Iberian Peninsula", "Critically Endangered", "CR", false, "Lynx pardinus", "Animal, Mammal, Lynx", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2910) },
                    { new Guid("a76492d7-f83b-465f-bbd6-de0338a284ab"), "Tiger", new DateTime(2021, 5, 24, 9, 31, 9, 371, DateTimeKind.Utc).AddTicks(8682), "Sumatra", "Endangered", "EN", false, "Panthera tigris sumatrae", "Animal, Mammal, Tiger", new DateTime(2021, 5, 24, 9, 31, 9, 371, DateTimeKind.Utc).AddTicks(7980) },
                    { new Guid("41678cf9-bb3b-4a9f-976e-33b57a3af390"), "Golden Eagle", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2903), "Philipines", "Least Concerned", "LC", false, "Apanea Ittis", "Animal, Bird, Eagle", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2902) }
                });

            migrationBuilder.InsertData(
                table: "NftTemplates",
                columns: new[] { "Id", "AnimalId", "Collection", "CreatedAt", "Description", "ImageReference", "IsBurnable", "IsDeleted", "IsPublished", "IsTransferable", "MaxSupply", "Name", "NftType", "NumberAvailable", "Price", "PublishedAt", "Rarity", "RarityLevel", "Schema", "UpdatedAt" },
                values: new object[] { new Guid("c7e4da3a-f992-476e-a201-5cfe078c63d7"), null, "Animalink", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8735), "Celebrate Earth Day", "www.website.com", false, false, false, true, 5, "Earth Day", "Event", 28, 120m, new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8736), "Special", null, "Events", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8734) });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageReference", "IsDeleted", "PartnerName", "UpdatedAt", "WebsiteURL" },
                values: new object[,]
                {
                    { new Guid("5047731f-db7b-4af2-b423-1098380115a3"), new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(9735), "A description of the place in question", "link to the Partner logo", false, "Zoo de Guarulhos, Brasil", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(9729), "www.site.com" },
                    { new Guid("57cddcaf-c4ee-4a6c-82ef-db5f0eb108ce"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(2158), "A description of the place in question", "link to the Partner logo", false, "Borneo Orangutan Rescue", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(2153), "www.site.com" },
                    { new Guid("b4c2b214-2f0b-4b75-ae48-32185dd6a215"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(2191), "A description of the place in question", "link to the Partner logo", false, "Iberian Lynx Conservation", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(2190), "www.site.com" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "ImageReference", "IsDeleted", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("fd225a0f-4d78-4e98-b24c-7e3a35d3c967"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(333), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(332), "User5" },
                    { new Guid("59ac08c7-e2ab-4804-ba0a-68cae6373490"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(8670), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(8665), "User1" },
                    { new Guid("93ce26a3-6e6e-4349-988c-24eb83649e8f"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(299), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(294), "User2" },
                    { new Guid("5909d779-a81a-4041-8570-c02f4d43c285"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(326), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(325), "User3" },
                    { new Guid("4c2f9a94-68bc-4f2f-a238-cb9a63c6a259"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(330), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(329), "User4" }
                });

            migrationBuilder.InsertData(
                table: "NftTemplates",
                columns: new[] { "Id", "AnimalId", "Collection", "CreatedAt", "Description", "ImageReference", "IsBurnable", "IsDeleted", "IsPublished", "IsTransferable", "MaxSupply", "Name", "NftType", "NumberAvailable", "Price", "PublishedAt", "Rarity", "RarityLevel", "Schema", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("c85efa0e-3bae-4646-8024-76d75e3bd667"), new Guid("a76492d7-f83b-465f-bbd6-de0338a284ab"), "Animalink", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8702), "Its a tiger", "www.website.com", false, false, true, true, 10, "Sumatran Tiger", "Animal", 0, 99m, new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8704), "Super Rare", 4, "East Asia", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8701) },
                    { new Guid("effb4656-d469-4b2f-b28e-69918e61811f"), new Guid("87759b7e-f2cc-44eb-a87d-98de9b5bd087"), "Animalink", new DateTime(2021, 5, 24, 9, 31, 9, 373, DateTimeKind.Utc).AddTicks(8709), "Its a frog", "www.website.com", true, false, true, true, 400, "Tropical Frog", "Animal", 57, 25m, new DateTime(2021, 5, 24, 9, 31, 9, 373, DateTimeKind.Utc).AddTicks(9335), "Rare", 3, "South America", new DateTime(2021, 5, 24, 9, 31, 9, 373, DateTimeKind.Utc).AddTicks(8688) },
                    { new Guid("032ead6e-6558-4b1f-8023-602d2aaa81f4"), new Guid("41678cf9-bb3b-4a9f-976e-33b57a3af390"), "Animalink", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8463), "Its an eagle", "www.website.com", true, false, true, true, 1000, "Golden Eagle", "Animal", 250, 5m, new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8486), "Common", 1, "East Asia", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8457) },
                    { new Guid("da2b2abd-97c0-4dbb-9718-edf7a77e5b73"), new Guid("8ac63722-756c-4822-90a1-75c5a2fd2a30"), "Animalink", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8713), "Its a Lynx", "www.website.com", false, false, false, true, 5, "Iberian Lynx", "Animal", 7, 120m, new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8714), "Epic", 5, "European", new DateTime(2021, 5, 24, 9, 31, 9, 374, DateTimeKind.Utc).AddTicks(8712) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NftTemplates_AnimalId",
                table: "NftTemplates",
                column: "AnimalId");
        }
    }
}
