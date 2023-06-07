﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using app1_Migrations.Modelos;

#nullable disable

namespace app1_Migrations.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230607015249_first")]
    partial class first
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("app1_Migrations.Modelos.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("app1_Migrations.Modelos.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("GeneroId")
                        .HasColumnType("integer");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.HasKey("Id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("app1_Migrations.Modelos.Usuario", b =>
                {
                    b.HasOne("app1_Migrations.Modelos.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
