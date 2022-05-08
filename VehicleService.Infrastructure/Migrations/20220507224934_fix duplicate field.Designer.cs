﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VehicleService.Infrastructure;

namespace VehicleService.Infrastructure.Migrations
{
    [DbContext(typeof(VehicleServiceContext))]
    [Migration("20220507224934_fix duplicate field")]
    partial class fixduplicatefield
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VehicleService.Domain.AggregatesModel.OrderAggregate.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrackingCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TrackingCode")
                        .IsUnique();

                    b.HasIndex("VehicleId");

                    b.HasIndex("VehicleId1");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("VehicleService.Domain.AggregatesModel.VehicleAggregate.HistoricalLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.HasIndex("VehicleId1");

                    b.ToTable("HistoricalLocations");
                });

            modelBuilder.Entity("VehicleService.Domain.AggregatesModel.VehicleAggregate.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LicensePlate")
                        .IsUnique();

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 319, DateTimeKind.Local).AddTicks(9456),
                            Latitude = 0.0,
                            LicensePlate = "0001",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 323, DateTimeKind.Local).AddTicks(2924)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3629),
                            Latitude = 0.0,
                            LicensePlate = "0002",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3657)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3935),
                            Latitude = 0.0,
                            LicensePlate = "0003",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3941)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3974),
                            Latitude = 0.0,
                            LicensePlate = "0004",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3977)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3995),
                            Latitude = 0.0,
                            LicensePlate = "0005",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(3998)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4090),
                            Latitude = 0.0,
                            LicensePlate = "0006",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4094)
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4117),
                            Latitude = 0.0,
                            LicensePlate = "0007",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4120)
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4138),
                            Latitude = 0.0,
                            LicensePlate = "0008",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4141)
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4158),
                            Latitude = 0.0,
                            LicensePlate = "0009",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4161)
                        },
                        new
                        {
                            Id = 10,
                            CreatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4179),
                            Latitude = 0.0,
                            LicensePlate = "0010",
                            Longitude = 0.0,
                            UpdatedAt = new DateTime(2022, 5, 8, 0, 49, 34, 324, DateTimeKind.Local).AddTicks(4182)
                        });
                });

            modelBuilder.Entity("VehicleService.Domain.AggregatesModel.OrderAggregate.Order", b =>
                {
                    b.HasOne("VehicleService.Domain.AggregatesModel.VehicleAggregate.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleService.Domain.AggregatesModel.VehicleAggregate.Vehicle", null)
                        .WithMany("Orders")
                        .HasForeignKey("VehicleId1");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("VehicleService.Domain.AggregatesModel.VehicleAggregate.HistoricalLocation", b =>
                {
                    b.HasOne("VehicleService.Domain.AggregatesModel.VehicleAggregate.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VehicleService.Domain.AggregatesModel.VehicleAggregate.Vehicle", null)
                        .WithMany("HistoricalLocations")
                        .HasForeignKey("VehicleId1");
                });

            modelBuilder.Entity("VehicleService.Domain.AggregatesModel.VehicleAggregate.Vehicle", b =>
                {
                    b.Navigation("HistoricalLocations");

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
