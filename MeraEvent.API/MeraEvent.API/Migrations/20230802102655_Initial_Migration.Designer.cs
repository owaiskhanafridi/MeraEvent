﻿// <auto-generated />
using MeraEvent.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MeraEvent.API.Migrations
{
    [DbContext(typeof(MeraEventDBContext))]
    [Migration("20230802102655_Initial_Migration")]
    partial class Initial_Migration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MeraEvent.API.Models.Amenity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Amenities");
                });

            modelBuilder.Entity("MeraEvent.API.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rent")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Halls");
                });

            modelBuilder.Entity("MeraEvent.API.Models.HallAmenities", b =>
                {
                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<int>("AmenityId")
                        .HasColumnType("int");

                    b.Property<float>("ExtraCost")
                        .HasColumnType("real");

                    b.HasKey("HallId", "AmenityId");

                    b.HasIndex("AmenityId");

                    b.ToTable("HallAmenities");
                });

            modelBuilder.Entity("MeraEvent.API.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HallId")
                        .HasColumnType("int");

                    b.Property<string>("Landmark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HallId")
                        .IsUnique();

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MeraEvent.API.Models.HallAmenities", b =>
                {
                    b.HasOne("MeraEvent.API.Models.Amenity", "Amenity")
                        .WithMany("HallAmenities")
                        .HasForeignKey("AmenityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MeraEvent.API.Models.Hall", "Hall")
                        .WithMany("HallAmenities")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Amenity");

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("MeraEvent.API.Models.Location", b =>
                {
                    b.HasOne("MeraEvent.API.Models.Hall", "Hall")
                        .WithOne("Location")
                        .HasForeignKey("MeraEvent.API.Models.Location", "HallId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hall");
                });

            modelBuilder.Entity("MeraEvent.API.Models.Amenity", b =>
                {
                    b.Navigation("HallAmenities");
                });

            modelBuilder.Entity("MeraEvent.API.Models.Hall", b =>
                {
                    b.Navigation("HallAmenities");

                    b.Navigation("Location")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
