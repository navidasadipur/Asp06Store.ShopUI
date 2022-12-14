// <auto-generated />
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
    [Migration("20220927165309_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mobile"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Loptop"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pc"
                        });
                });

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

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "sumsumng 1 best mobile for this price",
                            Name = "sumsumng 1",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = " sumsumng 2 best mobile for this price",
                            Name = "sumsumng 2",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = " IPhone 2 best mobile for this price",
                            Name = "IPhone 3",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = " IPhone 4 best mobile for this price",
                            Name = "IPhone 4",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = " IPhone 5 best mobile for this price",
                            Name = "Xiomi 5",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "sumsumng 1 best mobile for this price",
                            Name = "asus 6",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = " sumsumng 2 best mobile for this price",
                            Name = "hp 7",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = " IPhone 2 best mobile for this price",
                            Name = "vivo 8",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = " IPhone 4 best mobile for this price",
                            Name = "asus 9",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = " IPhone 5 best mobile for this price",
                            Name = "Xiomi 10",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = " sumsumng 2 best mobile for this price",
                            Name = "pc 11",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = " IPhone 2 best mobile for this price",
                            Name = "vivo 12",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Description = " IPhone 4 best mobile for this price",
                            Name = "asus 13",
                            Price = 30000000
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
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

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Product", b =>
                {
                    b.HasOne("Asp06Store.ShopUI.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Asp06Store.ShopUI.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
