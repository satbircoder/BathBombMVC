﻿// <auto-generated />
using BathBombMVC.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BathBombMVC.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230803111354_addImageURltoproduct")]
    partial class addImageURltoproduct
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BathBombMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Scifi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("BathBombMVC.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flavour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Gaze at this ancient relic of blue steel, purple iris, and liquid gold foam",
                            Flavour = "Salted Caramel",
                            ImageUrl = "",
                            ListPrice = 99.0,
                            Price = 90.0,
                            Price100 = 80.0,
                            Price50 = 85.0,
                            ProductName = "Artifact",
                            Size = "220G BATH BOMB"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "\"Wild\" is the perfect word to describe the hypnotic bath art this bath bomb creates.",
                            Flavour = "Cake Batter",
                            ImageUrl = "",
                            ListPrice = 40.0,
                            Price = 30.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            ProductName = "Wild Child",
                            Size = "220G BATH BOMB"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Don't worry, we understand your desire for artisanal and one of a kind products, and the Coffee Snob is just that.",
                            Flavour = "Fresh Coffee",
                            ImageUrl = "",
                            ListPrice = 55.0,
                            Price = 50.0,
                            Price100 = 35.0,
                            Price50 = 40.0,
                            ProductName = "Coffee Snob",
                            Size = "220G BATH BOMB"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Jam Donut has a white fizzy base with a hidden pink centre, topped with pink cocoa butter glaze, vegan sprinkles, and biodegradable silver glitter.",
                            Flavour = "Raspberry Jam",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 55.0,
                            Price50 = 60.0,
                            ProductName = "Jam Donut",
                            Size = "220G BATH BOMB"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "Fall asleep with the restful smell of lavender and warm tonka",
                            Flavour = " Lavender & Tonka",
                            ImageUrl = "",
                            ListPrice = 30.0,
                            Price = 27.0,
                            Price100 = 20.0,
                            Price50 = 25.0,
                            ProductName = "Counting Sheep",
                            Size = "220G BATH BOMB"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Apple Donut has a coral pink fizzy base, topped with white cocoa butter glaze, vegan sprinkles, and biodegradable gold glitter.",
                            Flavour = "Spiced Apple",
                            ImageUrl = "",
                            ListPrice = 25.0,
                            Price = 23.0,
                            Price100 = 20.0,
                            Price50 = 22.0,
                            ProductName = "Apple Donut",
                            Size = "220G BATH BOMB"
                        });
                });

            modelBuilder.Entity("BathBombMVC.Models.Product", b =>
                {
                    b.HasOne("BathBombMVC.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
