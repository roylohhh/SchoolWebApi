﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolWebApi.Data;

#nullable disable

namespace SchoolWebApi.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20240220043343_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolWebApi.Models.Course", b =>
                {
                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Credit")
                        .HasColumnType("int");

                    b.Property<string>("DepartmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("SchoolWebApi.Models.CourseAssignment", b =>
                {
                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("InstructorID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CourseID", "InstructorID");

                    b.HasIndex("InstructorID");

                    b.ToTable("CourseAssignments");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Department", b =>
                {
                    b.Property<string>("DepartmentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Budget")
                        .HasColumnType("money");

                    b.Property<string>("InstructorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DepartmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Enrolment", b =>
                {
                    b.Property<int>("EnrolmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrolmentID"));

                    b.Property<string>("CourseID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EnrolmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrolments");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Instructor", b =>
                {
                    b.Property<string>("InstructorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstructorID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("SchoolWebApi.Models.OfficeAssignment", b =>
                {
                    b.Property<string>("InstructorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("InstructorID");

                    b.ToTable("OfficeAssignments");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Student", b =>
                {
                    b.Property<string>("StudentID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EnrolmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Course", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("SchoolWebApi.Models.CourseAssignment", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Course", "Course")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SchoolWebApi.Models.Instructor", "Instructor")
                        .WithMany("CourseAssignments")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Department", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorID");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Enrolment", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Course", "Course")
                        .WithMany("Enrolments")
                        .HasForeignKey("CourseID");

                    b.HasOne("SchoolWebApi.Models.Student", "Student")
                        .WithMany("Enrolments")
                        .HasForeignKey("StudentID");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SchoolWebApi.Models.OfficeAssignment", b =>
                {
                    b.HasOne("SchoolWebApi.Models.Instructor", "Instructor")
                        .WithOne("OfficeAssignment")
                        .HasForeignKey("SchoolWebApi.Models.OfficeAssignment", "InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Course", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("Enrolments");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Department", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Instructor", b =>
                {
                    b.Navigation("CourseAssignments");

                    b.Navigation("OfficeAssignment");
                });

            modelBuilder.Entity("SchoolWebApi.Models.Student", b =>
                {
                    b.Navigation("Enrolments");
                });
#pragma warning restore 612, 618
        }
    }
}
