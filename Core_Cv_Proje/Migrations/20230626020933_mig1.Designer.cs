﻿// <auto-generated />
using Core_Cv_Proje.DAL.ApiContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Core_Cv_Proje.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230626020933_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core_Cv_Proje.DAL.Entity.Catagory", b =>
                {
                    b.Property<int>("CatagoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatagoryID"), 1L, 1);

                    b.Property<string>("CatagoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatagoryID");

                    b.ToTable("Catagories");
                });
#pragma warning restore 612, 618
        }
    }
}
