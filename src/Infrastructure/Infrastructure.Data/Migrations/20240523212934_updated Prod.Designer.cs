﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pgvector;

#nullable disable

namespace eShop.Catalog.API.Infrastructure.Migrations
{
    [DbContext(typeof(CatalogContext))]
    [Migration("20240523212934_updated Prod")]
    partial class updatedProd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "vector");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Catalog.CatalogBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("CatalogBrand", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Catalog.CatalogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AvailableStock")
                        .HasColumnType("integer");

                    b.Property<int>("CatalogBrandId")
                        .HasColumnType("integer");

                    b.Property<int>("CatalogTypeId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<Vector>("Embedding")
                        .HasColumnType("vector(384)");

                    b.Property<int>("MaxStockThreshold")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("OnReorder")
                        .HasColumnType("boolean");

                    b.Property<string>("PictureFileName")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("RestockThreshold")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CatalogBrandId");

                    b.HasIndex("CatalogTypeId");

                    b.HasIndex("Name");

                    b.ToTable("Catalog", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Catalog.CatalogType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("CatalogType", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Product.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("AdminComment")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<int>("BackorderMode")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<bool>("Deleted")
                        .HasColumnType("boolean");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("integer");

                    b.Property<int>("DownloadActivationType")
                        .HasColumnType("integer");

                    b.Property<string>("FullDescription")
                        .HasColumnType("text");

                    b.Property<int>("GiftCardType")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("LastModified")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("text");

                    b.Property<bool>("LimitedToStores")
                        .HasColumnType("boolean");

                    b.Property<int>("LowStockActivity")
                        .HasColumnType("integer");

                    b.Property<int>("ManageInventoryMethod")
                        .HasColumnType("integer");

                    b.Property<string>("MetaDescription")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("MetaKeywords")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("MetaTitle")
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("character varying(400)");

                    b.Property<int>("ParentGroupedProductId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductTemplateId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductType")
                        .HasColumnType("integer");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("integer");

                    b.Property<bool>("Published")
                        .HasColumnType("boolean");

                    b.Property<int>("RecurringCyclePeriod")
                        .HasColumnType("integer");

                    b.Property<int>("RentalPricePeriod")
                        .HasColumnType("integer");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<bool>("SubjectToAcl")
                        .HasColumnType("boolean");

                    b.Property<int>("VendorId")
                        .HasColumnType("integer");

                    b.Property<bool>("VisibleIndividually")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);
                });

            modelBuilder.Entity("Infrastructure.IntegrationEventLogEF.IntegrationEventLogEntry", b =>
                {
                    b.Property<Guid>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("EventTypeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<int>("TimesSent")
                        .HasColumnType("integer");

                    b.Property<Guid>("TransactionId")
                        .HasColumnType("uuid");

                    b.HasKey("EventId");

                    b.ToTable("IntegrationEventLog", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Catalog.CatalogItem", b =>
                {
                    b.HasOne("Domain.Entities.Catalog.CatalogBrand", "CatalogBrand")
                        .WithMany()
                        .HasForeignKey("CatalogBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Catalog.CatalogType", "CatalogType")
                        .WithMany()
                        .HasForeignKey("CatalogTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CatalogBrand");

                    b.Navigation("CatalogType");
                });

            modelBuilder.Entity("Domain.Entities.Product.Product", b =>
                {
                    b.OwnsOne("Domain.Entities.Product.Availability", "Availability", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<DateTime?>("AvailableEndDateTimeUtc")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<bool>("AvailableForPreOrder")
                                .HasColumnType("boolean");

                            b1.Property<DateTime?>("AvailableStartDateTimeUtc")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<int>("DeliveryDateId")
                                .HasColumnType("integer");

                            b1.Property<DateTime?>("PreOrderAvailabilityStartDateTimeUtc")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<int>("ProductAvailabilityRangeId")
                                .HasColumnType("integer");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductAvailabilities", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.ComplianceAndStandards", "ComplianceAndStandards", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<string>("Certifications")
                                .HasColumnType("text");

                            b1.Property<string>("EnvironmentalImpact")
                                .HasColumnType("text");

                            b1.Property<bool>("NotReturnable")
                                .HasColumnType("boolean");

                            b1.Property<string>("RecyclingInformation")
                                .HasColumnType("text");

                            b1.Property<string>("RegulatoryApprovals")
                                .HasColumnType("text");

                            b1.Property<string>("SafetyInformation")
                                .HasColumnType("text");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductCompliances", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.DownloadableProduct", "DownloadableProduct", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<int>("DownloadActivationTypeId")
                                .HasColumnType("integer");

                            b1.Property<int?>("DownloadExpirationDays")
                                .HasColumnType("integer");

                            b1.Property<int>("DownloadId")
                                .HasColumnType("integer");

                            b1.Property<bool>("HasSampleDownload")
                                .HasColumnType("boolean");

                            b1.Property<bool>("HasUserAgreement")
                                .HasColumnType("boolean");

                            b1.Property<bool>("IsDownload")
                                .HasColumnType("boolean");

                            b1.Property<int>("MaxNumberOfDownloads")
                                .HasColumnType("integer");

                            b1.Property<int>("SampleDownloadId")
                                .HasColumnType("integer");

                            b1.Property<bool>("UnlimitedDownloads")
                                .HasColumnType("boolean");

                            b1.Property<string>("UserAgreementText")
                                .HasColumnType("text");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductDownloadables", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.GiftCard", "GiftCard", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<int>("GiftCardTypeId")
                                .HasColumnType("integer");

                            b1.Property<bool>("IsGiftCard")
                                .HasColumnType("boolean");

                            b1.Property<decimal?>("OverriddenGiftCardAmount")
                                .HasColumnType("numeric");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductGiftCards", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.Inventory", "Inventory", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<bool>("AllowAddingOnlyExistingAttributeCombinations")
                                .HasColumnType("boolean");

                            b1.Property<bool>("AllowBackInStockSubscriptions")
                                .HasColumnType("boolean");

                            b1.Property<string>("AllowedQuantities")
                                .HasColumnType("text");

                            b1.Property<int>("BackorderModeId")
                                .HasColumnType("integer");

                            b1.Property<bool>("DisplayAttributeCombinationImagesOnly")
                                .HasColumnType("boolean");

                            b1.Property<int>("LowStockActivityId")
                                .HasColumnType("integer");

                            b1.Property<int>("ManageInventoryMethodId")
                                .HasColumnType("integer");

                            b1.Property<int>("MinStockQuantity")
                                .HasColumnType("integer");

                            b1.Property<int>("NotifyAdminForQuantityBelow")
                                .HasColumnType("integer");

                            b1.Property<int>("OrderMaximumQuantity")
                                .HasColumnType("integer");

                            b1.Property<int>("OrderMinimumQuantity")
                                .HasColumnType("integer");

                            b1.Property<int>("StockQuantity")
                                .HasColumnType("integer");

                            b1.Property<int>("WarehouseId")
                                .HasColumnType("integer");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductInventories", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.Lifecycle", "Lifecycle", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<string>("BatchNumber")
                                .HasColumnType("text");

                            b1.Property<DateTime?>("ExpirationDate")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<DateTime?>("ManufactureDate")
                                .HasColumnType("timestamp with time zone");

                            b1.Property<string>("SerialNumber")
                                .HasColumnType("text");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductLifecycles", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.PhysicalAttributes", "PhysicalAttributes", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<string>("Color")
                                .HasColumnType("text");

                            b1.Property<decimal>("Height")
                                .HasColumnType("numeric");

                            b1.Property<decimal>("Length")
                                .HasColumnType("numeric");

                            b1.Property<string>("Material")
                                .HasColumnType("text");

                            b1.Property<string>("PackagingType")
                                .HasColumnType("text");

                            b1.Property<string>("Size")
                                .HasColumnType("text");

                            b1.Property<decimal>("Weight")
                                .HasColumnType("numeric");

                            b1.Property<decimal>("Width")
                                .HasColumnType("numeric");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductPhysicalAttributes", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.Price", "Price", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<decimal>("BasepriceAmount")
                                .HasColumnType("numeric");

                            b1.Property<decimal>("BasepriceBaseAmount")
                                .HasColumnType("numeric");

                            b1.Property<int>("BasepriceBaseUnitId")
                                .HasColumnType("integer");

                            b1.Property<bool>("BasepriceEnabled")
                                .HasColumnType("boolean");

                            b1.Property<int>("BasepriceUnitId")
                                .HasColumnType("integer");

                            b1.Property<bool>("CallForPrice")
                                .HasColumnType("boolean");

                            b1.Property<decimal>("CurrentPrice")
                                .HasColumnType("numeric");

                            b1.Property<bool>("CustomerEntersPrice")
                                .HasColumnType("boolean");

                            b1.Property<decimal>("MaximumCustomerEnteredPrice")
                                .HasColumnType("numeric");

                            b1.Property<decimal>("MinimumCustomerEnteredPrice")
                                .HasColumnType("numeric");

                            b1.Property<decimal>("OldPrice")
                                .HasColumnType("numeric");

                            b1.Property<decimal>("ProductCost")
                                .HasColumnType("numeric");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductPrices", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.RecurringProduct", "RecurringProduct", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<bool>("IsRecurring")
                                .HasColumnType("boolean");

                            b1.Property<int>("RecurringCycleLength")
                                .HasColumnType("integer");

                            b1.Property<int>("RecurringCyclePeriodId")
                                .HasColumnType("integer");

                            b1.Property<int>("RecurringTotalCycles")
                                .HasColumnType("integer");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductRecurrings", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.RentalProduct", "RentalProduct", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<bool>("IsRental")
                                .HasColumnType("boolean");

                            b1.Property<int>("RentalPriceLength")
                                .HasColumnType("integer");

                            b1.Property<int>("RentalPricePeriodId")
                                .HasColumnType("integer");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductRentals", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.Shipping", "Shipping", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<decimal>("AdditionalShippingCharge")
                                .HasColumnType("numeric");

                            b1.Property<bool>("IsFreeShipping")
                                .HasColumnType("boolean");

                            b1.Property<bool>("IsShipEnabled")
                                .HasColumnType("boolean");

                            b1.Property<bool>("ShipSeparately")
                                .HasColumnType("boolean");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductShippings", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("Domain.Entities.Product.Tax", "Tax", b1 =>
                        {
                            b1.Property<int>("ProductId")
                                .HasColumnType("integer");

                            b1.Property<bool>("IsTaxExempt")
                                .HasColumnType("boolean");

                            b1.Property<int>("TaxCategoryId")
                                .HasColumnType("integer");

                            b1.HasKey("ProductId");

                            b1.ToTable("ProductTaxes", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Availability");

                    b.Navigation("ComplianceAndStandards");

                    b.Navigation("DownloadableProduct");

                    b.Navigation("GiftCard");

                    b.Navigation("Inventory");

                    b.Navigation("Lifecycle");

                    b.Navigation("PhysicalAttributes");

                    b.Navigation("Price");

                    b.Navigation("RecurringProduct");

                    b.Navigation("RentalProduct");

                    b.Navigation("Shipping");

                    b.Navigation("Tax");
                });
#pragma warning restore 612, 618
        }
    }
}
