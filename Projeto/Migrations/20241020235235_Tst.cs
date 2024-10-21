using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto.Migrations
{
    /// <inheritdoc />
    public partial class Tst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Adotantes");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Adotantes");

            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Abrigos");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Abrigos");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Animais",
                newName: "AnimalId");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "Adotantes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Adotantes",
                newName: "AdotanteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Adocoes",
                newName: "AdocaoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Abrigos",
                newName: "AbrigoId");

            migrationBuilder.AlterColumn<string>(
                name: "Raca",
                table: "Animais",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Animais",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Especie",
                table: "Animais",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Adotantes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Adocoes",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAdocao",
                table: "Adocoes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Abrigos",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Localizacao",
                table: "Abrigos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAdocao",
                table: "Adocoes");

            migrationBuilder.DropColumn(
                name: "Localizacao",
                table: "Abrigos");

            migrationBuilder.RenameColumn(
                name: "AnimalId",
                table: "Animais",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Adotantes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "AdotanteId",
                table: "Adotantes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AdocaoId",
                table: "Adocoes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AbrigoId",
                table: "Abrigos",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Raca",
                table: "Animais",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Animais",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Especie",
                table: "Animais",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Adotantes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Adotantes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Adotantes",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Adocoes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Abrigos",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Abrigos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Abrigos",
                type: "TEXT",
                nullable: true);
        }
    }
}
