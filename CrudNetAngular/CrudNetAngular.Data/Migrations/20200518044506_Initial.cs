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
                name: "Knowledge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Occupation", x => x.Id);
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
                    HourPrice = table.Column<decimal>(type: "decimal(7,2)", nullable: false),
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
                name: "TalentBaseXKnowledge",
                columns: table => new
                {
                    TalentBaseId = table.Column<Guid>(nullable: false),
                    KnowledgeId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentBaseXKnowledge", x => new { x.TalentBaseId, x.KnowledgeId });
                    table.ForeignKey(
                        name: "FK_TalentBaseXKnowledge_Knowledge_KnowledgeId",
                        column: x => x.KnowledgeId,
                        principalTable: "Knowledge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TalentBaseXKnowledge_TalentBase_TalentBaseId",
                        column: x => x.TalentBaseId,
                        principalTable: "TalentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalentBaseXOccupation",
                columns: table => new
                {
                    TalentBaseId = table.Column<Guid>(nullable: false),
                    OccupationId = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalentBaseXOccupation", x => new { x.TalentBaseId, x.OccupationId });
                    table.ForeignKey(
                        name: "FK_TalentBaseXOccupation_Occupation_OccupationId",
                        column: x => x.OccupationId,
                        principalTable: "Occupation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TalentBaseXOccupation_TalentBase_TalentBaseId",
                        column: x => x.TalentBaseId,
                        principalTable: "TalentBase",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Knowledge",
                columns: new[] { "Id", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("68cb2a70-a724-476c-84df-efb1de9f3a9a"), new DateTime(2020, 5, 18, 1, 45, 6, 213, DateTimeKind.Local).AddTicks(3980), "Ionic", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8cfa9b0-5b32-4b15-9de2-55ba4e2a267f"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6120), "Express - NodeJs", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25e438ae-6d5e-43d7-b279-6e81462ff527"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6123), "Cake", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da4259eb-0b8e-41ca-8b75-cc84086c4a24"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6130), "Majento", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14e4fc35-42e2-4edc-a8cb-3faf20ae74f4"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6132), "PHP", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf76668a-03c7-486a-9c76-1a6365a4497f"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6135), "Vue", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76eab6b1-1aec-4f83-bb35-26d155521443"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6137), "Wordpress", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6acee4d-79a6-4f96-aa4c-5c19bb764f5e"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6140), "Phyton", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d4c46ad-463c-472c-9144-dc7fd7536421"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6142), "Ruby", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f32731e6-c9f6-4c62-8a7a-6e38dae852af"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6144), "My SQL Server", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e997a11-00cf-4e58-b7e6-304465382c1d"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6146), "My SQL", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3260526-80bd-4e66-bfb2-15d8e559e663"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6151), "Salesforce", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db1b1b86-18d8-43d6-8068-9900d0a49158"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6164), "Photoshop", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a81f204b-52d9-4e3d-b1f4-26dd50db334f"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6166), "Illustrator", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25e5d096-6949-4d36-a0f6-20d7b340d65c"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6169), "SEO", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06d7fd7c-6f4c-44ae-ab8a-4f9f43fa7a17"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6171), "Laravel", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9da390c4-0a5d-4e76-8272-e159b807d462"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6118), "NodeJS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a69721d-0013-45ab-a5d6-d058e9d52798"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6116), "C#", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fffcbc26-c2a4-42f2-82f5-fb1679b6bc6f"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6125), "Django", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bec3c23d-5e03-4537-8649-0beec51c640a"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6111), "Asp.Net WebForm", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("febb2742-2a1e-452a-ab4e-76940fd3c4eb"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(5819), "ReactJS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("942e7cd0-d0c3-4f73-b346-f1d272037975"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(5858), "React Native", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fd0203a-f6f0-4686-9f2b-0c7cb68ac410"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(5862), "Android", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63dbd2d7-6450-40ab-9d03-416058ee4936"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6061), "Flutter", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f547101-64c2-44c6-a5ea-ca79f5d524d0"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6113), "C", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2efad335-9f6c-43af-90bd-0c8963cb3e3e"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6071), "IOS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f447cd2-f2a6-4687-ad03-9731ab96c30f"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6073), "HTML", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1db3f042-1314-4d11-8268-3853015d9489"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6084), "CSS", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74f97f1c-4f06-4940-becb-de4351de2bd7"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6069), "SWIFT", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8993606-005d-4c2b-8124-aeb686299898"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6091), "Jquery", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4ccaaf6-9155-4289-9595-16e9f4d7a70d"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6093), "AngularJs 1.*", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e944f3b-0de4-4466-abde-24871c5a67dd"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6096), "Angular", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2d2f3bb-a5b4-40fd-aeb3-a57a6906a619"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6098), "Java", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8365fce6-7dfd-4cdd-98ac-fbcafd888593"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6100), "Python", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3942580a-6bdf-4038-9e56-e6ff86cdb034"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6102), "Flask", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9b0f5d4-fef5-4b5d-8cb4-2461deeb7784"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6107), "Asp.Net MVC", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b30cc40-461f-4877-965b-aa1f5e5884de"), new DateTime(2020, 5, 18, 1, 45, 6, 214, DateTimeKind.Local).AddTicks(6089), "Bootstrap", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Occupation",
                columns: new[] { "Id", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("08ec925b-d649-4b45-9022-4bc7c1f2a6ad"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8324), "Night (7:00 p.m. to 10:00 p.m.) /Noite (de 19:00 as 22:00)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc769a13-e07f-4324-9ed9-7cf109b96c97"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8321), "Afternoon (from 1:00 p.m. to 6:00 p.m.) / Tarde (de 13:00 ás 18:00)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ff59221-2b8e-4bfd-ad45-742246eb6453"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8319), "Morning (from 08:00 to 12:00) / Manhã (de 08:00 ás 12:00)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d70cd70c-5645-4387-be36-6332ffbe2ab7"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8313), "Only weekends / Apenas finais de semana", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7394617b-ec6b-43b5-8563-a3bf74c1f310"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8215), "Up to 4 hours per day / Até 4 horas por dia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe7caee7-3d22-4ef0-bbbd-87dfdf9c4a07"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8299), "6 to 8 hours per day /De 6 á 8 horas por dia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ab1820a-eb38-47c9-97b9-8568ac0dca43"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8296), "4 to 6 hours per day / De 4 á 6 horas por dia", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b97452d-8c75-43eb-9836-09cb63a2cd24"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8326), "Dawn (from 10 p.m. onwards) / Madrugada (de 22:00 em diante)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("454a718f-0455-4f1a-baec-2d05f3079d5f"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8310), "Up to 8 hours a day (are you sure?) / Acima de 8 horas por dia (tem certeza?)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c105615-9743-4f31-9fae-9221ced4a02f"), new DateTime(2020, 5, 18, 1, 45, 6, 216, DateTimeKind.Local).AddTicks(8330), "Business (from 08:00 a.m. to 06:00 p.m.) / Comercial (de 08:00 as 18:00)", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TalentBase_DeveloperId",
                table: "TalentBase",
                column: "DeveloperId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBaseXKnowledge_KnowledgeId",
                table: "TalentBaseXKnowledge",
                column: "KnowledgeId");

            migrationBuilder.CreateIndex(
                name: "IX_TalentBaseXOccupation_OccupationId",
                table: "TalentBaseXOccupation",
                column: "OccupationId");
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
