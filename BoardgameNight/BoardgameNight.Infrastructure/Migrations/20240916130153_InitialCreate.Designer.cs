﻿// <auto-generated />
using System;
using BoardgameNight.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoardgameNight.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240916130153_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BoardgameBoardgameNight", b =>
                {
                    b.Property<int>("BoardgameNightsId")
                        .HasColumnType("int");

                    b.Property<int>("BoardgamesId")
                        .HasColumnType("int");

                    b.HasKey("BoardgameNightsId", "BoardgamesId");

                    b.HasIndex("BoardgamesId");

                    b.ToTable("BoardgameBoardgameNight");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Attendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoardgameNightId")
                        .HasColumnType("int");

                    b.Property<int?>("BoardgameNightId1")
                        .HasColumnType("int");

                    b.Property<bool>("HasAttended")
                        .HasColumnType("bit");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BoardgameNightId");

                    b.HasIndex("BoardgameNightId1");

                    b.HasIndex("PersonId");

                    b.ToTable("Attendances", (string)null);
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Boardgame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdultOnly")
                        .HasColumnType("bit");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<int>("MinPlayers")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Boardgames");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.BoardgameNight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAdultsOnly")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPotluck")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxPlayers")
                        .HasColumnType("int");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrganizerId");

                    b.ToTable("BoardgameNights");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Drink", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("ContainsAlcohol")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsLactoseFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNutFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AvoidAlcohol")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("HasLactoseAllergy")
                        .HasColumnType("bit");

                    b.Property<bool>("HasNutAllergy")
                        .HasColumnType("bit");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.PotluckItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoardgameNightId")
                        .HasColumnType("int");

                    b.Property<int>("BroughtById")
                        .HasColumnType("int");

                    b.Property<bool>("ContainsAlcohol")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLactoseFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsNutFree")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoardgameNightId");

                    b.HasIndex("BroughtById");

                    b.ToTable("PotluckItems");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BoardgameNightId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoardgameNightId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("BoardgameNightDrink", b =>
                {
                    b.Property<int>("BoardgameNightsId")
                        .HasColumnType("int");

                    b.Property<int>("DrinkOptionsId")
                        .HasColumnType("int");

                    b.HasKey("BoardgameNightsId", "DrinkOptionsId");

                    b.HasIndex("DrinkOptionsId");

                    b.ToTable("BoardgameNightDrink");
                });

            modelBuilder.Entity("BoardgameNightFood", b =>
                {
                    b.Property<int>("BoardgameNightsId")
                        .HasColumnType("int");

                    b.Property<int>("FoodOptionsId")
                        .HasColumnType("int");

                    b.HasKey("BoardgameNightsId", "FoodOptionsId");

                    b.HasIndex("FoodOptionsId");

                    b.ToTable("BoardgameNightFood");
                });

            modelBuilder.Entity("BoardgameBoardgameNight", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", null)
                        .WithMany()
                        .HasForeignKey("BoardgameNightsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardgameNight.Domain.Entities.Boardgame", null)
                        .WithMany()
                        .HasForeignKey("BoardgamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Attendance", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", "BoardgameNight")
                        .WithMany()
                        .HasForeignKey("BoardgameNightId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", null)
                        .WithMany("Attendances")
                        .HasForeignKey("BoardgameNightId1");

                    b.HasOne("BoardgameNight.Domain.Entities.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BoardgameNight");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.BoardgameNight", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.Person", "Organizer")
                        .WithMany("OrganizedNights")
                        .HasForeignKey("OrganizerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.PotluckItem", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", "BoardgameNight")
                        .WithMany()
                        .HasForeignKey("BoardgameNightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardgameNight.Domain.Entities.Person", "BroughtBy")
                        .WithMany()
                        .HasForeignKey("BroughtById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardgameNight");

                    b.Navigation("BroughtBy");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Review", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", "BoardgameNight")
                        .WithMany("Reviews")
                        .HasForeignKey("BoardgameNightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardgameNight.Domain.Entities.Person", "Reviewer")
                        .WithMany("GivenReviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BoardgameNight");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("BoardgameNightDrink", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", null)
                        .WithMany()
                        .HasForeignKey("BoardgameNightsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardgameNight.Domain.Entities.Drink", null)
                        .WithMany()
                        .HasForeignKey("DrinkOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoardgameNightFood", b =>
                {
                    b.HasOne("BoardgameNight.Domain.Entities.BoardgameNight", null)
                        .WithMany()
                        .HasForeignKey("BoardgameNightsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BoardgameNight.Domain.Entities.Food", null)
                        .WithMany()
                        .HasForeignKey("FoodOptionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.BoardgameNight", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("BoardgameNight.Domain.Entities.Person", b =>
                {
                    b.Navigation("GivenReviews");

                    b.Navigation("OrganizedNights");
                });
#pragma warning restore 612, 618
        }
    }
}
