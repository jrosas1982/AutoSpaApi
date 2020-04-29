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
    [Migration("20200427025237_ModelConsultas")]
    partial class ModelConsultas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoSpaApi.Models.Categoria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Productosid")
                        .HasColumnType("int");

                    b.Property<string>("nombreCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Compra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Consulta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("consulta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tiutlo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("AutoSpaApi.Models.DetallesCompras", b =>
                {
                    b.Property<int>("Productoid")
                        .HasColumnType("int");

                    b.Property<int>("Compraid")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Productoid", "Compraid");

                    b.HasIndex("Compraid");

                    b.ToTable("DetallesCompras");
                });

            modelBuilder.Entity("AutoSpaApi.Models.DetallesReserva", b =>
                {
                    b.Property<int>("Servicioid")
                        .HasColumnType("int");

                    b.Property<int>("Reservaid")
                        .HasColumnType("int");

                    b.Property<decimal>("precioServicio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("turno")
                        .HasColumnType("datetime2");

                    b.HasKey("Servicioid", "Reservaid");

                    b.HasIndex("Reservaid");

                    b.ToTable("DetallesReserva");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Encuesta", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("preguntas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tipo_encuesta")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Encuesta");
                });

            modelBuilder.Entity("AutoSpaApi.Models.EncuestaPorUsuario", b =>
                {
                    b.Property<int>("Encuestaid")
                        .HasColumnType("int");

                    b.Property<int>("Usuarioid")
                        .HasColumnType("int");

                    b.HasKey("Encuestaid", "Usuarioid");

                    b.HasIndex("Usuarioid");

                    b.ToTable("EncuestaPorUsuario");
                });

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

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Categoriaid")
                        .HasColumnType("int");

                    b.Property<string>("descipcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("nombre")
                        .HasColumnType("int");

                    b.Property<int>("precio")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Categoriaid");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Reserva", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<bool>("pagado")
                        .HasColumnType("bit");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid");

                    b.ToTable("Reservas");
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

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AutoSpaApi.Models.Servicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.ToTable("Servicios");
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

            modelBuilder.Entity("AutoSpaApi.Models.Compra", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Usuario", "usuario")
                        .WithMany("compraPorCliente")
                        .HasForeignKey("Usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.DetallesCompras", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Compra", "compra")
                        .WithMany("detalleCompra")
                        .HasForeignKey("Compraid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoSpaApi.Models.Producto", "producto")
                        .WithMany("detalleCompra")
                        .HasForeignKey("Productoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.DetallesReserva", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Reserva", "reserva")
                        .WithMany("detalle")
                        .HasForeignKey("Reservaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoSpaApi.Models.Servicio", "servicio")
                        .WithMany("detalle")
                        .HasForeignKey("Servicioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.EncuestaPorUsuario", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Encuesta", "encuesta")
                        .WithMany("encuestaPorUsuarios")
                        .HasForeignKey("Encuestaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoSpaApi.Models.Usuario", "usuario")
                        .WithMany("encuestaPorUsuarios")
                        .HasForeignKey("Usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.Perfil", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Usuario", null)
                        .WithOne("perfil")
                        .HasForeignKey("AutoSpaApi.Models.Perfil", "Usuarioid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.Producto", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Categoria", "categorias")
                        .WithMany("productos")
                        .HasForeignKey("Categoriaid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AutoSpaApi.Models.Reserva", b =>
                {
                    b.HasOne("AutoSpaApi.Models.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("Usuarioid")
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
