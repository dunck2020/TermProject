﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject_S1.Models;

namespace TermProject_S1.Migrations
{
    [DbContext(typeof(SwiftMaidsContext))]
    [Migration("20211017224230_SecondModel")]
    partial class SecondModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TermProject_S1.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("CustomerGradeID")
                        .HasColumnType("int");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.HasIndex("CustomerGradeID");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "1550 Main St",
                            City = "Traverse City",
                            CustomerGradeID = 1,
                            Discount = 0.10000000000000001,
                            EmailAddress = "jacksfishmarket@hotmail.com",
                            Name = "Jack's Fish Market",
                            PhoneNumber = "231-555-9999",
                            State = "MI",
                            ZipCode = "49684"
                        },
                        new
                        {
                            Id = 2,
                            Address = "230 Business Park Dr",
                            City = "Traverse City",
                            CustomerGradeID = 3,
                            Discount = 0.0,
                            Name = "ProSource Cabinets",
                            PhoneNumber = "231-555-5555",
                            State = "MI",
                            ZipCode = "49686"
                        },
                        new
                        {
                            Id = 3,
                            Address = "231 8th St",
                            City = "Traverse City",
                            CustomerGradeID = 2,
                            Discount = 0.0,
                            Name = "Up North Flower Shop",
                            State = "MI",
                            ZipCode = "49684"
                        });
                });

            modelBuilder.Entity("TermProject_S1.Models.CustomerGrade", b =>
                {
                    b.Property<int>("CustomerGradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerSalesLevel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerGradeID");

                    b.ToTable("CustomerGrades");

                    b.HasData(
                        new
                        {
                            CustomerGradeID = 1,
                            CustomerSalesLevel = "A"
                        },
                        new
                        {
                            CustomerGradeID = 2,
                            CustomerSalesLevel = "B"
                        },
                        new
                        {
                            CustomerGradeID = 3,
                            CustomerSalesLevel = "C"
                        },
                        new
                        {
                            CustomerGradeID = 4,
                            CustomerSalesLevel = "D"
                        },
                        new
                        {
                            CustomerGradeID = 5,
                            CustomerSalesLevel = "E"
                        });
                });

            modelBuilder.Entity("TermProject_S1.Models.Customer", b =>
                {
                    b.HasOne("TermProject_S1.Models.CustomerGrade", "CustomerGrade")
                        .WithMany()
                        .HasForeignKey("CustomerGradeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
