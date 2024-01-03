﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Database;

#nullable disable

namespace api.Database.Migrations
{
    [DbContext(typeof(StoreCtx))]
    [Migration("20240103170041_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Angular",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Angular Speedster Board 2000",
                            PictureUrl = "/images/products/sb-ang1.png",
                            Price = 20000L,
                            Quantity = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Angular",
                            Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                            Name = "Green Angular Board 3000",
                            PictureUrl = "/images/products/sb-ang2.png",
                            Price = 15000L,
                            Quantity = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 3,
                            Brand = "NetCore",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Core Board Speed Rush 3",
                            PictureUrl = "/images/products/sb-core1.png",
                            Price = 18000L,
                            Quantity = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 4,
                            Brand = "NetCore",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            Name = "Net Core Super Board",
                            PictureUrl = "/images/products/sb-core2.png",
                            Price = 30000L,
                            Quantity = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 5,
                            Brand = "React",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "React Board Super Whizzy Fast",
                            PictureUrl = "/images/products/sb-react1.png",
                            Price = 25000L,
                            Quantity = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 6,
                            Brand = "TypeScript",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Typescript Entry Board",
                            PictureUrl = "/images/products/sb-ts1.png",
                            Price = 12000L,
                            Quantity = 100,
                            Type = "Boards"
                        },
                        new
                        {
                            Id = 7,
                            Brand = "NetCore",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Core Blue Hat",
                            PictureUrl = "/images/products/hat-core1.png",
                            Price = 1000L,
                            Quantity = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 8,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green React Woolen Hat",
                            PictureUrl = "/images/products/hat-react1.png",
                            Price = 8000L,
                            Quantity = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 9,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Purple React Woolen Hat",
                            PictureUrl = "/images/products/hat-react2.png",
                            Price = 1500L,
                            Quantity = 100,
                            Type = "Hats"
                        },
                        new
                        {
                            Id = 10,
                            Brand = "VS Code",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Blue Code Gloves",
                            PictureUrl = "/images/products/glove-code1.png",
                            Price = 1800L,
                            Quantity = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 11,
                            Brand = "VS Code",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green Code Gloves",
                            PictureUrl = "/images/products/glove-code2.png",
                            Price = 1500L,
                            Quantity = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 12,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Purple React Gloves",
                            PictureUrl = "/images/products/glove-react1.png",
                            Price = 1600L,
                            Quantity = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 13,
                            Brand = "React",
                            Description = "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Green React Gloves",
                            PictureUrl = "/images/products/glove-react2.png",
                            Price = 1400L,
                            Quantity = 100,
                            Type = "Gloves"
                        },
                        new
                        {
                            Id = 14,
                            Brand = "Redis",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Redis Red Boots",
                            PictureUrl = "/images/products/boot-redis1.png",
                            Price = 25000L,
                            Quantity = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 15,
                            Brand = "NetCore",
                            Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                            Name = "Core Red Boots",
                            PictureUrl = "/images/products/boot-core2.png",
                            Price = 18999L,
                            Quantity = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 16,
                            Brand = "NetCore",
                            Description = "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                            Name = "Core Purple Boots",
                            PictureUrl = "/images/products/boot-core1.png",
                            Price = 19999L,
                            Quantity = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 17,
                            Brand = "Angular",
                            Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                            Name = "Angular Purple Boots",
                            PictureUrl = "/images/products/boot-ang2.png",
                            Price = 15000L,
                            Quantity = 100,
                            Type = "Boots"
                        },
                        new
                        {
                            Id = 18,
                            Brand = "Angular",
                            Description = "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                            Name = "Angular Blue Boots",
                            PictureUrl = "/images/products/boot-ang1.png",
                            Price = 18000L,
                            Quantity = 100,
                            Type = "Boots"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
