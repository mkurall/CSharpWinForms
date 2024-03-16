﻿// <auto-generated />
using System;
using EFTest2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFTest2.Migrations
{
    [DbContext(typeof(OkulDbContext))]
    [Migration("20240316100026_KluplerEklendi2")]
    partial class KluplerEklendi2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFTest2.Models.Klup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Klupler");
                });

            modelBuilder.Entity("EFTest2.Models.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Nu")
                        .HasColumnType("int");

                    b.Property<int?>("SinifId")
                        .HasColumnType("int");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EFTest2.Models.Sinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int?>("Seviye")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("KlupOgrenci", b =>
                {
                    b.Property<int>("KluplerId")
                        .HasColumnType("int");

                    b.Property<int>("OgrencilerId")
                        .HasColumnType("int");

                    b.HasKey("KluplerId", "OgrencilerId");

                    b.HasIndex("OgrencilerId");

                    b.ToTable("KlupOgrenci");
                });

            modelBuilder.Entity("EFTest2.Models.Ogrenci", b =>
                {
                    b.HasOne("EFTest2.Models.Sinif", "Sinifi")
                        .WithMany("Ogrenciler")
                        .HasForeignKey("SinifId");

                    b.Navigation("Sinifi");
                });

            modelBuilder.Entity("KlupOgrenci", b =>
                {
                    b.HasOne("EFTest2.Models.Klup", null)
                        .WithMany()
                        .HasForeignKey("KluplerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFTest2.Models.Ogrenci", null)
                        .WithMany()
                        .HasForeignKey("OgrencilerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFTest2.Models.Sinif", b =>
                {
                    b.Navigation("Ogrenciler");
                });
#pragma warning restore 612, 618
        }
    }
}