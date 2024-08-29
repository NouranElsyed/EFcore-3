﻿// <auto-generated />
using EFcore_3.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFcore_3.Migrations.InhertanceDb
{
    [DbContext(typeof(InhertanceDbContext))]
    [Migration("20240829060639_NewDataBaseInhertance")]
    partial class NewDataBaseInhertance
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFcore_3.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Emplyees", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("EFcore_3.Entities.FullTimeEmployee", b =>
                {
                    b.HasBaseType("EFcore_3.Entities.Employee");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.ToTable("FullTimeEmployees", (string)null);
                });

            modelBuilder.Entity("EFcore_3.Entities.PartTimeEmployee", b =>
                {
                    b.HasBaseType("EFcore_3.Entities.Employee");

                    b.Property<double>("HourRate")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfHours")
                        .HasColumnType("int");

                    b.ToTable("PartTimeEmployees", (string)null);
                });

            modelBuilder.Entity("EFcore_3.Entities.FullTimeEmployee", b =>
                {
                    b.HasOne("EFcore_3.Entities.Employee", null)
                        .WithOne()
                        .HasForeignKey("EFcore_3.Entities.FullTimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFcore_3.Entities.PartTimeEmployee", b =>
                {
                    b.HasOne("EFcore_3.Entities.Employee", null)
                        .WithOne()
                        .HasForeignKey("EFcore_3.Entities.PartTimeEmployee", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
