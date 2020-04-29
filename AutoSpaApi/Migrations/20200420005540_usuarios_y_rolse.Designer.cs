﻿// <auto-generated />
using System;
using AutoSpaApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoSpaApi.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20200420005540_usuarios_y_rolse")]
    partial class usuarios_y_rolse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoSpaApi.Models.Perfil", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<string>("datos_vehiculos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("num_tarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("titular_tarjeta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid")
                        .IsUnique();

                    b.ToTable("perfiles");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid")
                        .IsUnique();

                    b.ToTable("roles");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNac")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pass")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Perfil", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Usuario", null)
                        .WithOne("perfil")
                        .HasForeignKey("AutoSpaApi.Models.Perfil", "Usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.Rol", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Usuario", null)
                        .WithOne("rol")
                        .HasForeignKey("AutoSpaApi.Models.Rol", "Usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
