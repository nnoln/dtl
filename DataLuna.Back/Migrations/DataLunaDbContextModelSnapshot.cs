﻿// <auto-generated />
using System;
using DataLuna.Back.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataLuna.Back.Migrations
{
    [DbContext(typeof(DataLunaDbContext))]
    partial class DataLunaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("DataLuna.Back.Domain.GameDemo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DemoData")
                        .HasColumnType("text");

                    b.Property<long>("TeamAId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeamBId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeamAId");

                    b.HasIndex("TeamBId");

                    b.ToTable("Demos");
                });

            modelBuilder.Entity("DataLuna.Back.Domain.GameEvent", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("EventDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<long>("TeamAId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeamBId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeamAId");

                    b.HasIndex("TeamBId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("DataLuna.Back.Domain.Player", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SteamId")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("DataLuna.Back.Domain.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImagePath")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("DataLuna.Back.Domain.GameDemo", b =>
                {
                    b.HasOne("DataLuna.Back.Domain.Team", "TeamA")
                        .WithMany()
                        .HasForeignKey("TeamAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLuna.Back.Domain.Team", "TeamB")
                        .WithMany()
                        .HasForeignKey("TeamBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLuna.Back.Domain.GameEvent", b =>
                {
                    b.HasOne("DataLuna.Back.Domain.Team", "TeamA")
                        .WithMany()
                        .HasForeignKey("TeamAId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLuna.Back.Domain.Team", "TeamB")
                        .WithMany()
                        .HasForeignKey("TeamBId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLuna.Back.Domain.Player", b =>
                {
                    b.HasOne("DataLuna.Back.Domain.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
