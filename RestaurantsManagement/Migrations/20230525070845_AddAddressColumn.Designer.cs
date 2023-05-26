﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantsManagement.Data;

#nullable disable

namespace RestaurantsManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230525070845_AddAddressColumn")]
    partial class AddAddressColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.4.23259.3");

            modelBuilder.Entity("RestaurantsManagement.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .HasColumnType("TEXT");

                    b.Property<int>("ContactNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cuisine")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantLocation")
                        .HasColumnType("TEXT");

                    b.Property<string>("RestaurantName")
                        .HasColumnType("TEXT");

                    b.Property<string>("SignatureDish")
                        .HasColumnType("TEXT");

                    b.Property<float>("StarRating")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}
