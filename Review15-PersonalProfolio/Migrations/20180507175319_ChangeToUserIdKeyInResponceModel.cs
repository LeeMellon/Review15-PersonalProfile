using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Review15PersonalProfolio.Migrations
{
    public partial class ChangeToUserIdKeyInResponceModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responces_AspNetUsers_UserId1",
                table: "Responces");

            migrationBuilder.DropIndex(
                name: "IX_Responces_UserId1",
                table: "Responces");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Responces");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Responces",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Responces_UserId",
                table: "Responces",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Responces_AspNetUsers_UserId",
                table: "Responces",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responces_AspNetUsers_UserId",
                table: "Responces");

            migrationBuilder.DropIndex(
                name: "IX_Responces_UserId",
                table: "Responces");

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Responces",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Responces",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responces_UserId1",
                table: "Responces",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Responces_AspNetUsers_UserId1",
                table: "Responces",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
