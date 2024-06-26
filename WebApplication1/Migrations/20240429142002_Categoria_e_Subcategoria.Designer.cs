﻿// <auto-generated />
using FluxoCaixa.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FluxoCaixa.Migrations
{
    [DbContext(typeof(FluxoContext))]
    [Migration("20240429142002_Categoria_e_Subcategoria")]
    partial class Categoria_e_Subcategoria
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApplication1.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DscTipoCategoria")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("WebApplication1.Models.Subcategoria", b =>
                {
                    b.Property<int>("IdSubcategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DscTipoSubcategoria")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IdSubcategoria");

                    b.ToTable("Subcategoria");
                });
#pragma warning restore 612, 618
        }
    }
}
