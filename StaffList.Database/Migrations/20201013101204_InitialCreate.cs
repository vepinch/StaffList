using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StaffList.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MaternityLeave = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Birthday", "Description", "FullName", "MaternityLeave", "Position" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Иванов Иван Иванович", false, "Инженер" },
                    { 2, new DateTime(1981, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Иванова Инна Ивановна", true, "Инженер" },
                    { 3, new DateTime(1981, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Петров Петр Петрович", true, "Инженер" },
                    { 4, new DateTime(1981, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Петрова Полина Петровна", false, "Инженер" },
                    { 5, new DateTime(1981, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Егоров Устин Евсеевич", false, "Старший инженер" },
                    { 6, new DateTime(1981, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Морозова Аурелия Георгиевна", true, "Старший инженер" },
                    { 7, new DateTime(1981, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Наумов Модест Лаврентьевич", true, "Старший инженер" },
                    { 8, new DateTime(1981, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Шестакова Кира Митрофановна", true, "Старший инженер" },
                    { 9, new DateTime(1981, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Жуков Альберт Германнович", false, "Ведущий инженер" },
                    { 10, new DateTime(1981, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "description", "Гусева Наталья Арсеньевна", true, "Ведущий инженер" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
