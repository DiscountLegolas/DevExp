﻿// <auto-generated />
using System;
using DevExp.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DevExp.Migrations
{
    [DbContext(typeof(DEContext))]
    [Migration("20220614111406_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DevExp.EntityFramework.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Murat"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bülent"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Özgür"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ahmet"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hüseyin"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Can"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Buğra"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Duygu"
                        },
                        new
                        {
                            Id = 9,
                            Name = "İlkem"
                        });
                });

            modelBuilder.Entity("DevExp.EntityFramework.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UnitPrice")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductName = "Halley",
                            UnitPrice = 50f
                        },
                        new
                        {
                            ProductId = 2,
                            ProductName = "Lays",
                            UnitPrice = 150f
                        },
                        new
                        {
                            ProductId = 3,
                            ProductName = "Ruffles",
                            UnitPrice = 150f
                        },
                        new
                        {
                            ProductId = 4,
                            ProductName = "Eti Karam",
                            UnitPrice = 80f
                        },
                        new
                        {
                            ProductId = 5,
                            ProductName = "Eti Ahenk",
                            UnitPrice = 80f
                        },
                        new
                        {
                            ProductId = 6,
                            ProductName = "Sütaş Süt",
                            UnitPrice = 180f
                        },
                        new
                        {
                            ProductId = 7,
                            ProductName = "Cartedor Bademli Magnum",
                            UnitPrice = 200f
                        },
                        new
                        {
                            ProductId = 8,
                            ProductName = "Algida Maraş Usulü",
                            UnitPrice = 200f
                        },
                        new
                        {
                            ProductId = 9,
                            ProductName = "Coca Cola",
                            UnitPrice = 100f
                        });
                });

            modelBuilder.Entity("DevExp.EntityFramework.Models.ProductSale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BuyedUnitAmount")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TransictionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductSale");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuyedUnitAmount = 1,
                            CustomerId = 1,
                            ProductId = 1,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            BuyedUnitAmount = 2,
                            CustomerId = 2,
                            ProductId = 2,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            BuyedUnitAmount = 3,
                            CustomerId = 3,
                            ProductId = 3,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            BuyedUnitAmount = 4,
                            CustomerId = 4,
                            ProductId = 4,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            BuyedUnitAmount = 2,
                            CustomerId = 5,
                            ProductId = 5,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            BuyedUnitAmount = 1,
                            CustomerId = 6,
                            ProductId = 6,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            BuyedUnitAmount = 1,
                            CustomerId = 7,
                            ProductId = 7,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            BuyedUnitAmount = 3,
                            CustomerId = 8,
                            ProductId = 8,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            BuyedUnitAmount = 2,
                            CustomerId = 9,
                            ProductId = 9,
                            TransictionDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DevExp.EntityFramework.Models.ProductSale", b =>
                {
                    b.HasOne("DevExp.EntityFramework.Models.Customer", "Customer")
                        .WithMany("Purchases")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DevExp.EntityFramework.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DevExp.EntityFramework.Models.Customer", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("DevExp.EntityFramework.Models.Product", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}
