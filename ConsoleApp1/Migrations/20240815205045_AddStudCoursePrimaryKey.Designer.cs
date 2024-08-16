﻿// <auto-generated />
using System;
using ConsoleApp1.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    [Migration("20240815205045_AddStudCoursePrimaryKey")]
    partial class AddStudCoursePrimaryKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp1.Entites.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Duration")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ConsoleApp1.Entites.Course_Inst", b =>
                {
                    b.Property<int>("inst_id")
                        .HasColumnType("int");

                    b.Property<int>("Course_Id")
                        .HasColumnType("int");

                    b.Property<string>("evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("inst_id", "Course_Id");

                    b.ToTable("course_Insts");
                });

            modelBuilder.Entity("ConsoleApp1.Entites.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("HiringDate")
                        .HasColumnType("int");

                    b.Property<int>("Ins_ID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ConsoleApp1.Entites.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bouns")
                        .HasColumnType("int");

                    b.Property<int>("Dept_ID")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("HourRate")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ConsoleApp1.Entites.Stud_Course", b =>
                {
                    b.Property<int>("studID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<decimal>("Grade")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("studID", "CourseID");

                    b.ToTable("Stud_Course");
                });

            modelBuilder.Entity("ConsoleApp1.Entites.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Dep_id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("ConsoleApp1.Entites.Topic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Topic");
                });
#pragma warning restore 612, 618
        }
    }
}
