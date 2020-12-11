using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrailBlazinAPI.Migrations
{
    public partial class ReAddedPicPropToNatParkModelandNatParkDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "NationalParks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picture",
                table: "NationalParks");
        }
    }
}
