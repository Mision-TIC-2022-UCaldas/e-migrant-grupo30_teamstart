﻿// <auto-generated />
using Emigrant.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Emigrant.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20211127132223_Migracioninicial")]
    partial class Migracioninicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Emigrant.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccionactual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fechanacimiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("numeroidentificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("paisorigen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("situacionlaboral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipodocumento")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
