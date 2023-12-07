﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PORTAL2023.Models;

#nullable disable

namespace PORTAL2023.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231204015959_M01")]
    partial class M01
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PORTAL2023.Models.Despesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Conta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instituição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Despesas");
                });
#pragma warning restore 612, 618
        }
    }
}