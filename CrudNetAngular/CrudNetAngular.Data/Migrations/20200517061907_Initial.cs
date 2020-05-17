using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudNetAngular.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Developer",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Linkedin = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Portfolio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Developer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TalentBase",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    KnowledgePlus = table.Column<string>(nullable: true),
                    CrudLink = table.Column<string>(nullable: true),
                    HourPrice = table.Column<decimal>(nullable: false),
                    DeveloperId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentBase", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentBase_Developer_DeveloperId",
                        column: x => x.DeveloperId,
                        principalTable: "Developer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TalentBaseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knowledge_TalentBase_TalentBaseId",
                        column: x => x.TalentBaseId,
                        principalTable: "TalentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TalentBaseId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Occupation_TalentBase_TalentBaseId",
                        column: x => x.TalentBaseId,
                        principalTable: "TalentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TalentBaseXKnowledge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    TalentBaseId = table.Column<Guid>(nullable: true),
                    KnowledgeId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentBaseXKnowledge", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentBaseXKnowledge_Knowledge_KnowledgeId",
                        column: x => x.KnowledgeId,
                        principalTable: "Knowledge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TalentBaseXKnowledge_TalentBase_TalentBaseId",
                        column: x => x.TalentBaseId,
                        principalTable: "TalentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TalentBaseXOccupation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    TalentBaseId = table.Column<Guid>(nullable: true),
                    OccupationId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentBaseXOccupation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TalentBaseXOccupation_Occupation_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TalentBaseXOccupation_TalentBase_TalentBaseId",
                        column: x => x.TalentBaseId,
                        principalTable: "TalentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Knowledge",
                columns: new[] { "Id", "CreatedAt", "Description", "TalentBaseId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("59fd53f5-cf8b-41e1-98a4-93c72d69d4f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ionic", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d13eb001-de7b-4d81-8b65-91f822396f77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Express - NodeJs", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c761d70c-7d31-4425-9ac5-3dbaf64749bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cake", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36782414-7a19-45c2-8452-2a3b0d9f8de1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Majento", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a342b4f-472a-4ac8-931a-056af377ecc1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PHP", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("402b6e5b-e9bc-42b4-b860-db1bf94a42f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Vue", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa78b972-e59c-4eab-80a3-b9b302137d68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wordpress", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e27c1901-9b48-4a6c-b15e-796d132856f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phyton", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b39f8e24-94f0-4f23-a88f-7f37bfada167"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ruby", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f84ce9a-8b8e-4ce5-8585-8b2b86b5e227"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My SQL Server", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c033c37e-2be8-4960-8054-6707d2fa6a9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My SQL", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8468382f-d5cf-4ced-9780-6daa5f984331"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Salesforce", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f31c0aa9-0120-4b27-9123-4e64c8311dfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Photoshop", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("523a8761-53ca-4c6b-8ab3-66e34ce4e4ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Illustrator", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0b28378-7368-4a78-94a2-7abc0673d8ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SEO", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22b7e26a-08de-486d-8c20-f1b1ddbef036"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laravel", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97622c9b-76f3-40a3-a79a-749e6836bfbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NodeJS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ea3abbb-f510-443d-8fbd-d96b08a1523c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C#", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88a68261-a77c-4d68-9da5-5533114dd6f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Django", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68ed6c58-903f-4c69-956c-6416645ca7ce"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net WebForm", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("343c833b-2404-421d-ba0d-55b2f70f8d05"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "ReactJS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1fc5a53-d0e1-4009-983c-a5b927c8f5d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "React Native", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1a44ae5-3369-44ba-a82e-2782f1624f90"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Android", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4a605b2-064a-4adf-b6fd-45e614da4634"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flutter", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0fbb7eb2-e258-4115-81c4-e3ae13c1a9e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "C", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8536425-20fa-4fdf-b09b-99f09ee8e6d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IOS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eca986d8-158f-4271-9178-210911e2bb8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HTML", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("506ed717-64b0-498a-bb61-141840088c68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CSS", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3ac363a-edd0-4d9b-b0b7-26ac1d54a85d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "SWIFT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bbbbe44-cae7-489e-8822-4d5703038848"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jquery", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d879b3b9-335b-4eea-a76a-13ddcb127107"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AngularJs 1.*", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce3af568-d43b-4a46-b8a9-dbb24c607e5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angular", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9dea63cb-f785-4290-9981-1b7071d2fa53"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Java", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7969bdb0-ea54-4b44-ac7c-fa7ed482617e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Python", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c07bdc7-01e2-45a5-92ce-2fa324bf078f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Flask", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bee36e42-2dc3-4794-95d0-ac0d41e37407"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Asp.Net MVC", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c158d043-0890-479c-927a-ee55d3da777f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bootstrap", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Occupation",
                columns: new[] { "Id", "CreatedAt", "Description", "TalentBaseId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("182738ed-08d7-47b7-bb0e-bfc794c99ea1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Night (7:00 p.m. to 10:00 p.m.) /Noite (de 19:00 as 22:00)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3b40083-46f9-48f8-a5ef-4b861fa65913"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b83b03d2-0dca-4304-bd92-524eca1fe488"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f45d02d-b492-4a03-a362-8e8660b47c7d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Only weekends / Apenas finais de semana", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9a2aaa3-bf7e-48aa-b5a7-1fe2f8ab935d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up to 4 hours per day / Até 4 horas por dia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7902ba7e-9d77-4d93-ada2-7dac773c0188"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "6 to 8 hours per day /De 6 á 8 horas por dia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37fef117-8342-4d14-bb6e-ea16b5aa9742"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "4 to 6 hours per day / De 4 á 6 horas por dia", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a74229ef-22d7-49bb-be1a-2a88b13fd6e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("927f5b33-30cb-4b88-a846-8c5cba695dea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dfb4900-fdbd-4fb3-bc7f-f3b8d9e12dbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Knowledge_TalentBaseId",
                table: "Knowledge",
                column: "TalentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Occupation_TalentBaseId",
                table: "Occupation",
                column: "TalentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBase_DeveloperId",
                table: "TalentBase",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBaseXKnowledge_KnowledgeId",
                table: "TalentBaseXKnowledge",
                column: "KnowledgeId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBaseXKnowledge_TalentBaseId",
                table: "TalentBaseXKnowledge",
                column: "TalentBaseId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBaseXOccupation_OccupationId",
                table: "TalentBaseXOccupation",
                column: "OccupationId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBaseXOccupation_TalentBaseId",
                table: "TalentBaseXOccupation",
                column: "TalentBaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TalentBaseXKnowledge");

            migrationBuilder.DropTable(
                name: "TalentBaseXOccupation");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DropTable(
                name: "Occupation");

            migrationBuilder.DropTable(
                name: "TalentBase");

            migrationBuilder.DropTable(
                name: "Developer");
        }
    }
}
