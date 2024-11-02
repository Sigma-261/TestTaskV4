﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestTaskV4;

#nullable disable

namespace TestTaskV4.Migrations
{
    [DbContext(typeof(TubeContext))]
    partial class TubeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TestTaskV4.Models.Pack", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATE_AT");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UPDATE_AT");

                    b.Property<Guid>("IdTube")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_TUBE");

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("NUMBER");

                    b.HasKey("Guid");

                    b.HasIndex("IdTube");

                    b.ToTable("PACK");
                });

            modelBuilder.Entity("TestTaskV4.Models.SteelGrade", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATE_AT");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UPDATE_AT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("NAME");

                    b.HasKey("Guid");

                    b.ToTable("STEEL_GRADE");
                });

            modelBuilder.Entity("TestTaskV4.Models.Tube", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CREATE_AT");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UPDATE_AT");

                    b.Property<Guid>("IdGrade")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_GRADE");

                    b.Property<bool>("IsDefect")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_DEFECT");

                    b.Property<bool>("IsPacked")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_PACKED");

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("NUMBER");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric")
                        .HasColumnName("WEIGHT");

                    b.HasKey("Guid");

                    b.HasIndex("IdGrade");

                    b.ToTable("TUBE");
                });

            modelBuilder.Entity("TestTaskV4.Models.Pack", b =>
                {
                    b.HasOne("TestTaskV4.Models.Tube", "Tube")
                        .WithMany()
                        .HasForeignKey("IdTube")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tube");
                });

            modelBuilder.Entity("TestTaskV4.Models.Tube", b =>
                {
                    b.HasOne("TestTaskV4.Models.SteelGrade", "Grade")
                        .WithMany()
                        .HasForeignKey("IdGrade")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grade");
                });
#pragma warning restore 612, 618
        }
    }
}
