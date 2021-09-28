﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContexto))]
    partial class AppContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Veterinaria.App.Dominio.Anotacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaCracion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("historiaClinicaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("historiaClinicaId");

                    b.ToTable("Anotaciones");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaConsulta")
                        .HasColumnType("datetime2");

                    b.Property<int?>("mascotaId")
                        .HasColumnType("int");

                    b.Property<int?>("veterinarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("mascotaId");

                    b.HasIndex("veterinarioId");

                    b.ToTable("Citas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.HistoriaClinica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaActualizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("mascotaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("mascotaId");

                    b.ToTable("HistoriasClinicas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Mascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("propietarioId")
                        .HasColumnType("int");

                    b.Property<int?>("tipoMascotaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("propietarioId");

                    b.HasIndex("tipoMascotaId");

                    b.ToTable("Mascotas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicamentos");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("documento")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("documento")
                        .IsUnique()
                        .HasFilter("[documento] IS NOT NULL");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("anotacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("anotacionId");

                    b.ToTable("Recetas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.TipoMascota", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("clase")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TiposMascotas");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Auxiliar", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("Auxiliar");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Propietario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("Propietario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Veterinario", b =>
                {
                    b.HasBaseType("Veterinaria.App.Dominio.Persona");

                    b.Property<string>("tarjetaProfesional")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Veterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Anotacion", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.HistoriaClinica", "historiaClinica")
                        .WithMany()
                        .HasForeignKey("historiaClinicaId");

                    b.Navigation("historiaClinica");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Cita", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("mascotaId");

                    b.HasOne("Veterinaria.App.Dominio.Veterinario", "veterinario")
                        .WithMany()
                        .HasForeignKey("veterinarioId");

                    b.Navigation("mascota");

                    b.Navigation("veterinario");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.HistoriaClinica", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Mascota", "mascota")
                        .WithMany()
                        .HasForeignKey("mascotaId");

                    b.Navigation("mascota");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Mascota", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Propietario", "propietario")
                        .WithMany()
                        .HasForeignKey("propietarioId");

                    b.HasOne("Veterinaria.App.Dominio.TipoMascota", "tipoMascota")
                        .WithMany()
                        .HasForeignKey("tipoMascotaId");

                    b.Navigation("propietario");

                    b.Navigation("tipoMascota");
                });

            modelBuilder.Entity("Veterinaria.App.Dominio.Receta", b =>
                {
                    b.HasOne("Veterinaria.App.Dominio.Anotacion", "anotacion")
                        .WithMany()
                        .HasForeignKey("anotacionId");

                    b.Navigation("anotacion");
                });
#pragma warning restore 612, 618
        }
    }
}
