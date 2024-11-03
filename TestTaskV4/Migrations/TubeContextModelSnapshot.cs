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

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("NUMBER");

                    b.HasKey("Guid");

                    b.ToTable("PACK");
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

                    b.Property<int>("Grade")
                        .HasColumnType("integer")
                        .HasColumnName("GRADE");

                    b.Property<Guid?>("IdPack")
                        .HasColumnType("uuid")
                        .HasColumnName("ID_PACK");

                    b.Property<bool>("IsDefect")
                        .HasColumnType("boolean")
                        .HasColumnName("IS_DEFECT");

                    b.Property<int>("Number")
                        .HasColumnType("integer")
                        .HasColumnName("NUMBER");

                    b.Property<decimal>("Size")
                        .HasColumnType("numeric")
                        .HasColumnName("SIZE");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric")
                        .HasColumnName("WEIGHT");

                    b.HasKey("Guid");

                    b.HasIndex("IdPack");

                    b.ToTable("TUBE");
                });

            modelBuilder.Entity("TestTaskV4.Models.Tube", b =>
                {
                    b.HasOne("TestTaskV4.Models.Pack", "Pack")
                        .WithMany("Tubes")
                        .HasForeignKey("IdPack");

                    b.Navigation("Pack");
                });

            modelBuilder.Entity("TestTaskV4.Models.Pack", b =>
                {
                    b.Navigation("Tubes");
                });
#pragma warning restore 612, 618
        }
    }
}
