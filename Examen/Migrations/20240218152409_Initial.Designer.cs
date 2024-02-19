﻿// <auto-generated />
using System;
using Examen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Examen.Migrations
{
    [DbContext(typeof(ExamenContext))]
    [Migration("20240218152409_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Examen.Data.Models.Materie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Denumire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NrOreSapt")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("Examen.Data.Models.Profesor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenume")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipProfesor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("Examen.Data.Models.ProfesorMaterie", b =>
                {
                    b.Property<Guid>("IdProfesor")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMaterie")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdProfesor", "IdMaterie");

                    b.HasIndex("IdMaterie");

                    b.ToTable("ProfesorMaterii");
                });

            modelBuilder.Entity("Examen.Data.Models.ProfesorMaterie", b =>
                {
                    b.HasOne("Examen.Data.Models.Materie", "Materie")
                        .WithMany("profesorMaterii")
                        .HasForeignKey("IdMaterie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Examen.Data.Models.Profesor", "Profesor")
                        .WithMany("profesorMaterii")
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Materie");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("Examen.Data.Models.Materie", b =>
                {
                    b.Navigation("profesorMaterii");
                });

            modelBuilder.Entity("Examen.Data.Models.Profesor", b =>
                {
                    b.Navigation("profesorMaterii");
                });
#pragma warning restore 612, 618
        }
    }
}
