﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Task1.DbContexts;

#nullable disable

namespace Task1.Migrations
{
    [DbContext(typeof(DbInfo))]
    partial class DbInfoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Task1.Entities.DbClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Field1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Field2")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Field3")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.ToTable("DbClasses");
                });
#pragma warning restore 612, 618
        }
    }
}
