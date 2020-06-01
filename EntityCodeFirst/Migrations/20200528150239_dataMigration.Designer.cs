﻿// <auto-generated />
using EntityCodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityCodeFirst.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20200528150239_dataMigration")]
    partial class dataMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityCodeFirst.Context.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Budget")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 1000000000000.0,
                            Location = "Midland, MI",
                            Name = "Research & Development",
                            Type = "Science"
                        },
                        new
                        {
                            Id = 2,
                            Budget = 2000000000000.0,
                            Location = "Dhaka, Bangladesh",
                            Name = "Human Resources",
                            Type = "Administrative"
                        },
                        new
                        {
                            Id = 3,
                            Budget = 53.0,
                            Location = "Party City, USA",
                            Name = "Fun Department",
                            Type = "Administrative"
                        });
                });

            modelBuilder.Entity("EntityCodeFirst.Context.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(31)")
                        .HasMaxLength(31);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Email = "venkman@ghostbusters.co",
                            FirstName = "Peter",
                            LastName = "Venkman"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Email = "stantz@ghostbusters.co",
                            FirstName = "Raymond",
                            LastName = "Stantz"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 2,
                            Email = "spengler@ghostbusters.co",
                            FirstName = "Egon",
                            LastName = "Spengler"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 2,
                            Email = "slimer@ghosts.co",
                            FirstName = "Slimer"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 3,
                            Email = "barrett@nyphil.co",
                            FirstName = "Dana",
                            LastName = "Barrett"
                        });
                });

            modelBuilder.Entity("EntityCodeFirst.Context.Employee", b =>
                {
                    b.HasOne("EntityCodeFirst.Context.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
