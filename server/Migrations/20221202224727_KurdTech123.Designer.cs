﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Data;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(KurdDbcontext))]
    [Migration("20221202224727_KurdTech123")]
    partial class KurdTech123
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("client.Server.models.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("client.Server.models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("client.Server.models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "@Icons.Filled.PhoneIphone",
                            Name = "مۆبایل"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "@Icons.Filled.Tablet",
                            Name = "تابلێت"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "@Icons.Filled.EarbudsBattery",
                            Name = "ئێکسسوارات"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "@Icons.Filled.Headphones",
                            Name = "بیستۆک"
                        },
                        new
                        {
                            Id = 5,
                            Icon = "@Icons.Filled.Laptop",
                            Name = "لاپتۆپ"
                        });
                });

            modelBuilder.Entity("client.Server.models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AccessoriesId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LaptopDetailId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PhoneDetailId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccessoriesId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("LaptopDetailId");

                    b.HasIndex("PhoneDetailId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Phone/IPhone14ProMax.png",
                            Name = "Iphone 14 Pro max",
                            PhoneDetailId = 1,
                            Price = 1300.0,
                            Quantity = 100,
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Phone/IPhone13ProMax.png",
                            Name = "Iphone 13 Pro max",
                            Price = 1200.0,
                            Quantity = 90,
                            Rating = 4
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای ئینفینیکس",
                            ImageUrl = "/ images / Phone /InfinixZeroUltra.png",
                            Name = "Infinx Zero Ultra",
                            Price = 300.0,
                            Quantity = 100,
                            Rating = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای سامسونگ",
                            ImageUrl = "/images/Phone/GalaxyS22Ultra.png",
                            Name = "Galaxy S22 Ultra",
                            Price = 1350.0,
                            Quantity = 15,
                            Rating = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای ئۆپۆ",
                            ImageUrl = "/images/Phone/F11Pro.png",
                            Name = "F11 Pro",
                            Price = 700.0,
                            Quantity = 115,
                            Rating = 3
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای وەنپلەس ",
                            ImageUrl = "/images/Phone/OnePlus9Pro.png",
                            Name = "One Plus9 Pro",
                            Price = 450.0,
                            Quantity = 10,
                            Rating = 4
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای گوگڵ ",
                            ImageUrl = "/images/Phone/Pixel6Pro.png",
                            Name = "Pixel 6 Pro",
                            Price = 400.0,
                            Quantity = 40,
                            Rating = 3
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "بەرهەمی کۆمپانیای ریدمی ",
                            ImageUrl = "/images/Phone/RedmiNote12Pro.png",
                            Name = "Redmi Note 12 Pro",
                            Price = 350.0,
                            Quantity = 30,
                            Rating = 3
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/DellXps17.jpg",
                            Name = "Dell Xps 17",
                            Price = 700.0,
                            Quantity = 10,
                            Rating = 3
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            Description = "بەرهەمی کۆمپانیای ئێچ پی",
                            ImageUrl = "/images/Laptops/HpOmen.jpg",
                            Name = "Hp Omen",
                            Price = 800.0,
                            Quantity = 9,
                            Rating = 3
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 5,
                            Description = "بەرهەمی کۆمپانیای لینۆڤۆ",
                            ImageUrl = "/images/Laptops/LenovoIdeaPad.jpg",
                            Name = "Lenovo Idea Pad",
                            Price = 900.0,
                            Quantity = 15,
                            Rating = 4
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 5,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/MacbookAirM1.jpg",
                            Name = "Macbook AirM1",
                            Price = 1000.0,
                            Quantity = 5,
                            Rating = 4
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 5,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/MacbookAirM2.jpg",
                            Name = "Macbook AirM2",
                            Price = 1100.0,
                            Quantity = 6,
                            Rating = 4
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 5,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/MacbookPro.jpg",
                            Name = "Macbook Pro",
                            Price = 1200.0,
                            Quantity = 5,
                            Rating = 4
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/IPadPro12.9.png",
                            Name = "Ipad Pro 12.9",
                            Price = 950.0,
                            Quantity = 10,
                            Rating = 4
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "بەرهەمی کۆمپانیای سامسونگ",
                            ImageUrl = "/images/Laptops/SamsungTabS8Ultra.png",
                            Name = "Samsung Tab S8 Ultra",
                            Price = 950.0,
                            Quantity = 10,
                            Rating = 4
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 4,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AirPodsPro2.png",
                            Name = "Air Pods Pro2",
                            Price = 100.0,
                            Quantity = 40,
                            Rating = 4
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AppleAirPodsMax.png",
                            Name = "Apple Air Pods Max",
                            Price = 110.0,
                            Quantity = 35,
                            Rating = 4
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "بەرهەمی کۆمپانیای هایپەر ئێکس",
                            ImageUrl = "/images/Laptops/HyperxCloud2.png",
                            Name = "Hyperx Cloud2",
                            Price = 99.0,
                            Quantity = 33,
                            Rating = 4
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "بەرهەمی کۆمپانیای ڕەیزەر",
                            ImageUrl = "/images/Laptops/KrakenX.png",
                            Name = "KrakenX",
                            Price = 120.0,
                            Quantity = 32,
                            Rating = 4
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "بەرهەمی کۆمپانیای سۆنی",
                            ImageUrl = "/images/Laptops/WF1000XM4.png",
                            Name = "WF1000XM4",
                            Price = 130.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "بەرهەمی کۆمپانیای سۆنی",
                            ImageUrl = "/images/Laptops/WH1000XM4.png",
                            Name = "WH1000XM4",
                            Price = 140.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AppleMagSafe.jpg",
                            Name = "Apple Mag Safe",
                            Price = 70.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AppleMultiPort.jpg",
                            Name = "Apple Multi Port",
                            Price = 40.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AppleTag.jpg",
                            Name = "Apple Tag",
                            Price = 50.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AppleUSBCPowerAdapter.jpg",
                            Name = "Apple USBCPower Adapter",
                            Price = 60.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای ئەپڵ",
                            ImageUrl = "/images/Laptops/AppleUSBPowerCable.jpg",
                            Name = "Apple USBPower Cable",
                            Price = 40.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای سامسونگ",
                            ImageUrl = "/images/Laptops/GalaxyTag.jpg",
                            Name = "Galaxy Tag",
                            Price = 20.0,
                            Quantity = 30,
                            Rating = 4
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 3,
                            Description = "بەرهەمی کۆمپانیای سامسونگ",
                            ImageUrl = "/images/Laptops/SamsungPortableProjector.jpg",
                            Name = "Samsung Portable Projector",
                            Price = 20.0,
                            Quantity = 30,
                            Rating = 4
                        });
                });

            modelBuilder.Entity("client.Server.models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("server.models.AccessoriesDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AccessoriesDetail");
                });

            modelBuilder.Entity("server.models.LaptopDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Extra_Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Operating_System")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Processor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("LaptopDetails");
                });

            modelBuilder.Entity("server.models.PhoneDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AUX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Announced")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Battery_FastCharge")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Card_Memory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChargingPort")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Chipset")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FingerPrint")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Front")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Main")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OS_UI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ROM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Size_Type_Display")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stereo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("camera_Features")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("resolution_RefreshRate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PhoneDetail");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Announced = "Nov 2021",
                            BatteryFastCharge = "25 watt",
                            CPU = "Apple A15 Bionic",
                            Color = "White",
                            GPU = "Apple GPU",
                            RAM = "6GB",
                            ROM = "256GB"
                        });
                });

            modelBuilder.Entity("client.Server.models.Product", b =>
                {
                    b.HasOne("server.models.AccessoriesDetail", "Accessories")
                        .WithMany()
                        .HasForeignKey("AccessoriesId");

                    b.HasOne("client.Server.models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("server.models.LaptopDetails", "LaptopDetail")
                        .WithMany()
                        .HasForeignKey("LaptopDetailId");

                    b.HasOne("server.models.PhoneDetail", "PhoneDetail")
                        .WithMany()
                        .HasForeignKey("PhoneDetailId");

                    b.Navigation("Accessories");

                    b.Navigation("Category");

                    b.Navigation("LaptopDetail");

                    b.Navigation("PhoneDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
