﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eshop.Infrastructure.Data;

#nullable disable

namespace eshop.Infrastructure.Migrations
{
    [DbContext(typeof(VakifEshopDbContext))]
    [Migration("20241106122738_add_data")]
    partial class add_data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("eshop.Domain.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Elektronik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Kırtasiye"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mobilya"
                        });
                });

            modelBuilder.Entity("eshop.Domain.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("StockCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Dell süperdir",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Dell",
                            Price = 100m,
                            StockCount = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Yüksek performanslı HP laptop",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "HP Laptop",
                            Price = 120m,
                            StockCount = 80
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Apple kalitesinde iPhone",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Apple iPhone",
                            Price = 200m,
                            StockCount = 50
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Samsung Galaxy telefon",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Samsung Galaxy",
                            Price = 150m,
                            StockCount = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Sony kaliteli kulaklık",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Sony Kulaklık",
                            Price = 60m,
                            StockCount = 150
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Canon profesyonel kamera",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Canon Kamera",
                            Price = 300m,
                            StockCount = 40
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "LG geniş ekran TV",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "LG Televizyon",
                            Price = 500m,
                            StockCount = 25
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Rahat yazım için Pilot kalem",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Pilot Kalem",
                            Price = 5m,
                            StockCount = 500
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "100 yapraklı kaliteli defter",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Defter",
                            Price = 10m,
                            StockCount = 300
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Ofis için organizer",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Masaüstü Organizer",
                            Price = 20m,
                            StockCount = 120
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Belgeler için dosya",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Dosya",
                            Price = 2m,
                            StockCount = 400
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Matematik için cetvel seti",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Cetvel Seti",
                            Price = 8m,
                            StockCount = 200
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Mavi tükenmez kalem",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Tükenmez Kalem",
                            Price = 3m,
                            StockCount = 600
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Yumuşak yapıda silgi",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Silgi",
                            Price = 1m,
                            StockCount = 1000
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Rahat ofis sandalyesi",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Ofis Sandalyesi",
                            Price = 150m,
                            StockCount = 70
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "Modern tasarımlı çalışma masası",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Çalışma Masası",
                            Price = 200m,
                            StockCount = 50
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Description = "Geniş kitaplık",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Kitaplık",
                            Price = 120m,
                            StockCount = 40
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Konforlu L koltuk",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "L Koltuk",
                            Price = 600m,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Description = "Şık sehpa",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Sehpa",
                            Price = 70m,
                            StockCount = 100
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "3 kapılı geniş gardırop",
                            ImageUrl = "https://picsum.photos/seed/picsum/200/300",
                            Name = "Gardırop",
                            Price = 300m,
                            StockCount = 30
                        });
                });

            modelBuilder.Entity("eshop.Domain.Product", b =>
                {
                    b.HasOne("eshop.Domain.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("eshop.Domain.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}