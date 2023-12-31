﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _125_MusicLibraryBinusTask.Data;

#nullable disable

namespace _125_MusicLibraryBinusTask.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230822233839_Final")]
    partial class Final
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("_125_MusicLibraryBinusTask.Model.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Album")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Like")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Album = "When",
                            Artist = "Who",
                            Genre = "Alternative",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9254),
                            Title = "Who is Who"
                        },
                        new
                        {
                            Id = 2,
                            Album = "Long Time Ago",
                            Artist = "Boney M",
                            Genre = "80's",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9304),
                            Title = "Rasputin"
                        },
                        new
                        {
                            Id = 3,
                            Album = "Shady",
                            Artist = "Eminem",
                            Genre = "Rap",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9306),
                            Title = "Bad Poetry"
                        },
                        new
                        {
                            Id = 4,
                            Album = "Spicy Year",
                            Artist = "Cury",
                            Genre = "Folk",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9308),
                            Title = "Jimmi"
                        },
                        new
                        {
                            Id = 5,
                            Album = "My Neighbours Never Sleep",
                            Artist = "Scre Driver",
                            Genre = "Heavy Metall",
                            Like = 0,
                            ReleaseDate = new DateTime(2023, 8, 22, 19, 38, 39, 819, DateTimeKind.Local).AddTicks(9310),
                            Title = "Rusty Nails"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
