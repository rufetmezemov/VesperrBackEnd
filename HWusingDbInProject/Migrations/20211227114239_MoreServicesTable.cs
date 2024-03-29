﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace HWusingDbInProject.Migrations
{
    public partial class MoreServicesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoreServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleParameter = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Delay = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    CardText = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoreServices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoreServices");
        }
    }
}
