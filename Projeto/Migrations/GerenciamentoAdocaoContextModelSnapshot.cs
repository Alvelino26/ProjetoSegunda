﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto.Data;

#nullable disable

namespace Projeto.Migrations
{
    [DbContext(typeof(GerenciamentoAdocaoContext))]
    partial class GerenciamentoAdocaoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Projeto.Models.Abrigo", b =>
                {
                    b.Property<int>("AbrigoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Localizacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AbrigoId");

                    b.ToTable("Abrigos");
                });

            modelBuilder.Entity("Projeto.Models.Adocao", b =>
                {
                    b.Property<int>("AdocaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AdotanteId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataAdocao")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.HasKey("AdocaoId");

                    b.HasIndex("AdotanteId");

                    b.HasIndex("AnimalId");

                    b.ToTable("Adocoes");
                });

            modelBuilder.Entity("Projeto.Models.Adotante", b =>
                {
                    b.Property<int>("AdotanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AdotanteId");

                    b.ToTable("Adotantes");
                });

            modelBuilder.Entity("Projeto.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AbrigoId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("DisponivelParaAdocao")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AnimalId");

                    b.HasIndex("AbrigoId");

                    b.ToTable("Animais");
                });

            modelBuilder.Entity("Projeto.Models.Adocao", b =>
                {
                    b.HasOne("Projeto.Models.Adotante", "Adotante")
                        .WithMany("Adocoes")
                        .HasForeignKey("AdotanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projeto.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adotante");

                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Projeto.Models.Animal", b =>
                {
                    b.HasOne("Projeto.Models.Abrigo", "Abrigo")
                        .WithMany("Animais")
                        .HasForeignKey("AbrigoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Abrigo");
                });

            modelBuilder.Entity("Projeto.Models.Abrigo", b =>
                {
                    b.Navigation("Animais");
                });

            modelBuilder.Entity("Projeto.Models.Adotante", b =>
                {
                    b.Navigation("Adocoes");
                });
#pragma warning restore 612, 618
        }
    }
}
