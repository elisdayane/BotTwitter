using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TwitterBot.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TweetsInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTwiter = table.Column<long>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    FullText = table.Column<string>(maxLength: 250, nullable: true),
                    UserId = table.Column<long>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    UserFollowersCount = table.Column<long>(nullable: true),
                    url = table.Column<string>(maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TweetsInfo", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TweetsInfo");
        }
    }
}
