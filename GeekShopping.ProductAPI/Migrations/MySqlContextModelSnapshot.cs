﻿// <auto-generated />
using GeekShopping.ProductAPI.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    [DbContext(typeof(MySqlContext))]
    partial class MySqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GeekShopping.ProductAPI.Models.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    b.Property<string>("Category")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("description");

                    b.Property<string>("ImageURL")
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("image_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(65,30)")
                        .HasColumnName("price");

                    b.HasKey("Id");

                    b.ToTable("product");

                    b.HasData(
                        new
                        {
                            Id = 3L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 7",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 4L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 8",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 5L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone X",
                            Price = 1400m
                        },
                        new
                        {
                            Id = 6L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone XR",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 7L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone XS",
                            Price = 1600m
                        },
                        new
                        {
                            Id = 8L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone XS Max",
                            Price = 1800m
                        },
                        new
                        {
                            Id = 9L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 11 Mini",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 10L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 11",
                            Price = 2200m
                        },
                        new
                        {
                            Id = 11L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 11 Pro",
                            Price = 2400m
                        },
                        new
                        {
                            Id = 12L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 12 Mini",
                            Price = 2500m
                        },
                        new
                        {
                            Id = 13L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 12",
                            Price = 2600m
                        },
                        new
                        {
                            Id = 14L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 12 Pro",
                            Price = 2800m
                        },
                        new
                        {
                            Id = 15L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 13 Mini",
                            Price = 3000m
                        },
                        new
                        {
                            Id = 16L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 11",
                            Price = 3200m
                        },
                        new
                        {
                            Id = 17L,
                            Category = "",
                            Description = "",
                            ImageURL = "",
                            Name = "Iphone 13 Pro",
                            Price = 3400m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
