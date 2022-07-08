﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Work.Services;

#nullable disable

namespace Work.Migrations
{
    [DbContext(typeof(WorkDbContext))]
    partial class WorkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Work.Models.Applicant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("Work.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Work.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("StreetId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StreetId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Work.Models.Education", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Educations");
                });

            modelBuilder.Entity("Work.Models.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("CountJobs")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("NameCompany")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("Work.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Work.Models.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("Work.Models.Resume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ApplicantId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("EducationId")
                        .HasColumnType("integer");

                    b.Property<int>("ExperienceId")
                        .HasColumnType("integer");

                    b.Property<int>("SalaryId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeOfEmploymentsId")
                        .HasColumnType("integer");

                    b.Property<int>("VacancyIsSuitableId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicantId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.HasIndex("EducationId");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("SalaryId");

                    b.HasIndex("TypeOfEmploymentsId");

                    b.HasIndex("VacancyIsSuitableId");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Work.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Work.Models.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<decimal>("Max")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("Min")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("Id");

                    b.ToTable("Salary");
                });

            modelBuilder.Entity("Work.Models.Street", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Street");
                });

            modelBuilder.Entity("Work.Models.TypeOfEmployments", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeOfEmployments");
                });

            modelBuilder.Entity("Work.Models.Vacancy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriesId")
                        .HasColumnType("integer");

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("EducationId")
                        .HasColumnType("integer");

                    b.Property<int?>("EmployerId")
                        .HasColumnType("integer");

                    b.Property<int?>("ExperiencesId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("SalaryId")
                        .HasColumnType("integer");

                    b.Property<int?>("TypeOfEmploymentsId")
                        .HasColumnType("integer");

                    b.Property<int?>("VacancyIsSuitableId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoriesId");

                    b.HasIndex("CityId");

                    b.HasIndex("EducationId");

                    b.HasIndex("EmployerId");

                    b.HasIndex("ExperiencesId");

                    b.HasIndex("SalaryId");

                    b.HasIndex("TypeOfEmploymentsId");

                    b.HasIndex("VacancyIsSuitableId");

                    b.ToTable("Vacancies");
                });

            modelBuilder.Entity("Work.Models.VacancyIsSuitable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VacancyIsSuitables");
                });

            modelBuilder.Entity("Work.Models.Applicant", b =>
                {
                    b.HasOne("Work.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Work.Models.City", b =>
                {
                    b.HasOne("Work.Models.Street", "Street")
                        .WithMany()
                        .HasForeignKey("StreetId");

                    b.Navigation("Street");
                });

            modelBuilder.Entity("Work.Models.Employer", b =>
                {
                    b.HasOne("Work.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Work.Models.Resume", b =>
                {
                    b.HasOne("Work.Models.Applicant", null)
                        .WithMany("Resumes")
                        .HasForeignKey("ApplicantId");

                    b.HasOne("Work.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work.Models.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work.Models.TypeOfEmployments", "TypeOfEmployments")
                        .WithMany()
                        .HasForeignKey("TypeOfEmploymentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Work.Models.VacancyIsSuitable", "VacancyIsSuitable")
                        .WithMany()
                        .HasForeignKey("VacancyIsSuitableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("City");

                    b.Navigation("Education");

                    b.Navigation("Experience");

                    b.Navigation("Salary");

                    b.Navigation("TypeOfEmployments");

                    b.Navigation("VacancyIsSuitable");
                });

            modelBuilder.Entity("Work.Models.Vacancy", b =>
                {
                    b.HasOne("Work.Models.Category", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesId");

                    b.HasOne("Work.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("Work.Models.Education", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId");

                    b.HasOne("Work.Models.Employer", null)
                        .WithMany("Vacancies")
                        .HasForeignKey("EmployerId");

                    b.HasOne("Work.Models.Experience", "Experiences")
                        .WithMany()
                        .HasForeignKey("ExperiencesId");

                    b.HasOne("Work.Models.Salary", "Salary")
                        .WithMany()
                        .HasForeignKey("SalaryId");

                    b.HasOne("Work.Models.TypeOfEmployments", "TypeOfEmployments")
                        .WithMany()
                        .HasForeignKey("TypeOfEmploymentsId");

                    b.HasOne("Work.Models.VacancyIsSuitable", "VacancyIsSuitable")
                        .WithMany()
                        .HasForeignKey("VacancyIsSuitableId");

                    b.Navigation("Categories");

                    b.Navigation("City");

                    b.Navigation("Education");

                    b.Navigation("Experiences");

                    b.Navigation("Salary");

                    b.Navigation("TypeOfEmployments");

                    b.Navigation("VacancyIsSuitable");
                });

            modelBuilder.Entity("Work.Models.Applicant", b =>
                {
                    b.Navigation("Resumes");
                });

            modelBuilder.Entity("Work.Models.Employer", b =>
                {
                    b.Navigation("Vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}
