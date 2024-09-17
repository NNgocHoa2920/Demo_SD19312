﻿// <auto-generated />
using MVC_Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_Web.Migrations
{
    [DbContext(typeof(SD19312DbContext))]
    partial class SD19312DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVC_Web.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryID"), 1L, 1);

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            DisplayOrder = 1,
                            Name = "Khoai1"
                        },
                        new
                        {
                            CategoryID = 2,
                            DisplayOrder = 2,
                            Name = "Khoai2"
                        },
                        new
                        {
                            CategoryID = 3,
                            DisplayOrder = 10,
                            Name = "Khoai3"
                        },
                        new
                        {
                            CategoryID = 4,
                            DisplayOrder = 9,
                            Name = "Khoai4"
                        },
                        new
                        {
                            CategoryID = 5,
                            DisplayOrder = 8,
                            Name = "Khoai5"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
