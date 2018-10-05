using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FC.Migrations
{
    public partial class FolderIDColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FolderId",
                table: "Texts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Texts_FolderId",
                table: "Texts",
                column: "FolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Texts_Folders_FolderId",
                table: "Texts",
                column: "FolderId",
                principalTable: "Folders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Texts_Folders_FolderId",
                table: "Texts");

            migrationBuilder.DropIndex(
                name: "IX_Texts_FolderId",
                table: "Texts");

            migrationBuilder.DropColumn(
                name: "FolderId",
                table: "Texts");
        }
    }
}
