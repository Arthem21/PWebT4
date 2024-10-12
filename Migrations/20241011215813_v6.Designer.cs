﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace practica4.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20241011215813_v6")]
    partial class v6
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Multimedia", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("idioma")
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("pais")
                        .HasColumnType("TEXT");

                    b.Property<string>("resumen")
                        .HasColumnType("TEXT");

                    b.Property<int>("tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("multimedias");
                });

            modelBuilder.Entity("Personajes", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("apodo")
                        .HasColumnType("TEXT");

                    b.Property<int?>("edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("foto")
                        .HasColumnType("TEXT");

                    b.Property<string>("habilidad")
                        .HasColumnType("TEXT");

                    b.Property<string>("multimediaid")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("raza")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("multimediaid");

                    b.ToTable("personajes");
                });

            modelBuilder.Entity("Personajes", b =>
                {
                    b.HasOne("Multimedia", "multimedia")
                        .WithMany("personajes")
                        .HasForeignKey("multimediaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("multimedia");
                });

            modelBuilder.Entity("Multimedia", b =>
                {
                    b.Navigation("personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
