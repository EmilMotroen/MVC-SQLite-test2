﻿// <auto-generated />
using System;
using MVC_SQLite_test2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_SQLite_test2.Migrations
{
    [DbContext(typeof(VærDataContext))]
    [Migration("20240511224610_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_SQLite_test2.Models.VærData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bruker")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Dato")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kommentar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Temperatur")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VærData");
                });
#pragma warning restore 612, 618
        }
    }
}