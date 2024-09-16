using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoardgameNight.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boardgames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPlayers = table.Column<int>(type: "int", nullable: false),
                    MaxPlayers = table.Column<int>(type: "int", nullable: false),
                    IsAdultOnly = table.Column<bool>(type: "bit", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boardgames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ContainsAlcohol = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsLactoseFree = table.Column<bool>(type: "bit", nullable: false),
                    IsNutFree = table.Column<bool>(type: "bit", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    HasLactoseAllergy = table.Column<bool>(type: "bit", nullable: false),
                    HasNutAllergy = table.Column<bool>(type: "bit", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    AvoidAlcohol = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoardgameNights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxPlayers = table.Column<int>(type: "int", nullable: false),
                    OrganizerId = table.Column<int>(type: "int", nullable: false),
                    IsPotluck = table.Column<bool>(type: "bit", nullable: false),
                    IsAdultsOnly = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgameNights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BoardgameNights_People_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Attendances",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    BoardgameNightId = table.Column<int>(type: "int", nullable: false),
                    HasAttended = table.Column<bool>(type: "bit", nullable: false),
                    BoardgameNightId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendances_BoardgameNights_BoardgameNightId",
                        column: x => x.BoardgameNightId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Attendances_BoardgameNights_BoardgameNightId1",
                        column: x => x.BoardgameNightId1,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attendances_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BoardgameBoardgameNight",
                columns: table => new
                {
                    BoardgameNightsId = table.Column<int>(type: "int", nullable: false),
                    BoardgamesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgameBoardgameNight", x => new { x.BoardgameNightsId, x.BoardgamesId });
                    table.ForeignKey(
                        name: "FK_BoardgameBoardgameNight_BoardgameNights_BoardgameNightsId",
                        column: x => x.BoardgameNightsId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardgameBoardgameNight_Boardgames_BoardgamesId",
                        column: x => x.BoardgamesId,
                        principalTable: "Boardgames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoardgameNightDrink",
                columns: table => new
                {
                    BoardgameNightsId = table.Column<int>(type: "int", nullable: false),
                    DrinkOptionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgameNightDrink", x => new { x.BoardgameNightsId, x.DrinkOptionsId });
                    table.ForeignKey(
                        name: "FK_BoardgameNightDrink_BoardgameNights_BoardgameNightsId",
                        column: x => x.BoardgameNightsId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardgameNightDrink_Drinks_DrinkOptionsId",
                        column: x => x.DrinkOptionsId,
                        principalTable: "Drinks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoardgameNightFood",
                columns: table => new
                {
                    BoardgameNightsId = table.Column<int>(type: "int", nullable: false),
                    FoodOptionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardgameNightFood", x => new { x.BoardgameNightsId, x.FoodOptionsId });
                    table.ForeignKey(
                        name: "FK_BoardgameNightFood_BoardgameNights_BoardgameNightsId",
                        column: x => x.BoardgameNightsId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardgameNightFood_Foods_FoodOptionsId",
                        column: x => x.FoodOptionsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PotluckItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BroughtById = table.Column<int>(type: "int", nullable: false),
                    BoardgameNightId = table.Column<int>(type: "int", nullable: false),
                    IsLactoseFree = table.Column<bool>(type: "bit", nullable: false),
                    IsNutFree = table.Column<bool>(type: "bit", nullable: false),
                    IsVegetarian = table.Column<bool>(type: "bit", nullable: false),
                    ContainsAlcohol = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PotluckItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PotluckItems_BoardgameNights_BoardgameNightId",
                        column: x => x.BoardgameNightId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PotluckItems_People_BroughtById",
                        column: x => x.BroughtById,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewerId = table.Column<int>(type: "int", nullable: false),
                    BoardgameNightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_BoardgameNights_BoardgameNightId",
                        column: x => x.BoardgameNightId,
                        principalTable: "BoardgameNights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_People_ReviewerId",
                        column: x => x.ReviewerId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_BoardgameNightId",
                table: "Attendances",
                column: "BoardgameNightId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_BoardgameNightId1",
                table: "Attendances",
                column: "BoardgameNightId1");

            migrationBuilder.CreateIndex(
                name: "IX_Attendances_PersonId",
                table: "Attendances",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_BoardgameBoardgameNight_BoardgamesId",
                table: "BoardgameBoardgameNight",
                column: "BoardgamesId");

            migrationBuilder.CreateIndex(
                name: "IX_BoardgameNightDrink_DrinkOptionsId",
                table: "BoardgameNightDrink",
                column: "DrinkOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_BoardgameNightFood_FoodOptionsId",
                table: "BoardgameNightFood",
                column: "FoodOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_BoardgameNights_OrganizerId",
                table: "BoardgameNights",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_PotluckItems_BoardgameNightId",
                table: "PotluckItems",
                column: "BoardgameNightId");

            migrationBuilder.CreateIndex(
                name: "IX_PotluckItems_BroughtById",
                table: "PotluckItems",
                column: "BroughtById");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BoardgameNightId",
                table: "Reviews",
                column: "BoardgameNightId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewerId",
                table: "Reviews",
                column: "ReviewerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendances");

            migrationBuilder.DropTable(
                name: "BoardgameBoardgameNight");

            migrationBuilder.DropTable(
                name: "BoardgameNightDrink");

            migrationBuilder.DropTable(
                name: "BoardgameNightFood");

            migrationBuilder.DropTable(
                name: "PotluckItems");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Boardgames");

            migrationBuilder.DropTable(
                name: "Drinks");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "BoardgameNights");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
