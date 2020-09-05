using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreBooking.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    room_id = table.Column<string>(maxLength: 10, nullable: false),
                    room_name = table.Column<string>(maxLength: 50, nullable: false),
                    capacity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.room_id);
                });

            migrationBuilder.CreateTable(
                name: "User_s",
                columns: table => new
                {
                    User_id = table.Column<string>(maxLength: 10, nullable: false),
                    User_name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_s", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    booking_id = table.Column<string>(maxLength: 10, nullable: false),
                    booking_title = table.Column<string>(maxLength: 100, nullable: false),
                    start_time = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    end_time = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    participants = table.Column<string>(maxLength: 1000, nullable: true),
                    note = table.Column<string>(maxLength: 1000, nullable: true),
                    room_id = table.Column<string>(maxLength: 10, nullable: false),
                    users_id = table.Column<string>(maxLength: 10, nullable: false),
                    User_sUser_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.booking_id);
                    table.ForeignKey(
                        name: "FK_Booking_User_s_User_sUser_id",
                        column: x => x.User_sUser_id,
                        principalTable: "User_s",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Booking_Room_room_id",
                        column: x => x.room_id,
                        principalTable: "Room",
                        principalColumn: "room_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_User_sUser_id",
                table: "Booking",
                column: "User_sUser_id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_room_id",
                table: "Booking",
                column: "room_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "User_s");

            migrationBuilder.DropTable(
                name: "Room");
        }
    }
}
