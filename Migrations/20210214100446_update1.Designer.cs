﻿// <auto-generated />
using System;
using DemoStandardProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoStandardProject.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210214100446_update1")]
    partial class update1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoStandardProject.Models.Products.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(16,2)");

                    b.Property<bool?>("IsActice")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(16,2)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ProductDetail")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("ProductGroupId")
                        .HasColumnType("int");

                    b.Property<int>("PromotionId")
                        .HasColumnType("int");

                    b.Property<decimal>("Stock")
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("PromotionId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Products.ProductGroup", b =>
                {
                    b.Property<int>("ProductGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActice")
                        .HasColumnType("bit");

                    b.Property<string>("ProductGroupDetail")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductGroupId");

                    b.ToTable("ProductGroup");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Products.ProductStockLog", b =>
                {
                    b.Property<int>("StockLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("AmountAfter")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("AmountBefore")
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime?>("Createdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActice")
                        .HasColumnType("bit");

                    b.Property<decimal>("NewEdit")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("TextRemark")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("TypeAdd")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("StockLogId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductStockLogs");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Sales.Invoice", b =>
                {
                    b.Property<string>("InvoiceCode")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SalesHeaderId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalDiscount")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal?>("TotalInvoice")
                        .HasColumnType("decimal(16,2)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("InvoiceCode");

                    b.HasIndex("SalesHeaderId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Sales.Promotions", b =>
                {
                    b.Property<int>("PromotionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateFrom")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(16,2)");

                    b.Property<bool>("IsActice")
                        .HasColumnType("bit");

                    b.Property<DateTime>("dateTo")
                        .HasColumnType("datetime2");

                    b.HasKey("PromotionId");

                    b.ToTable("Promotions");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Sales.SalesDetail", b =>
                {
                    b.Property<int>("SalesDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsAcctice")
                        .HasColumnType("bit");

                    b.Property<int>("ItemCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderCreatdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SalesHeaderId")
                        .HasColumnType("int");

                    b.HasKey("SalesDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalesHeaderId");

                    b.ToTable("SalesDetail");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Sales.SalesHeader", b =>
                {
                    b.Property<int>("SalesHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SalesStatusId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(16,2)");

                    b.Property<decimal>("TotalDiscount")
                        .HasColumnType("decimal(16,2)");

                    b.Property<int>("Totalcount")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("SalesHeaderId");

                    b.ToTable("SalesHeader");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Products.Product", b =>
                {
                    b.HasOne("DemoStandardProject.Models.Products.ProductGroup", "ProductGroup")
                        .WithMany("Products")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoStandardProject.Models.Sales.Promotions", "Promotions")
                        .WithMany("Products")
                        .HasForeignKey("PromotionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoStandardProject.Models.Products.ProductStockLog", b =>
                {
                    b.HasOne("DemoStandardProject.Models.Products.Product", null)
                        .WithMany("ProductStockLogs")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DemoStandardProject.Models.Sales.Invoice", b =>
                {
                    b.HasOne("DemoStandardProject.Models.Sales.SalesHeader", null)
                        .WithMany("Invoices")
                        .HasForeignKey("SalesHeaderId");
                });

            modelBuilder.Entity("DemoStandardProject.Models.Sales.SalesDetail", b =>
                {
                    b.HasOne("DemoStandardProject.Models.Products.Product", null)
                        .WithMany("SalesDetails")
                        .HasForeignKey("ProductId");

                    b.HasOne("DemoStandardProject.Models.Sales.SalesHeader", null)
                        .WithMany("SalesDetails")
                        .HasForeignKey("SalesHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}