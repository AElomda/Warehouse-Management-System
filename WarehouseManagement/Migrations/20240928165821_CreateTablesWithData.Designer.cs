﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WarehouseManagement.WarehouseContext;

#nullable disable

namespace WarehouseManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240928165821_CreateTablesWithData")]
    partial class CreateTablesWithData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WarehouseManagement.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"),
                            Name = "Electronics"
                        },
                        new
                        {
                            Id = new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"),
                            Name = "Clothing"
                        },
                        new
                        {
                            Id = new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"),
                            Name = "Books"
                        },
                        new
                        {
                            Id = new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"),
                            Name = "Furniture"
                        });
                });

            modelBuilder.Entity("WarehouseManagement.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ebe93dd4-debc-4af7-9ba1-d6312bcb65d8"),
                            CategoryId = new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"),
                            Cost = 800m,
                            Count = 50,
                            Description = "A high-performance laptop",
                            Name = "Laptop",
                            Price = 1000m
                        },
                        new
                        {
                            Id = new Guid("5947c8d3-0960-4451-916e-a32b5a3c92ba"),
                            CategoryId = new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"),
                            Cost = 500m,
                            Count = 100,
                            Description = "Latest model smartphone",
                            Name = "Smartphone",
                            Price = 700m
                        },
                        new
                        {
                            Id = new Guid("838f47db-ab27-4406-937e-ab56d7eeab60"),
                            CategoryId = new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"),
                            Cost = 150m,
                            Count = 150,
                            Description = "Noise-cancelling wireless headphones",
                            Name = "Headphones",
                            Price = 200m
                        },
                        new
                        {
                            Id = new Guid("c4fe4736-b885-4c9c-ad7a-1649be89cad5"),
                            CategoryId = new Guid("fa3cd20b-a03d-49f9-a103-2cc3ce2d9b86"),
                            Cost = 120m,
                            Count = 80,
                            Description = "A smartwatch with fitness tracking",
                            Name = "Smartwatch",
                            Price = 180m
                        },
                        new
                        {
                            Id = new Guid("5e414601-1c81-4a23-bec0-8972cd4332e5"),
                            CategoryId = new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"),
                            Cost = 10m,
                            Count = 200,
                            Description = "Comfortable cotton t-shirt",
                            Name = "T-Shirt",
                            Price = 20m
                        },
                        new
                        {
                            Id = new Guid("4cfe0d79-30f8-4072-85dc-25f2f16ac254"),
                            CategoryId = new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"),
                            Cost = 30m,
                            Count = 150,
                            Description = "Denim jeans with a slim fit",
                            Name = "Jeans",
                            Price = 50m
                        },
                        new
                        {
                            Id = new Guid("aa968641-35c8-4aef-acdd-65fca40aa6da"),
                            CategoryId = new Guid("edcdd703-121f-4ada-ad3a-e54a21dc5870"),
                            Cost = 70m,
                            Count = 60,
                            Description = "Warm winter jacket",
                            Name = "Jacket",
                            Price = 100m
                        },
                        new
                        {
                            Id = new Guid("d4489612-fe42-4f92-bbbf-a1c9dbfd4d44"),
                            CategoryId = new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"),
                            Cost = 25m,
                            Count = 120,
                            Description = "An in-depth guide to C# programming",
                            Name = "C# Programming",
                            Price = 40m
                        },
                        new
                        {
                            Id = new Guid("0421bab5-2b06-48d0-a776-2a13d3abc7b9"),
                            CategoryId = new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"),
                            Cost = 30m,
                            Count = 80,
                            Description = "Master ASP.NET Core development",
                            Name = "ASP.NET Core Development",
                            Price = 50m
                        },
                        new
                        {
                            Id = new Guid("5fee89c3-e084-4823-9dce-79a289fa6487"),
                            CategoryId = new Guid("3d051043-8edc-48c1-a5ae-f6ed823cee67"),
                            Cost = 20m,
                            Count = 110,
                            Description = "Learn EF Core with practical examples",
                            Name = "Entity Framework Core",
                            Price = 35m
                        },
                        new
                        {
                            Id = new Guid("b765edd0-2e57-49a8-8c40-92692597262d"),
                            CategoryId = new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"),
                            Cost = 200m,
                            Count = 30,
                            Description = "Wooden dining table with a modern design",
                            Name = "Dining Table",
                            Price = 300m
                        },
                        new
                        {
                            Id = new Guid("f5ca3c48-a90a-42c7-950e-566c849fbce6"),
                            CategoryId = new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"),
                            Cost = 100m,
                            Count = 70,
                            Description = "Ergonomic office chair with adjustable height",
                            Name = "Office Chair",
                            Price = 150m
                        },
                        new
                        {
                            Id = new Guid("87945a8c-48a2-417a-9eb9-cbfbdea851ac"),
                            CategoryId = new Guid("924d5522-4d62-4b6d-afdb-b8fff726d885"),
                            Cost = 400m,
                            Count = 20,
                            Description = "Comfortable 3-seater sofa",
                            Name = "Sofa",
                            Price = 600m
                        });
                });

            modelBuilder.Entity("WarehouseManagement.Models.Product", b =>
                {
                    b.HasOne("WarehouseManagement.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WarehouseManagement.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
