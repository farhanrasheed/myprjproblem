﻿// <auto-generated />
using System;
using Employeeprj.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Employeeprj.Migrations
{
    [DbContext(typeof(MYPRJContext))]
    [Migration("20210727074053_abc")]
    partial class abc
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Employeeprj.Models.NATIONALITY", b =>
                {
                    b.Property<int>("NATId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("NAT_CODE")
                        .HasColumnType("float");

                    b.HasKey("NATId");

                    b.ToTable("NATIONALITY");
                });

            modelBuilder.Entity("Employeeprj.Models.PYALLOW_SCALE", b =>
                {
                    b.Property<int>("ALLOWSCHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("ALW_CODE")
                        .HasColumnType("float");

                    b.Property<string>("ALW_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AMOUNT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RANKId")
                        .HasColumnType("int");

                    b.Property<int?>("STOP_ID")
                        .HasColumnType("int");

                    b.HasKey("ALLOWSCHId");

                    b.HasIndex("RANKId");

                    b.ToTable("PYALLOW_SCALE");
                });

            modelBuilder.Entity("Employeeprj.Models.PYALW", b =>
                {
                    b.Property<int>("ALWId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ALW_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ALW_TYPE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AMOUNT")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double?>("EMP_NO")
                        .HasColumnType("float");

                    b.Property<int>("EmpId")
                        .HasColumnType("int");

                    b.Property<int?>("STOP_ID")
                        .HasColumnType("int");

                    b.HasKey("ALWId");

                    b.HasIndex("EmpId");

                    b.ToTable("PYALW");
                });

            modelBuilder.Entity("Employeeprj.Models.PYDEPT", b =>
                {
                    b.Property<int>("DEPId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("DEP_CODE")
                        .HasColumnType("float");

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SECId")
                        .HasColumnType("int");

                    b.HasKey("DEPId");

                    b.HasIndex("SECId");

                    b.ToTable("PYDEPT");
                });

            modelBuilder.Entity("Employeeprj.Models.PYEmployee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("DEP_CODE")
                        .HasColumnType("float");

                    b.Property<DateTime>("DT_OF_BRTH")
                        .HasColumnType("datetime2");

                    b.Property<double?>("EMP_NO")
                        .HasColumnType("float");

                    b.Property<string>("MARITAL_ST")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("NAT_CODE")
                        .HasColumnType("float");

                    b.Property<string>("REASON")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("RNK_CODE")
                        .HasColumnType("float");

                    b.Property<double?>("SEC_CODE")
                        .HasColumnType("float");

                    b.Property<string>("SEX")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("STOP_ID")
                        .HasColumnType("int");

                    b.HasKey("EmpId");

                    b.ToTable("PYEmployee");
                });

            modelBuilder.Entity("Employeeprj.Models.PYSCM", b =>
                {
                    b.Property<int>("SCMId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SCHId")
                        .HasColumnType("int");

                    b.Property<double?>("SCM_CODE")
                        .HasColumnType("float");

                    b.HasKey("SCMId");

                    b.HasIndex("SCHId");

                    b.ToTable("PYSCM");
                });

            modelBuilder.Entity("Employeeprj.Models.Rank", b =>
                {
                    b.Property<int>("RANKId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("RNK_CODE")
                        .HasColumnType("float");

                    b.Property<string>("RNK_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RANKId");

                    b.ToTable("Rank");
                });

            modelBuilder.Entity("Employeeprj.Models.SALARY_CHANGE", b =>
                {
                    b.Property<int>("SALCHANGEId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double?>("EMP_NO")
                        .HasColumnType("float");

                    b.Property<double?>("NEW_BASIC")
                        .HasColumnType("float");

                    b.Property<double?>("OLD_BASIC")
                        .HasColumnType("float");

                    b.Property<DateTime>("TRN_DATE")
                        .HasColumnType("datetime2");

                    b.Property<string>("TRN_DESC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TRN_PERIOD")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SALCHANGEId");

                    b.ToTable("SALARY_CHANGE");
                });

            modelBuilder.Entity("Employeeprj.Models.SCH_CODE", b =>
                {
                    b.Property<int>("SCHId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BASIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SECH_CODE")
                        .HasColumnType("float");

                    b.Property<string>("STEP_CODE")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SCHId");

                    b.ToTable("SCH_CODE");
                });

            modelBuilder.Entity("Employeeprj.Models.SECTION", b =>
                {
                    b.Property<int>("SECId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DESCRIPTION")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("SEC_CODE")
                        .HasColumnType("float");

                    b.HasKey("SECId");

                    b.ToTable("SECTION");
                });

            modelBuilder.Entity("Employeeprj.Models.PYALLOW_SCALE", b =>
                {
                    b.HasOne("Employeeprj.Models.Rank", "Rank")
                        .WithMany()
                        .HasForeignKey("RANKId");

                    b.Navigation("Rank");
                });

            modelBuilder.Entity("Employeeprj.Models.PYALW", b =>
                {
                    b.HasOne("Employeeprj.Models.PYEmployee", "PYEmployee")
                        .WithMany()
                        .HasForeignKey("EmpId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PYEmployee");
                });

            modelBuilder.Entity("Employeeprj.Models.PYDEPT", b =>
                {
                    b.HasOne("Employeeprj.Models.SECTION", "SECTION")
                        .WithMany()
                        .HasForeignKey("SECId");

                    b.Navigation("SECTION");
                });

            modelBuilder.Entity("Employeeprj.Models.PYSCM", b =>
                {
                    b.HasOne("Employeeprj.Models.SCH_CODE", "SCH_CODE")
                        .WithMany()
                        .HasForeignKey("SCHId");

                    b.Navigation("SCH_CODE");
                });
#pragma warning restore 612, 618
        }
    }
}