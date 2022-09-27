﻿// <auto-generated />
using System;
using Asp06Store.ShopUI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Asp06Store.ShopUI.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20220927070756_addOrder")]
    partial class addOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Mobile",
                            Description = "sumsumng 1 best mobile for this price",
                            Name = "sumsumng 1",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 2,
                            Category = "Mobile",
                            Description = " sumsumng 2 best mobile for this price",
                            Name = "sumsumng 2",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 3,
                            Category = "Mobile",
                            Description = " IPhone 2 best mobile for this price",
                            Name = "IPhone 3",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 4,
                            Category = "Mobile",
                            Description = " IPhone 4 best mobile for this price",
                            Name = "IPhone 4",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 5,
                            Category = "Mobile",
                            Description = " IPhone 5 best mobile for this price",
                            Name = "Xiomi 5",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 6,
                            Category = "Loptop",
                            Description = "sumsumng 1 best mobile for this price",
                            Name = "asus 6",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 7,
                            Category = "Loptop",
                            Description = " sumsumng 2 best mobile for this price",
                            Name = "hp 7",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 8,
                            Category = "Loptop",
                            Description = " IPhone 2 best mobile for this price",
                            Name = "vivo 8",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 9,
                            Category = "Loptop",
                            Description = " IPhone 4 best mobile for this price",
                            Name = "asus 9",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 10,
                            Category = "Loptop",
                            Description = " IPhone 5 best mobile for this price",
                            Name = "Xiomi 10",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 11,
                            Category = "Pc",
                            Description = " sumsumng 2 best mobile for this price",
                            Name = "pc 11",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 12,
                            Category = "Pc",
                            Description = " IPhone 2 best mobile for this price",
                            Name = "vivo 12",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 13,
                            Category = "Pc",
                            Description = " IPhone 4 best mobile for this price",
                            Name = "asus 13",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 14,
                            Category = "Pc",
                            Description = " IPhone 4 best mobile for this price",
                            Name = "asus 14",
                            Price = 30000000
                        });
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.OrderDetail", b =>
                {
                    b.HasOne("Asp06Store.ShopUI.Models.Order", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId");

                    b.HasOne("Asp06Store.ShopUI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
