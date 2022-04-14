using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RihalChallenge.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    class_name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Class_id = table.Column<int>(type: "INTEGER", nullable: false),
                    Country_id = table.Column<int>(type: "INTEGER", nullable: false),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    Date_of_birth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 1, "Dot.Net" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 2, "AI" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 3, "ML" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 4, "Laravel" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "class_name" },
                values: new object[] { 5, "Game Development" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Qatar" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "UAE" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Kuwait" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Oman" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "KSA" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 64, 1, 1, new DateTime(1993, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Nelle Marquardt" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 72, 4, 5, new DateTime(1947, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Lonnie Pacocha" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 71, 5, 2, new DateTime(2004, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Wilton Schmeler" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 70, 5, 5, new DateTime(1970, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Zechariah Lubowitz" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 69, 3, 5, new DateTime(1960, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Reid Judd Lang II" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 68, 3, 4, new DateTime(2007, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Chauncey Block" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 67, 4, 3, new DateTime(1951, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Alden White" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 66, 1, 3, new DateTime(1937, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Kylee Elouise Schiller DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 65, 4, 1, new DateTime(1952, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Jeramy Goodwin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 63, 4, 4, new DateTime(1949, 5, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Gudrun Schiller" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 58, 1, 3, new DateTime(1954, 9, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Antwon Jones" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 61, 5, 5, new DateTime(1948, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Patrick Wiza PhD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 60, 1, 5, new DateTime(1976, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Jessyca Herzog" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 59, 5, 1, new DateTime(1987, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Justina Paucek" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 73, 2, 2, new DateTime(2008, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Lorenz Beahan" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 57, 4, 5, new DateTime(2008, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Pedro Braun" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 56, 1, 2, new DateTime(1922, 7, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Mr. Don Bins DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 55, 4, 4, new DateTime(2005, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Fred Bartell" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 54, 4, 2, new DateTime(2015, 7, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Maymie Dickinson" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 53, 3, 1, new DateTime(1978, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Tobin Dayton Lubowitz PhD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 52, 1, 5, new DateTime(1950, 7, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Willy O'Keefe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 62, 2, 2, new DateTime(1985, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Prof. Jerod Adams PhD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 74, 2, 3, new DateTime(1959, 7, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Shaylee Vandervort" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 79, 2, 5, new DateTime(1940, 2, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Prof. Damon Prosacco" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 76, 2, 5, new DateTime(1914, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Prof. Theresa Metz DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 98, 4, 1, new DateTime(2019, 4, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Sylvester Kovacek" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 97, 5, 4, new DateTime(1960, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Maud Johnson Smith Sr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 96, 2, 1, new DateTime(2018, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Dagmar O'Kon" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 95, 1, 2, new DateTime(1997, 10, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Kylee Marianna Romaguera I" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 94, 5, 2, new DateTime(1911, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Olin Cooper Mosciski III" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 93, 3, 1, new DateTime(1962, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Vivien McClure" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 92, 1, 3, new DateTime(1976, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Benny Murazik MD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 91, 3, 1, new DateTime(2013, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Zoe Rempel Jr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 90, 4, 4, new DateTime(1960, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Neva Paucek" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 89, 5, 1, new DateTime(1991, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Jaida Balistreri" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 75, 3, 4, new DateTime(1960, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Dr. Cleta Gusikowski" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 88, 5, 5, new DateTime(1960, 9, 29, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Ally Leanne Boehm V" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 86, 1, 1, new DateTime(1961, 8, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Norval Wintheiser" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 85, 3, 3, new DateTime(2006, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Ms. Cathryn Virgil Franecki" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 84, 4, 4, new DateTime(1975, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Quincy O'Connell" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 83, 4, 5, new DateTime(1960, 9, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Serena Hyatt" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 82, 1, 1, new DateTime(1969, 7, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Jamaal Wendy Wolf Sr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 81, 2, 4, new DateTime(2011, 10, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Nedra Kling II" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 80, 5, 3, new DateTime(1992, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Brody Kunze" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 51, 3, 5, new DateTime(1905, 8, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Dustin Kariane Schaefer III" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 78, 4, 2, new DateTime(1952, 9, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Casper McLaughlin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 77, 2, 4, new DateTime(1992, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Emilie Dach" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 87, 5, 5, new DateTime(1995, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Magali Beier" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 50, 5, 2, new DateTime(1989, 6, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Prof. Geovanni Vandervort" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 45, 4, 2, new DateTime(1966, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Leann Fadel" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 48, 4, 5, new DateTime(1974, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Elian Connelly" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 21, 2, 5, new DateTime(1930, 5, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Selina Gianni Volkman I" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 20, 5, 4, new DateTime(1991, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Makenna Thompson" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 19, 4, 5, new DateTime(1944, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Arlo Miles Crona III" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 18, 3, 4, new DateTime(2009, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Otilia Wiegand" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 17, 4, 3, new DateTime(1991, 9, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Halie Cassin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 16, 3, 1, new DateTime(2019, 3, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Alfonzo Kenny Konopelski Jr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 15, 3, 2, new DateTime(1986, 5, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Keven Grady DDS" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 14, 3, 5, new DateTime(1912, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Dean Lueilwitz V" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 13, 3, 4, new DateTime(1911, 2, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Mr. Annamarie Pierce Spencer III" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 12, 1, 2, new DateTime(1981, 8, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Ms. Rocky Amalia Quigley" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 11, 5, 3, new DateTime(1960, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Friedrich Cummerata" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 10, 3, 5, new DateTime(1960, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Marguerite Johann Mann PhD" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 9, 5, 3, new DateTime(1980, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Vicente Shanahan Jr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 8, 1, 3, new DateTime(1922, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Corrine Corene Emard" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 7, 3, 1, new DateTime(1962, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Selina Welch" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 6, 3, 2, new DateTime(1955, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Eric Yundt" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 5, 4, 1, new DateTime(1909, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Ashlynn Goldner" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 4, 1, 1, new DateTime(1990, 8, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Gisselle Cassin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 3, 3, 4, new DateTime(1996, 8, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Madelyn Smith" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 2, 4, 5, new DateTime(1903, 7, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Ms. Eriberto Dino Rath II" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 1, 3, 5, new DateTime(1909, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Florida Hodkiewicz" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 22, 1, 4, new DateTime(1925, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Mr. Isaias Casper" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 23, 4, 4, new DateTime(1916, 10, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Dr. Reanna Bogan" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 24, 3, 2, new DateTime(1990, 9, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Albertha Zemlak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 25, 5, 4, new DateTime(2006, 8, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Quincy Freddy Lesch DDS" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 47, 4, 1, new DateTime(1960, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Emma Schimmel IV" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 46, 5, 5, new DateTime(1929, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Mr. Daphney Fleta Boyer" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 99, 3, 4, new DateTime(1943, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Viola Howell" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 44, 3, 3, new DateTime(1943, 9, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Dr. Sophie Zemlak" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 43, 1, 2, new DateTime(1966, 2, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Eladio Runolfsson" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 42, 5, 5, new DateTime(1963, 9, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Camylle Jacobi" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 41, 1, 4, new DateTime(1945, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Jalon Kertzmann IV" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 40, 3, 5, new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Dr. Deanna Sam Trantow DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 39, 3, 4, new DateTime(1962, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Flavie Hoppe III" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 38, 1, 4, new DateTime(1925, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Cortez Murphy II" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 49, 2, 1, new DateTime(1984, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Tad Kirlin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 37, 1, 2, new DateTime(2014, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Catalina Opal Dach Sr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 35, 1, 2, new DateTime(1915, 2, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Jacynthe Dooley" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 34, 3, 3, new DateTime(1969, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Erna Geo Rice I" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 33, 4, 4, new DateTime(1998, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Sheridan Cassin" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 32, 4, 1, new DateTime(1960, 11, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Mauricio Fisher" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 31, 2, 2, new DateTime(1916, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Graciela Harvey" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 30, 2, 3, new DateTime(1915, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Rita Dooley" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 29, 3, 5, new DateTime(1940, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Miss Merlin Mia Wiza" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 28, 4, 2, new DateTime(1996, 10, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Ms. Tevin Frida Renner DVM" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 27, 1, 4, new DateTime(1929, 7, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Sid Fay" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 26, 2, 4, new DateTime(1982, 4, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Maurice Theresia Larkin Jr." });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 36, 3, 3, new DateTime(1946, 2, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Kendall Kautzer" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class_id", "Country_id", "Date_of_birth", "name" },
                values: new object[] { 100, 5, 1, new DateTime(1992, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Jean Bednar DDS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
