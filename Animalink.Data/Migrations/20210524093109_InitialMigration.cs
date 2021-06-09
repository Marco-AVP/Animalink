using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animalink.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(255)", nullable: false),
                    Password = table.Column<string>(type: "varchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdminStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Statistic = table.Column<string>(type: "varchar(8000)", nullable: true),
                    StatisticType = table.Column<string>(type: "varchar(255)", nullable: true),
                    AdminId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    AnimalName = table.Column<string>(nullable: true),
                    Taxonomy = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Habitat = table.Column<string>(nullable: true),
                    IUCN = table.Column<string>(nullable: true),
                    IUCNAcronym = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeneralStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Statistic = table.Column<string>(type: "varchar(8000)", nullable: true),
                    StatisticType = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PartnerName = table.Column<string>(type: "varchar(255)", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true),
                    ImageReference = table.Column<string>(type: "varchar(1000)", nullable: true),
                    WebsiteURL = table.Column<string>(type: "varchar(255)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(type: "varchar(255)", nullable: true),
                    ImageReference = table.Column<string>(type: "varchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserStatistics",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Statistic = table.Column<string>(type: "varchar(8000)", nullable: true),
                    StatisticType = table.Column<string>(type: "varchar(255)", nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserStatistics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NftTemplates",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    PublishedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(type: "varchar(255)", nullable: true),
                    Description = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Collection = table.Column<string>(type: "varchar(255)", nullable: true),
                    Schema = table.Column<string>(type: "varchar(255)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    MaxSupply = table.Column<int>(nullable: false),
                    ImageReference = table.Column<string>(type: "varchar(1000)", nullable: true),
                    IsTransferable = table.Column<bool>(nullable: false),
                    IsBurnable = table.Column<bool>(nullable: false),
                    NumberAvailable = table.Column<int>(nullable: false),
                    NftType = table.Column<string>(type: "varchar(255)", nullable: true),
                    Rarity = table.Column<string>(type: "varchar(255)", nullable: true),
                    RarityLevel = table.Column<int>(nullable: true),
                    AnimalId = table.Column<Guid>(nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    NftName = table.Column<string>(type: "varchar(255)", nullable: true),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    SoldBy = table.Column<decimal>(type: "decimal(18,8)", nullable: false),
                    MintNumber = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    NftTemplateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sales_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "Password", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { new Guid("e68353ea-91fb-4a2e-b29e-b75c10defa4f"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(3110), false, "123456", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(3106), "Admin1" },
                    { new Guid("27ec8ca0-d392-418a-958b-082205ad701e"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(4285), false, "1!_X+*´~ _", new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(4280), "Admin2" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "AnimalName", "CreatedAt", "Habitat", "IUCN", "IUCNAcronym", "IsDeleted", "Species", "Taxonomy", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("8ac63722-756c-4822-90a1-75c5a2fd2a30"), "Iberian Lynx", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2911), "Iberian Peninsula", "Critically Endangered", "CR", false, "Lynx pardinus", "Animal, Mammal, Lynx", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2910) },
                    { new Guid("41678cf9-bb3b-4a9f-976e-33b57a3af390"), "Golden Eagle", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2903), "Philipines", "Least Concerned", "LC", false, "Apanea Ittis", "Animal, Bird, Eagle", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2902) },
                    { new Guid("87759b7e-f2cc-44eb-a87d-98de9b5bd087"), "Tropical Frog", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2829), "Bolivia", "Vulnerable", "VU", false, "Bolivian Tree Frog", "Animal, Amphibian, Frog", new DateTime(2021, 5, 24, 9, 31, 9, 372, DateTimeKind.Utc).AddTicks(2814) },
                    { new Guid("a76492d7-f83b-465f-bbd6-de0338a284ab"), "Tiger", new DateTime(2021, 5, 24, 9, 31, 9, 371, DateTimeKind.Utc).AddTicks(8682), "Sumatra", "Endangered", "EN", false, "Panthera tigris sumatrae", "Animal, Mammal, Tiger", new DateTime(2021, 5, 24, 9, 31, 9, 371, DateTimeKind.Utc).AddTicks(7980) }
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
                    { new Guid("59ac08c7-e2ab-4804-ba0a-68cae6373490"), new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(8670), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 375, DateTimeKind.Utc).AddTicks(8665), "User1" },
                    { new Guid("93ce26a3-6e6e-4349-988c-24eb83649e8f"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(299), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(294), "User2" },
                    { new Guid("5909d779-a81a-4041-8570-c02f4d43c285"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(326), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(325), "User3" },
                    { new Guid("4c2f9a94-68bc-4f2f-a238-cb9a63c6a259"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(330), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(329), "User4" },
                    { new Guid("fd225a0f-4d78-4e98-b24c-7e3a35d3c967"), new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(333), "image link", false, new DateTime(2021, 5, 24, 9, 31, 9, 376, DateTimeKind.Utc).AddTicks(332), "User5" }
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

            migrationBuilder.CreateIndex(
                name: "IX_Sales_UserId",
                table: "Sales",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AdminStatistics");

            migrationBuilder.DropTable(
                name: "GeneralStatistics");

            migrationBuilder.DropTable(
                name: "NftTemplates");

            migrationBuilder.DropTable(
                name: "Partners");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "UserStatistics");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
