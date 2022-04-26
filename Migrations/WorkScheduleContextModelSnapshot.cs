﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorkScheduleSolution.Data;

namespace WorkScheduleSolution.Migrations
{
    [DbContext(typeof(WorkScheduleContext))]
    partial class WorkScheduleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorkScheduleSolution.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.EmployeeSkill", b =>
                {
                    b.Property<int>("EmployeeSkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<decimal>("HourlyWage")
                        .HasColumnType("money");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("SkillID")
                        .HasColumnType("int");

                    b.Property<int?>("YearsOfExperience")
                        .HasColumnType("int");

                    b.HasKey("EmployeeSkillID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("SkillID");

                    b.ToTable("EmployeeSkills");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("char(12)");

                    b.Property<string>("Province")
                        .HasColumnType("nchar(2)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.PlacementContract", b =>
                {
                    b.Property<int>("PlacementContractID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PlacementContractID");

                    b.HasIndex("LocationID");

                    b.ToTable("PlacementContracts");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Day")
                        .HasColumnType("date");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<decimal>("HourlyWage")
                        .HasColumnType("money");

                    b.Property<bool>("OverTime")
                        .HasColumnType("bit");

                    b.Property<int>("ShiftID")
                        .HasColumnType("int");

                    b.HasKey("ScheduleID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShiftID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Shift", b =>
                {
                    b.Property<int>("ShiftID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte>("NumberOfEmployees")
                        .HasColumnType("tinyint");

                    b.Property<int>("PlacementContractID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("ShiftID");

                    b.HasIndex("PlacementContractID");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiresTicket")
                        .HasColumnType("int");

                    b.HasKey("SkillID");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.EmployeeSkill", b =>
                {
                    b.HasOne("WorkScheduleSolution.Entities.Employee", "Employee")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkScheduleSolution.Entities.Skill", "Skill")
                        .WithMany("EmployeeSkills")
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.PlacementContract", b =>
                {
                    b.HasOne("WorkScheduleSolution.Entities.Location", "Location")
                        .WithMany("PlacementContracts")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Schedule", b =>
                {
                    b.HasOne("WorkScheduleSolution.Entities.Employee", "Employee")
                        .WithMany("Schedules")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkScheduleSolution.Entities.Shift", "Shift")
                        .WithMany("Schedules")
                        .HasForeignKey("ShiftID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Shift", b =>
                {
                    b.HasOne("WorkScheduleSolution.Entities.PlacementContract", "PlacementContract")
                        .WithMany("Shifts")
                        .HasForeignKey("PlacementContractID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlacementContract");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Employee", b =>
                {
                    b.Navigation("EmployeeSkills");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Location", b =>
                {
                    b.Navigation("PlacementContracts");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.PlacementContract", b =>
                {
                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Shift", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("WorkScheduleSolution.Entities.Skill", b =>
                {
                    b.Navigation("EmployeeSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
