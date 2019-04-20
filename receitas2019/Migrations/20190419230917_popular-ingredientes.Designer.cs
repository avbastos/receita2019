﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Receitas2019.Core.Context;

namespace Receitas2019.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190419230917_popular-ingredientes")]
    partial class popularingredientes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Receitas2019.Core.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Ingredientes");
                });

            modelBuilder.Entity("Receitas2019.Core.Models.IngredientesDaReceita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IngredienteId");

                    b.Property<float>("Quantidade");

                    b.Property<int?>("ReceitaId");

                    b.Property<int>("UnidadeDeMedida");

                    b.HasKey("Id");

                    b.HasIndex("IngredienteId");

                    b.HasIndex("ReceitaId");

                    b.ToTable("IngredientesDaReceitas");
                });

            modelBuilder.Entity("Receitas2019.Core.Models.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Foto");

                    b.Property<string>("ModoDePreparo");

                    b.Property<string>("Nome");

                    b.Property<float>("TempoDePreparo");

                    b.HasKey("Id");

                    b.ToTable("Receitas");
                });

            modelBuilder.Entity("Receitas2019.Core.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Receitas2019.Core.Models.IngredientesDaReceita", b =>
                {
                    b.HasOne("Receitas2019.Core.Models.Ingrediente", "Ingrediente")
                        .WithMany()
                        .HasForeignKey("IngredienteId");

                    b.HasOne("Receitas2019.Core.Models.Receita", "Receita")
                        .WithMany("Ingredientes")
                        .HasForeignKey("ReceitaId");
                });
#pragma warning restore 612, 618
        }
    }
}
