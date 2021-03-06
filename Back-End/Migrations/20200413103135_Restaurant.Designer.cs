﻿// <auto-generated />
using JiaDungDao.Connection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JiaDungDao.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200413103135_Restaurant")]
    partial class Restaurant
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Back_End.Models.Restaurant", b =>
                {
                    b.Property<int>("RestaurantID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("r_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("r_tel")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("RestaurantID");

                    b.ToTable("Restaurant");
                });
#pragma warning restore 612, 618
        }
    }
}
