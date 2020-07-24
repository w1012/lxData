﻿// <auto-generated />
using System;
using Lx.Infrastruct.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

namespace Lx.Infrastruct.Data.Migrations
{
    [DbContext(typeof(LxContext))]
    partial class LxContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Oracle:ValueGenerationStrategy", OracleValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            modelBuilder.Entity("Lx.Domain.Models.Login", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("I_ID");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("D_CREATETIME");

                    b.Property<int>("Lock")
                        .HasColumnName("i_LOCK");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasColumnName("C_LOGINNAME")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NiceName")
                        .IsRequired()
                        .HasColumnName("C_NICENAME")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnName("C_PASSWORD")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("LX_LOGIN_USER");
                });

            modelBuilder.Entity("Lx.Domain.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnName("BIRTHDATE");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMAIL")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnName("PHONE")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(11);

                    b.HasKey("Id");

                    b.ToTable("STUDENT");
                });

            modelBuilder.Entity("Lx.Domain.Models.Student", b =>
                {
                    b.OwnsOne("Lx.Domain.Models.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("StudentId");

                            b1.Property<string>("City")
                                .HasColumnName("ADDRESS_CITY");

                            b1.Property<string>("County")
                                .HasColumnName("ADDRESS_COUNTY");

                            b1.Property<string>("Province")
                                .HasColumnName("ADDRESS_PROVINCE");

                            b1.Property<string>("Street")
                                .HasColumnName("ADDRESS_STREET");

                            b1.HasKey("StudentId");

                            b1.ToTable("STUDENT");

                            b1.HasOne("Lx.Domain.Models.Student")
                                .WithOne("Address")
                                .HasForeignKey("Lx.Domain.Models.Address", "StudentId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
